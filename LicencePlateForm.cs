using System.Text.RegularExpressions;

namespace LicencePlateManagement
{
    public partial class LicencePlateForm : Form
    {
        private readonly List<string> untaggedList = [];
        private readonly List<string> taggedList = [];



        (ListBox lstBox, List<string> lst, Box syn) selected;

        public LicencePlateForm()
        {
            InitializeComponent();

            // Set file dialogs to open in the current directory (where the program was executed from) by default
            dlgOpen.InitialDirectory =
            dlgSave.InitialDirectory = Environment.CurrentDirectory;


            // Initalise selectedList tuple to point to untagged list.
            selected = (
                lstUntagged,
                untaggedList,
                Box.UNTAGGED
            );


            // Set all buttons to refocus on the the input when clicked
            void FocusInput(object? _, EventArgs __) => txtInput.Focus();
            object[] controls = [.. Controls, .. grpSearch.Controls];
            foreach (Button b in controls.Where(c => c is Button).Cast<Button>())
            {
                b.Click += FocusInput;
            }

            CalculateFileNumber();
        }

        /// <summary>
        /// Calls add button method when the enter key is pressed in the input text box
        /// </summary>
        private void TxtInput_EnterPressed(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                BtnAdd_Click(null, new());
            }
        }


        private void Untag(object? sender, EventArgs e)
        {

            int selIndx = lstTagged.SelectedIndex;

            // Checks if the selected item is a string type (not null)
            // and assigns it to a variable if it is
            if (lstTagged.SelectedItem is string selItem)
            {
                // Move plate
                taggedList.RemoveAt(selIndx);
                Algorithms.AddSorted(untaggedList, selItem);

                // Sync list and select plate in untagged list
                SyncLists(Box.BOTH);
                lstUntagged.SelectedItem = selItem;

                statusMsg.Text = "Untagged plate: " + selItem;
            }
            else
                statusMsg.Text = "Nothing Selected";
        }

        // Regex for testing if a plate is valid or not.
        [GeneratedRegex(@"^1[A-Z]{3}-\d{3}$")]
        private static partial Regex ValidPlate();

        private bool ValidatePlate(string plate)
        {
            if (untaggedList.Contains(plate) || taggedList.Contains(plate))
            {
                statusMsg.Text = "Plate already in list";
                return false;
            }
            else if (!ValidPlate().IsMatch(plate))
            {
                statusMsg.Text = "Invalid Plate Format. Must be 1[3 letters]_[3 digits]";
                return false;
            }
            return true;
        }

        /// <summary>
        /// Add plate from input to main untagged list if it's valid and doesn't already exist
        /// </summary>
        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            string newPlate = Input.ToUpper();
            if (ValidatePlate(newPlate))
            {
                Algorithms.AddSorted(untaggedList, newPlate);
                SyncLists(Box.UNTAGGED);
                lstUntagged.SelectedItem = newPlate;

                // Clear and focus input box for next input
                txtInput.Clear();

                statusMsg.Text = $"Added Plate: {newPlate}";
            }
        }

        /// <summary>
        /// Edits the selected plate, performing the same validation as 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string newPlate = Input.ToUpper();
            string? oldPlate = (string?)selected.lstBox.SelectedItem;
            if (!ValidatePlate(newPlate)) return;
            if (oldPlate == null)
            {
                statusMsg.Text = "No plate selected to edit";
            }
            else
            {
                selected.lst[selected.lstBox.SelectedIndex] = newPlate;
                statusMsg.Text = $"Edited Plate {oldPlate} to be {newPlate}";
                SyncLists(selected.syn);
                selected.lstBox.SelectedItem = newPlate;

            }
        }

        private void SyncLists(Box category)
        {

            if (category is Box.TAGGED or Box.BOTH)
            {
                lstTagged.Items.Clear();
                lstTagged.Items.AddRange([.. taggedList]);
            }

            if (category is Box.UNTAGGED or Box.BOTH)
            {
                lstUntagged.Items.Clear();
                lstUntagged.Items.AddRange([.. untaggedList]);
            }
        }

        /// <summary>
        /// Resets plate data from both lists and the input text box
        /// </summary>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            untaggedList.Clear();
            taggedList.Clear();
            txtInput.Clear();
            SyncLists(Box.BOTH);
        }

        /// <summary>
        /// Shifts selected item from untagged to tagged list
        /// </summary>
        private void BtnTag_Click(object? sender, EventArgs e)
        {
            var selItem = (string?)lstUntagged.SelectedItem;
            int selIndx = lstUntagged.SelectedIndex;

            if (selItem != null)
            {
                untaggedList.RemoveAt(selIndx);
                Algorithms.AddSorted(taggedList, selItem);
                SyncLists(Box.BOTH);
                lstTagged.SelectedItem = selItem;
            }
            else
                statusMsg.Text = "Nothing Selected";


        }

        String Input
        {
            get => txtInput.Text.ToUpper();
            set => txtInput.Text = value.ToUpper();
        }


        private void BtnBinSearch_Click(object sender, EventArgs e)
        {
            statusMsg.Text = $"Searching for {Input} with Binary Search: ";
            int result;
            if ((result = selected.lst.BinarySearch(Input)) != -1)
            {
                statusMsg.Text += $"Found in untagged plates at index {result}";
            }
            else
                statusMsg.Text += "Plate not found";
        }


        private void BtnSeqSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show(e.ToString());
            statusMsg.Text = $"Searching for {Input} with Sequential Search: ";
            int result;
            if ((result = Algorithms.LinearSearch(selected.lst, Input)) != -1)
            {
                statusMsg.Text += $"Found in untagged plates at index {result}";
            }
            statusMsg.Text += "Plate not found";
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            var selBox = (ListBox)sender;
            List<string> lst;
            Box syncList;
            if (selBox.Name.Contains("Untagged"))
            {
                lst = untaggedList;
                syncList = Box.UNTAGGED;
            }
            else
            {

                lst = taggedList;
                syncList = Box.TAGGED;
            }
            this.selected = (selBox, lst, syncList);

            string? selected = (string?)this.selected.lstBox.SelectedItem;

            if (selected != null)
            {
                Input = selected;
            }
        }

        /// <summary>
        /// Removes the selected plate
        /// </summary>
        private void BtnExit_Click(object? sender, EventArgs e)
        {
            DeleteSelected();
        }

        /// <summary>
        /// Deletes the selected plate on double click
        /// </summary>
        private void Delete_DoubleClick(object? sender, MouseEventArgs e)
        {
            DeleteSelected();
        }

        /// <summary>
        /// Deletes the selected plate
        /// </summary>
        private void DeleteSelected()
        {
            int selndx = selected.lstBox.SelectedIndex;
            if (selndx != -1)
            {
                selected.lst.RemoveAt(selndx);
                SyncLists(selected.syn);
            }
        }
        #region File Management
        private string FileName
            => $"day_{_fileNo:d2}.txt";

        private int FileNo
        {
            get => _fileNo;
            set => _fileNo = value;
        }

        private int _fileNo = 1;

        /// <summary>
        /// Increments the file number, skipping numbers that already exist.<br/>
        /// Also updates the file path label
        /// </summary>
        private void CalculateFileNumber()
        {
            var files = Directory.GetFiles(Directory.GetCurrentDirectory()).Select(Path.GetFileName);

            while (files.Contains(FileName))
                FileNo++;

            lblDay.Text = $"day {_fileNo:d2}";
        }

        /// <summary>
        /// 
        /// </summary>
        private void BtnSave_Click(object sender, EventArgs e)
        {

            CalculateFileNumber();
            dlgSave.FileName = FileName;
            dlgSave.ShowDialog();

        }

        /// <summary>
        /// Spawns an open file dialog
        /// </summary>
        private void BtnOpen_Click(object sender, EventArgs e)
            => dlgOpen.ShowDialog();


        // Regular expression to check file name format
        [GeneratedRegex(@"^day_\d{2,}(\.\w+)$", RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace)]
        private static partial Regex FileFormat();

        /// <summary>
        /// Updates file path label to reflect loaded file.
        /// </summary>
        /// <param name="file">Name of file</param>
        private void SetFileLabel(string file)
        {
            if (file != FileName)
            {
                if (FileFormat().IsMatch(file))
                    // Remove file extention and underscore to just get $"day {no}"
                    lblDay.Text = file.Split('.')[0].Replace('_', ' ');
                else
                    lblDay.Text = $"File name: {file}";
            }
            else
            {
                CalculateFileNumber();
            }
        }

        /// <summary>
        /// Called from Open file dialog
        /// </summary>
        private void FileOpened(object sender, System.ComponentModel.CancelEventArgs e)
        {

            string path = dlgOpen.FileName;
            string fileName = Path.GetFileName(path);


            taggedList.Clear();
            untaggedList.Clear();
            try
            {
                using var op = new StreamReader(path);
                for (string? line = op.ReadLine(); line != null; line = op.ReadLine())
                {
                    string[] plate = line.Split(",");
                    if (ValidPlate().IsMatch(plate[0]))
                        (plate.Length >= 2 && plate[1] == "*"
                            ? taggedList
                            : untaggedList).Add(plate[0]);
                }
                statusMsg.Text = "Successfully loaded from file: " + fileName;
                SetFileLabel(fileName);
                SyncLists(Box.BOTH);
            }
            catch (Exception ex)
            {
                statusMsg.Text = $"Error while loading file {fileName}: " + ex.Message;
            }
        }

        /// <summary>
        /// Called from save dialog 
        /// </summary>
        private void FileSaved(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string file = dlgSave.FileName;
            Save(file);
        }

        /// <summary>
        /// Saves on close
        /// </summary>
        private void SaveOnClose(object sender, EventArgs e)
            => Save(FileName);

        /// <summary>
        /// Saves plates to file
        /// </summary>
        /// <param name="path">Path to file where plate data is to be saved.</param>
        private void Save(string path)
        {
            try
            {
                using StreamWriter wr = new(path);
                foreach (string plate in taggedList)
                {
                    wr.WriteLine(plate + ",*");
                }
                foreach (string plate in untaggedList)
                {
                    wr.WriteLine(plate + ",");
                }

                statusMsg.Text = $"Saved as file {path}";
                SetFileLabel(Path.GetFileName(path));
            }
            catch (Exception ex)
            {
                statusMsg.Text = "Saving failed: " + ex.Message;
            }
        }

        #endregion

        private enum Box { TAGGED, UNTAGGED, BOTH }
    }
}

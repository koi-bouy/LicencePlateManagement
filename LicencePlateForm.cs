// Raphael Fernandes, 30099423
// Date: 17/11/2025
// Version: 1.0
// Name: Active Systems Pty. Library Management System
// Logic for program that keeps track of West Australian licence plates.
using System.Text.RegularExpressions;

namespace LicencePlateManagement
{
    public partial class LicencePlateForm : Form
    {
        private readonly List<string> untaggedList = [];
        private readonly List<string> taggedList = [];



        (ListBox lstBox, List<string> lst, SyncOption syn) selected;

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
                SyncOption.UNTAGGED
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
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnAdd_Click(null, new());
                e.Handled = true;
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
                SyncLists(SyncOption.BOTH);
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
            string? listName = string.Empty;
            if (untaggedList.Contains(plate))
                listName = "untagged";
            if (taggedList.Contains(plate))
                listName = "tagged";

            if (listName is not null)
            {
                statusMsg.Text = $"Plate already in {listName} list";
                return false;
            }
            else if (!ValidPlate().IsMatch(plate))
            {
                statusMsg.Text = "Invalid Plate Format. Must be 1[3 letters]-[3 digits]";
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
                SyncLists(SyncOption.UNTAGGED);
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
            if (ValidatePlate(newPlate))
            {
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
        }

        private void SyncLists(SyncOption category)
        {

            if (category is SyncOption.TAGGED or SyncOption.BOTH)
            {
                lstTagged.Items.Clear();
                lstTagged.Items.AddRange([.. taggedList]);
            }

            if (category is SyncOption.UNTAGGED or SyncOption.BOTH)
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
            SyncLists(SyncOption.BOTH);
            statusMsg.Text = "Reset all data.";
        }

        /// <summary>
        /// Shifts selected item from untagged to tagged list
        /// </summary>
        private void BtnTag_Click(object? sender, EventArgs e)
        {
            int selIndx = lstUntagged.SelectedIndex;

            if (lstUntagged.SelectedItem is string selItem)
            {
                untaggedList.RemoveAt(selIndx);
                Algorithms.AddSorted(taggedList, selItem);
                SyncLists(SyncOption.BOTH);
                lstTagged.SelectedItem = selItem;
                statusMsg.Text = "Tagged plate: " + selItem;
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
            if (untaggedList.BinarySearch(Input, StringComparer.OrdinalIgnoreCase) is int result && result != -1)
            {
                lstUntagged.SelectedIndex = result;
                statusMsg.Text += $"Found in untagged plates at index {result}";
            }
            else
            {
                statusMsg.Text += "Plate not found";
                txtInput.Clear();
            }
        }

        /// <summary>
        /// Uses the Linear Search algorithm to find the input plate in the untagged list
        /// </summary>
        private void BtnLinSearch_Click(object sender, EventArgs e)
        {
            statusMsg.Text = $"Searching for {Input} with Linear Search: ";
            if (Algorithms.LinearSearch(untaggedList, Input) is int result && result != -1)
            {
                lstUntagged.SelectedIndex = result;
                statusMsg.Text += $"Found in untagged plates at index {result}";
            }
            else
            {
                statusMsg.Text += "Plate not found";
                txtInput.Clear();
            }
        }

        /// <summary>
        /// Puts the selected licence plate into the textbox
        /// </summary>
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            var selBox = (ListBox)sender;
            List<string> lst;
            SyncOption syncList;
            if (selBox.Name.Contains("Untagged"))
            {
                lst = untaggedList;
                syncList = SyncOption.UNTAGGED;
            }
            else
            {
                lst = taggedList;
                syncList = SyncOption.TAGGED;
            }
            selected = (selBox, lst, syncList);

            if (selected.lstBox.SelectedItem is string selItem)
            {
                Input = selItem;
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
            if (selected.lstBox.SelectedItem is string selItem)
            {
                selected.lst.RemoveAt(selndx);
                SyncLists(selected.syn);
                statusMsg.Text = "Deleted plate: " + selItem;
            }
            else
                statusMsg.Text = "Nothing selected to delete.";
        }
        #region File Management
        private string FileName
            => $"day_{fileNo:d2}.txt";
        private int fileNo = 1;

        /// <summary>
        /// Increments the file number, skipping numbers that already exist.<br/>
        /// Also updates the file path label
        /// </summary>
        private void CalculateFileNumber()
        {
            var files = Directory.GetFiles(Directory.GetCurrentDirectory()).Select(Path.GetFileName);

            while (files.Contains(FileName))
                fileNo++;

            lblDay.Text = $"day {fileNo:d2}";
        }

        /// <summary>
        /// Calculates the day number and shows the save dialog box
        /// </summary>
        private void BtnSave_Click(object sender, EventArgs e)
        {

            CalculateFileNumber();
            dlgSave.FileName = FileName;
            dlgSave.ShowDialog();

        }

        /// <summary>
        /// Shows the open file dialog box
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
                SyncLists(SyncOption.BOTH);
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


        private void UnselectTagged(object? _, EventArgs __)
            => lstUntagged.SelectedItem = null;

        private void UnselectUntagged(object? _, EventArgs __)
            => lstTagged.SelectedItem = null;


        /// <summary>
        /// Tells SyncLists which lists to sync
        /// </summary>
        private enum SyncOption
        {
            /// <summary>
            /// Sync only Tagged List
            /// </summary>
            TAGGED,
            /// <summary>
            /// Sync only Untagged List
            /// </summary>
            UNTAGGED,
            /// <summary>
            /// Sync both Lists
            /// </summary>
            BOTH
        }
    }
}

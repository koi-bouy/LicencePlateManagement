using System.Text.RegularExpressions;

namespace LicencePlateManagement
{
    public partial class LicencePlateForm : Form
    {
        private readonly List<string> untaggedList = [];
        private readonly List<string> taggedList = [];



        (ListBox lstBox, List<string> lst, Box syn) selectedList;

        public LicencePlateForm()
        {
            InitializeComponent();
            lstUntagged.MouseDoubleClick += BtnDelete_Click;
            lstTagged.MouseDoubleClick += Untag;
            txtInput.KeyPress += TxtInput_EnterPressed;
            selectedList = (
                lstUntagged,
                untaggedList,
                Box.UNTAGGED
            );
        }

        private void TxtInput_EnterPressed(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                Add(sender, e);
            }
        }

        private void FocusText(object? sender, MouseEventArgs e) => txtInput.Focus();

        private void Untag(object? sender, MouseEventArgs e)
        {
            var selItem = (string?)lstTagged.SelectedItem;
            int selIndx = lstTagged.SelectedIndex;

            if (selItem != null)
            {
                taggedList.RemoveAt(selIndx);
                Algorithms.AddSorted(untaggedList, selItem);
                SyncLists(Box.BOTH);
                lstUntagged.SelectedItem = selItem;

            }
            else
                statusMsg.Text = "Nothing Selected";
        }

        [GeneratedRegex(@"^1[A-Z]{3}-\d{3}$")]
        private static partial Regex ValidPlate();

        private void Add(object? sender, EventArgs e)
        {
            string newPlate = Input.ToUpper();
            txtInput.Clear();
            if (untaggedList.Contains(newPlate) || taggedList.Contains(newPlate))
            {
                statusMsg.Text = "Plate already in list";
            }
            else if (ValidPlate().IsMatch(newPlate))
            {
                Algorithms.AddSorted(untaggedList, newPlate);
                SyncLists(Box.UNTAGGED);
                lstUntagged.SelectedItem = newPlate;
                statusMsg.Text = $"Added Plate {newPlate}";

            }
            else
                statusMsg.Text = "Invalid Plate";


        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string newPlate = Input.ToUpper();
            string? oldPlate = (string?)selectedList.lstBox.SelectedItem;


            if (oldPlate == null)
                statusMsg.Text = "No plate selected to edit";
            else if (untaggedList.Contains(newPlate) || taggedList.Contains(newPlate))
                statusMsg.Text = "Plate already in list";
            else if (!ValidPlate().IsMatch(newPlate))
                statusMsg.Text = "Invalid Plate";
            else
            {
                selectedList.lst[selectedList.lstBox.SelectedIndex] = newPlate;
                statusMsg.Text = $"Edited Plate {oldPlate} to be {newPlate}";
                SyncLists(selectedList.syn);

            }
        }

        private void SyncLists(Box? category)
        {

            if (category is Box.TAGGED or Box.BOTH)
            {
                var selIndx = lstTagged.SelectedIndex;
                lstTagged.Items.Clear();
                lstTagged.Items.AddRange([.. taggedList]);
                lstTagged.SelectedIndex = selIndx;

            }

            if (category is Box.UNTAGGED or Box.BOTH)
            {
                var selIndx = lstUntagged.SelectedIndex;
                lstUntagged.Items.Clear();
                lstUntagged.Items.AddRange([.. untaggedList]);
                lstUntagged.SelectedItem = selIndx;
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Func<List<string>, string, int> Search;
            statusMsg.Text = $"Searching for {Input} with ";

            if (rdoBinary.Checked)
            {
                statusMsg.Text += "Binary Search: ";
                Search = Algorithms.BinarySearch;
            }
            else
            {
                statusMsg.Text += "Linear Search: ";
                Search = Algorithms.SequentialSearch;
            }

            int result;
            if ((result = Search(untaggedList, Input)) != -1)
            {
                statusMsg.Text += $"Found in untagged plates at index {result}";
                lstUntagged.SelectedIndex = result;
            }
            else if ((result = Search(taggedList, Input)) != -1)
            {
                statusMsg.Text += $"Found in tagged plates at index {result}";
                lstTagged.SelectedIndex = result;
            }
            else
                statusMsg.Text += "Plate not found";


        }

        private void BtnBinSearch_Click(object sender, EventArgs e)
        {
            statusMsg.Text = $"Searching for {Input} with Binary Search: ";
            int result;
            if ((result = selectedList.lst.BinarySearch(Input)) != -1)
            {
                statusMsg.Text += $"Found in untagged plates at index {result}";
            }
            else
                statusMsg.Text += "Plate not found";
        }

        private void BtnSeqSearch_Click(object sender, EventArgs e)
        {
            statusMsg.Text = $"Searching for {Input} with Sequential Search: ";
            int result;
            if ((result = Algorithms.SequentialSearch(selectedList.lst, Input)) != -1)
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
            selectedList = (selBox, lst, syncList);

            string? selected = (string?)selectedList.lstBox.SelectedItem;

            if (selected != null)
            {
                Input = selected;
            }
        }

        /// <summary>
        /// Deletes the selected item
        /// </summary>
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            int selndx = selectedList.lstBox.SelectedIndex;
            if (selndx != -1)
            {
                selectedList.lst.RemoveAt(selndx);
                SyncLists(selectedList.syn);
            }
        }
        #region File Management
        private string FileName
            => $"day_{_fileNo:d2}.txt";

        private int FileNo
        {
            get => _fileNo;
            set
            {
                _fileNo = value;
                lblDay.Text = $"day {_fileNo}";
            }
        }

        private int _fileNo = 1;

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var files = Directory.GetFiles(Directory.GetCurrentDirectory()).Select(Path.GetFileName);

            while (files.Contains(FileName))
                FileNo++;


            using StreamWriter wr = new(FileName);

            foreach (string plate in taggedList)
            {
                wr.WriteLine(plate + ",*");
            }
            foreach (string plate in untaggedList)
            {
                wr.WriteLine(plate + ",");
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (!File.Exists(FileName))
            {
                statusMsg.Text = "No files ";
                return;
            }

            taggedList.Clear();
            untaggedList.Clear();
            using (var op = new StreamReader(FileName))
                for (string? line = op.ReadLine(); line != null; line = op.ReadLine())
                {
                    string[] plate = line.Split(",");
                    if (ValidPlate().IsMatch(plate[0]))
                        (plate.Length >= 2 && plate[1] == "*"
                            ? taggedList
                            : untaggedList).Add(plate[0]);
                }

            SyncLists(Box.BOTH);
        }
        #endregion

        private enum Box { TAGGED, UNTAGGED, BOTH }
    }
}

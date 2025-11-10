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
            rdoBinary.Checked = true;
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
                SyncLists(selectedList.syn);
                statusMsg.Text = $"Added Plate {newPlate}";

            }
        }

        private void SyncLists(Box? category)
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

        private void BtnReset_Click(object sender, EventArgs e)
        {
            untaggedList.Clear();
            taggedList.Clear();
            SyncLists(Box.BOTH);
        }

        private void BtnTag_Click(object? sender, EventArgs e)
        {
            var selItem = (string?)lstUntagged.SelectedItem;
            int selIndx = lstUntagged.SelectedIndex;

            if (selItem != null)
            {
                untaggedList.RemoveAt(selIndx);
                Algorithms.AddSorted(taggedList, selItem);
                SyncLists(Box.BOTH);
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

            if (selected != null && selected != Input)
            {
                Input = selected;
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            int selndx = selectedList.lstBox.SelectedIndex;
            if (selndx != -1)
            {
                selectedList.lst.RemoveAt(selndx);
                SyncLists(Box.BOTH);
            }
        }

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


            using StreamWriter sw = new(FileName);

            foreach (string plate in taggedList)
            {
                sw.WriteLine(plate + ",*");
            }
            foreach (string plate in untaggedList)
            {
                sw.WriteLine(plate + ",");
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (!File.Exists(FileName)) return;
            taggedList.Clear();
            untaggedList.Clear();
            using (StreamReader sr = new(FileName))
            {
                for (string[]? line = sr.ReadLine()?.Split(","); line != null; line = sr.ReadLine()?.Split(","))
                {
                    if (line.Length >= 2 && line[1] == "*")
                        taggedList.Add(line[0]);
                    else
                        untaggedList.Add(line[0]);

                }
            }
            SyncLists(Box.BOTH);
        }

        private enum Box { TAGGED, UNTAGGED, BOTH }
    }
}

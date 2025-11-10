using System.Text.RegularExpressions;

namespace LicencePlateManagement
{
    public partial class LicencePlateForm : Form
    {
        private readonly List<string> untaggedList = [];
        private readonly List<string> taggedList = [];

        public LicencePlateForm()
        {
            InitializeComponent();
            lstUntagged.MouseDoubleClick += FocusText;
            lstTagged.MouseDoubleClick += Untag;
            rdoBinary.Checked = true;
            txtInput.KeyPress += TxtInput_EnterPressed;
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
            string[] selItems = [.. lstTagged.SelectedItems.Cast<string>()];
            var selIndices = lstTagged.SelectedIndices.Cast<int>().Reverse();

            foreach (int selIndx in selIndices)
            {
                taggedList.RemoveAt(selIndx);
            }


            Algorithms.Merge(untaggedList, selItems);
            SyncLists(Box.BOTH);
        }

        [GeneratedRegex(@"^1[A-Z]{3}-\d{3}$")]
        private static partial Regex ValidPlate();

        private void Add(object? sender, EventArgs e)
        {
            string newPlate = txtInput.Text.ToUpper();
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
            string newPlate = txtInput.Text.ToUpper();
            string? oldPlate = (string?)lstUntagged.SelectedItem;
            if (oldPlate == null)
                statusMsg.Text = "No plate selected to edit";

            else if (untaggedList.Contains(newPlate) || taggedList.Contains(newPlate))
            {
                statusMsg.Text = "Plate already in list";
            }
            else if (!ValidPlate().IsMatch(newPlate))
                statusMsg.Text = "Invalid Plate";
            else
            {
                untaggedList[lstUntagged.SelectedIndex] = newPlate;
                SyncLists(Box.UNTAGGED);
                statusMsg.Text = $"Added Plate {newPlate}";

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

        private void BtnReset_Click(object sender, EventArgs e)
        {
            untaggedList.Clear();
            taggedList.Clear();
            SyncLists(Box.BOTH);
        }

        private void BtnTag_Click(object? sender, EventArgs e)
        {
            string[] selItems = [.. lstUntagged.SelectedItems.Cast<string>()];
            var selIndices = lstUntagged.SelectedIndices.Cast<int>().Reverse();

            foreach (int selIndx in selIndices)
            {
                untaggedList.RemoveAt(selIndx);
            }


            Algorithms.Merge(taggedList, selItems);
            SyncLists(Box.BOTH);


        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Func<List<string>, string, int> Search = rdoBinary.Checked ?
                Algorithms.BinarySearch
                : Algorithms.SequentialSearch;
            if (rdoBinary.Checked)
            {
                int result;
                if ((result = Search(untaggedList, txtInput.Text)) != -1)
                    lstUntagged.SelectedIndex = result;
                else if ((result = Search(taggedList, txtInput.Text)) != -1)
                    lstTagged.SelectedIndex = result;
                else
                    statusMsg.Text = "Plate not found";

            }
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selected = (string?)((ListBox)sender).SelectedItem;
            if (selected != null && selected != txtInput.Text)
            {
                txtInput.Text = selected;
            }
        }

        private enum Box { TAGGED, UNTAGGED, BOTH }


    }
}

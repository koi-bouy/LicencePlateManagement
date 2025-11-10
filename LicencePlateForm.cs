using System.Text.RegularExpressions;

namespace LicencePlateManager
{
    public partial class LicencePlateForm : Form
    {
        List<string> untaggedList = [];
        List<string> taggedList = [];

        public LicencePlateForm()
        {
            InitializeComponent();
            lstUntagged.MouseDoubleClick += FocusText;
            lstTagged.MouseDoubleClick += FocusText;
        }


        private bool ValidatePlate(string regoPlate)
        {
            return ValidPlate().IsMatch(regoPlate);
        }

        private void FocusText(object? sender, MouseEventArgs e) => textBox1.Focus();

        [GeneratedRegex(@"^1[A-Z]{3}-\d{3}$")]
        private static partial Regex ValidPlate();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newPlate = textBox1.Text.ToUpper();
            textBox1.Clear();
            if (ValidatePlate(newPlate))
            {
                untaggedList.Add(newPlate);
                SyncLists(Box.UNTAGGED);
                toolStripStatusLabel1.Text = $"Added Plate {newPlate}";

            }
            else
            {
                toolStripStatusLabel1.Text = "Invalid Plate";
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            untaggedList.Clear();
            taggedList.Clear();
            SyncLists(Box.BOTH);
        }

        //private void btnTag_Click(object sender, EventArgs e)
        //{
        //    string[] selItems = [.. lstTagged.SelectedItems.Cast<string>()];
        //    foreach (int index in lstTagged.SelectedIndices.Cast<int>())
        //    {
        //        lstTagged.Items.
        //    }
            
        //}

        private enum Box { TAGGED, UNTAGGED, BOTH }


    }
}

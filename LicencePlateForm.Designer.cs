namespace LicencePlateManagement
{
    partial class LicencePlateForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            title = new Label();
            lblDay = new Label();
            subtitle = new Label();
            untaggedLabel = new Label();
            lblInput = new Label();
            lblTagged = new Label();
            logo = new PictureBox();
            lstUntagged = new ListBox();
            lstTagged = new ListBox();
            statusStrip1 = new StatusStrip();
            statusMsg = new ToolStripStatusLabel();
            txtInput = new TextBox();
            btnAdd = new Button();
            btnExit = new Button();
            btnBinSearch = new Button();
            btnEdit = new Button();
            btnReset = new Button();
            btnSave = new Button();
            btnOpen = new Button();
            grpSearch = new GroupBox();
            btnSeqSearch = new Button();
            btnTag = new Button();
            dlgOpen = new OpenFileDialog();
            dlgSave = new SaveFileDialog();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            statusStrip1.SuspendLayout();
            grpSearch.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 16F);
            title.Location = new Point(10, 7);
            title.Name = "title";
            title.Size = new Size(197, 30);
            title.TabIndex = 0;
            title.Text = "Active Systems Pty.";
            toolTip1.SetToolTip(title, "Active Systems Pty.");
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Location = new Point(332, 36);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(35, 15);
            lblDay.TabIndex = 1;
            lblDay.Text = "day 1";
            toolTip1.SetToolTip(lblDay, "Currently loaded file.");
            // 
            // subtitle
            // 
            subtitle.AutoSize = true;
            subtitle.Font = new Font("Segoe UI", 10F);
            subtitle.Location = new Point(18, 34);
            subtitle.Name = "subtitle";
            subtitle.Size = new Size(173, 19);
            subtitle.TabIndex = 2;
            subtitle.Text = "Licence Plate Management";
            toolTip1.SetToolTip(subtitle, "Licence Plate Management");
            // 
            // untaggedLabel
            // 
            untaggedLabel.AutoSize = true;
            untaggedLabel.Location = new Point(28, 79);
            untaggedLabel.Name = "untaggedLabel";
            untaggedLabel.Size = new Size(93, 15);
            untaggedLabel.TabIndex = 3;
            untaggedLabel.Text = "Untagged Plates";
            toolTip1.SetToolTip(untaggedLabel, "Untagged Plates");
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(165, 99);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(35, 15);
            lblInput.TabIndex = 4;
            lblInput.Text = "Input";
            toolTip1.SetToolTip(lblInput, "Input");
            // 
            // lblTagged
            // 
            lblTagged.AutoSize = true;
            lblTagged.Location = new Point(370, 80);
            lblTagged.Margin = new Padding(0, 2, 0, 2);
            lblTagged.Name = "lblTagged";
            lblTagged.Size = new Size(101, 15);
            lblTagged.TabIndex = 5;
            lblTagged.Text = "Tagged for review";
            toolTip1.SetToolTip(lblTagged, "Tagged for review");
            // 
            // logo
            // 
            logo.Image = Properties.Resources.Logo;
            logo.Location = new Point(226, 9);
            logo.Margin = new Padding(3, 2, 3, 2);
            logo.Name = "logo";
            logo.Size = new Size(58, 52);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 6;
            logo.TabStop = false;
            toolTip1.SetToolTip(logo, "Active Systems Pty. Logo");
            // 
            // lstUntagged
            // 
            lstUntagged.FormattingEnabled = true;
            lstUntagged.ItemHeight = 15;
            lstUntagged.Location = new Point(28, 99);
            lstUntagged.Margin = new Padding(3, 2, 3, 2);
            lstUntagged.Name = "lstUntagged";
            lstUntagged.Size = new Size(132, 169);
            lstUntagged.TabIndex = 7;
            toolTip1.SetToolTip(lstUntagged, "Main list.\nClick a plate entry to select, double click to delete.");
            lstUntagged.Click += UnselectUntagged;
            lstUntagged.SelectedIndexChanged += SelectedIndexChanged;
            lstUntagged.MouseDoubleClick += DeleteSelected;
            // 
            // lstTagged
            // 
            lstTagged.FormattingEnabled = true;
            lstTagged.ItemHeight = 15;
            lstTagged.Location = new Point(371, 99);
            lstTagged.Margin = new Padding(3, 2, 3, 2);
            lstTagged.Name = "lstTagged";
            lstTagged.Size = new Size(132, 169);
            lstTagged.TabIndex = 8;
            toolTip1.SetToolTip(lstTagged, "List of tagged license plates.\nClick a plate to select, double click to untag.");
            lstTagged.Click += UnselectTagged;
            lstTagged.SelectedIndexChanged += SelectedIndexChanged;
            lstTagged.MouseDoubleClick += Untag;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusMsg });
            statusStrip1.Location = new Point(0, 316);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(520, 22);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            toolTip1.SetToolTip(statusStrip1, "Error/Status messages will appear here.");
            // 
            // statusMsg
            // 
            statusMsg.Name = "statusMsg";
            statusMsg.Size = new Size(144, 17);
            statusMsg.Text = "Messages will appear here";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(165, 116);
            txtInput.Margin = new Padding(3, 2, 3, 2);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(201, 23);
            txtInput.TabIndex = 10;
            toolTip1.SetToolTip(txtInput, "Enter a plate here for searching, adding or editting.");
            txtInput.KeyPress += TxtInput_EnterPressed;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Location = new Point(164, 168);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Enter";
            toolTip1.SetToolTip(btnAdd, "Click to add the licence plate in the text box to the list.\nThe new plate must be in the format '1[3 letters]-[3 digits]'.");
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.Location = new Point(165, 194);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(82, 22);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            toolTip1.SetToolTip(btnExit, "Removes currently selected item from the main untagged list.");
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += DeleteSelected;
            // 
            // btnBinSearch
            // 
            btnBinSearch.Cursor = Cursors.Hand;
            btnBinSearch.Location = new Point(5, 20);
            btnBinSearch.Margin = new Padding(3, 2, 3, 2);
            btnBinSearch.Name = "btnBinSearch";
            btnBinSearch.Size = new Size(82, 22);
            btnBinSearch.TabIndex = 13;
            btnBinSearch.Text = "Binary";
            toolTip1.SetToolTip(btnBinSearch, "Click to search the list for the plate in the text box\nusing the Binary search algorithm.");
            btnBinSearch.UseVisualStyleBackColor = true;
            btnBinSearch.Click += BtnBinSearch_Click;
            // 
            // btnEdit
            // 
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Location = new Point(164, 142);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 22);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Edit";
            toolTip1.SetToolTip(btnEdit, "Click to replace the selected licence plate with the one in the text box.\nThe new plate must be in the format '1[3 letters]-[3 digits]'.");
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Red;
            btnReset.Cursor = Cursors.Hand;
            btnReset.ForeColor = SystemColors.Window;
            btnReset.Location = new Point(420, 295);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(82, 22);
            btnReset.TabIndex = 16;
            btnReset.Text = "Reset";
            toolTip1.SetToolTip(btnReset, "Click to clear both lists and text box.");
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += BtnReset_Click;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.Location = new Point(332, 9);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            toolTip1.SetToolTip(btnSave, "Click to save licence plate data to file.");
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnOpen
            // 
            btnOpen.Cursor = Cursors.Hand;
            btnOpen.Location = new Point(420, 9);
            btnOpen.Margin = new Padding(3, 2, 3, 2);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(82, 22);
            btnOpen.TabIndex = 18;
            btnOpen.Text = "Open";
            toolTip1.SetToolTip(btnOpen, "Click to open file containing saved licence plate data.");
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += BtnOpen_Click;
            // 
            // grpSearch
            // 
            grpSearch.Controls.Add(btnSeqSearch);
            grpSearch.Controls.Add(btnBinSearch);
            grpSearch.Location = new Point(272, 142);
            grpSearch.Margin = new Padding(3, 2, 3, 2);
            grpSearch.Name = "grpSearch";
            grpSearch.Padding = new Padding(3, 2, 3, 2);
            grpSearch.Size = new Size(94, 72);
            grpSearch.TabIndex = 21;
            grpSearch.TabStop = false;
            grpSearch.Text = "Search";
            toolTip1.SetToolTip(grpSearch, "Search buttons");
            // 
            // btnSeqSearch
            // 
            btnSeqSearch.Cursor = Cursors.Hand;
            btnSeqSearch.Location = new Point(5, 46);
            btnSeqSearch.Margin = new Padding(3, 2, 3, 2);
            btnSeqSearch.Name = "btnSeqSearch";
            btnSeqSearch.Size = new Size(82, 22);
            btnSeqSearch.TabIndex = 22;
            btnSeqSearch.Text = "Linear";
            toolTip1.SetToolTip(btnSeqSearch, "Click to search the list for the plate in the text box\nusing the Linear/Sequential seatch algorithm.");
            btnSeqSearch.UseVisualStyleBackColor = true;
            btnSeqSearch.Click += BtnLinSearch_Click;
            // 
            // btnTag
            // 
            btnTag.Cursor = Cursors.Hand;
            btnTag.Location = new Point(28, 272);
            btnTag.Margin = new Padding(3, 2, 3, 2);
            btnTag.Name = "btnTag";
            btnTag.Size = new Size(82, 24);
            btnTag.TabIndex = 15;
            btnTag.Text = "Tag";
            toolTip1.SetToolTip(btnTag, "Move selected item from the main  untagged list to the tagged list.");
            btnTag.UseVisualStyleBackColor = true;
            btnTag.Click += BtnTag_Click;
            // 
            // dlgOpen
            // 
            dlgOpen.DefaultExt = "txt";
            dlgOpen.FileName = "*.txt";
            dlgOpen.Filter = "Text Files (*.txt)| *.txt";
            dlgOpen.FileOk += FileOpened;
            // 
            // dlgSave
            // 
            dlgSave.DefaultExt = "txt";
            dlgSave.Filter = "Text Files (*.txt)| *.txt";
            dlgSave.FileOk += FileSaved;
            // 
            // LicencePlateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 338);
            Controls.Add(grpSearch);
            Controls.Add(btnOpen);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(btnReset);
            Controls.Add(btnTag);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtInput);
            Controls.Add(statusStrip1);
            Controls.Add(lstTagged);
            Controls.Add(lstUntagged);
            Controls.Add(logo);
            Controls.Add(lblTagged);
            Controls.Add(lblInput);
            Controls.Add(untaggedLabel);
            Controls.Add(subtitle);
            Controls.Add(lblDay);
            Controls.Add(title);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LicencePlateForm";
            Text = "Active Systems Pty.";
            FormClosed += SaveOnClose;
            Load += LicencePlateForm_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            grpSearch.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label lblDay;
        private Label subtitle;
        private Label untaggedLabel;
        private Label lblInput;
        private Label lblTagged;
        private PictureBox logo;
        private ListBox lstUntagged;
        private ListBox lstTagged;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusMsg;
        private TextBox txtInput;
        private Button btnAdd;
        private Button btnExit;
        private Button btnBinSearch;
        private Button btnEdit;
        private Button btnTag;
        private Button btnReset;
        private Button btnSave;
        private Button btnOpen;
        private GroupBox grpSearch;
        private Button btnSeqSearch;
        private OpenFileDialog dlgOpen;
        private SaveFileDialog dlgSave;
        private ToolTip toolTip1;
    }
}

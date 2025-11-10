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
            title = new Label();
            lblDay = new Label();
            subtitle = new Label();
            untaggedLabel = new Label();
            lblEdit = new Label();
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
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            statusStrip1.SuspendLayout();
            grpSearch.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 16F);
            title.Location = new Point(11, 9);
            title.Name = "title";
            title.Size = new Size(240, 37);
            title.TabIndex = 0;
            title.Text = "Active Systems Pty.";
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Location = new Point(380, 48);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(45, 20);
            lblDay.TabIndex = 1;
            lblDay.Text = "day 1";
            // 
            // subtitle
            // 
            subtitle.AutoSize = true;
            subtitle.Font = new Font("Segoe UI", 10F);
            subtitle.Location = new Point(21, 45);
            subtitle.Name = "subtitle";
            subtitle.Size = new Size(216, 23);
            subtitle.TabIndex = 2;
            subtitle.Text = "Licence Plate Management";
            // 
            // untaggedLabel
            // 
            untaggedLabel.AutoSize = true;
            untaggedLabel.Location = new Point(32, 105);
            untaggedLabel.Name = "untaggedLabel";
            untaggedLabel.Size = new Size(118, 20);
            untaggedLabel.TabIndex = 3;
            untaggedLabel.Text = "Untagged Plates";
            // 
            // lblEdit
            // 
            lblEdit.AutoSize = true;
            lblEdit.Location = new Point(189, 132);
            lblEdit.Name = "lblEdit";
            lblEdit.Size = new Size(39, 20);
            lblEdit.TabIndex = 4;
            lblEdit.Text = "Edit ";
            // 
            // lblTagged
            // 
            lblTagged.AutoSize = true;
            lblTagged.Location = new Point(423, 106);
            lblTagged.Margin = new Padding(0, 3, 0, 3);
            lblTagged.Name = "lblTagged";
            lblTagged.Size = new Size(128, 20);
            lblTagged.TabIndex = 5;
            lblTagged.Text = "Tagged for review";
            // 
            // logo
            // 
            logo.Image = Properties.Resources.Logo;
            logo.Location = new Point(258, 12);
            logo.Name = "logo";
            logo.Size = new Size(66, 69);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 6;
            logo.TabStop = false;
            // 
            // lstUntagged
            // 
            lstUntagged.FormattingEnabled = true;
            lstUntagged.Location = new Point(32, 132);
            lstUntagged.Name = "lstUntagged";
            lstUntagged.Size = new Size(150, 224);
            lstUntagged.TabIndex = 7;
            lstUntagged.SelectedIndexChanged += SelectedIndexChanged;
            // 
            // lstTagged
            // 
            lstTagged.FormattingEnabled = true;
            lstTagged.Location = new Point(424, 132);
            lstTagged.Name = "lstTagged";
            lstTagged.Size = new Size(150, 224);
            lstTagged.TabIndex = 8;
            lstTagged.SelectedIndexChanged += SelectedIndexChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusMsg });
            statusStrip1.Location = new Point(0, 425);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(581, 26);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusMsg
            // 
            statusMsg.Name = "statusMsg";
            statusMsg.Size = new Size(184, 20);
            statusMsg.Text = "Messages will appear here";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(189, 155);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(229, 27);
            txtInput.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(188, 224);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += Add;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(189, 292);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += BtnExit_Click;
            // 
            // btnSearch
            // 
            btnBinSearch.Location = new Point(6, 26);
            btnBinSearch.Name = "btnSearch";
            btnBinSearch.Size = new Size(94, 29);
            btnBinSearch.TabIndex = 13;
            btnBinSearch.Text = "Binary";
            btnBinSearch.UseVisualStyleBackColor = true;
            btnBinSearch.Click += BtnBinSearch_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(188, 189);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Red;
            btnReset.ForeColor = SystemColors.Window;
            btnReset.Location = new Point(480, 393);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 16;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += BtnReset_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(380, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(480, 12);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(94, 29);
            btnOpen.TabIndex = 18;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += BtnOpen_Click;
            // 
            // grpSearch
            // 
            grpSearch.Controls.Add(btnSeqSearch);
            grpSearch.Controls.Add(btnBinSearch);
            grpSearch.Location = new Point(311, 225);
            grpSearch.Name = "grpSearch";
            grpSearch.Size = new Size(107, 96);
            grpSearch.TabIndex = 21;
            grpSearch.TabStop = false;
            grpSearch.Text = "Search";
            // 
            // button1
            // 
            btnSeqSearch.Location = new Point(6, 61);
            btnSeqSearch.Name = "button1";
            btnSeqSearch.Size = new Size(94, 29);
            btnSeqSearch.TabIndex = 22;
            btnSeqSearch.Text = "Linear";
            btnSeqSearch.UseVisualStyleBackColor = true;
            btnSeqSearch.Click += BtnSeqSearch_Click;

            openFileDialog1.DefaultExt = "txt";
            saveFileDialog1.DefaultExt = "txt";


            openFileDialog1.Filter = "Text Files (*.txt)| *.txt";
            saveFileDialog1.Filter = "Text Files (*.txt)| *.txt";
            // 
            // btnTag
            // 
            btnTag.Location = new Point(32, 362);
            btnTag.Name = "btnTag";
            btnTag.Size = new Size(94, 32);
            btnTag.TabIndex = 15;
            btnTag.Text = "Tag";
            btnTag.UseVisualStyleBackColor = true;
            btnTag.Click += BtnTag_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // LicencePlateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 451);
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
            Controls.Add(lblEdit);
            Controls.Add(untaggedLabel);
            Controls.Add(subtitle);
            Controls.Add(lblDay);
            Controls.Add(title);
            Name = "LicencePlateForm";
            Text = "Active Systems Pty.";
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
        private Label lblEdit;
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
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}

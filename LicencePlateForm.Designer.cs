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
            label5 = new Label();
            lblTagged = new Label();
            pictureBox1 = new PictureBox();
            lstUntagged = new ListBox();
            lstTagged = new ListBox();
            statusStrip1 = new StatusStrip();
            statusMsg = new ToolStripStatusLabel();
            txtInput = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnEdit = new Button();
            btnReset = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            rdoBinary = new RadioButton();
            rdoLinear = new RadioButton();
            grpSearchAlgorithm = new GroupBox();
            btnTag = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
            grpSearchAlgorithm.SuspendLayout();
            SuspendLayout();
            // 
            // btnTag
            // 
            btnTag.Location = new Point(27, 275);
            btnTag.Margin = new Padding(3, 2, 3, 2);
            btnTag.Name = "btnTag";
            btnTag.Size = new Size(82, 24);
            btnTag.TabIndex = 15;
            btnTag.Text = "Tag";
            btnTag.UseVisualStyleBackColor = true;
            btnTag.Click += BtnTag_Click;
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
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Location = new Point(370, 36);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(44, 15);
            lblDay.TabIndex = 1;
            lblDay.Text = "day {n}";
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
            // 
            // untaggedLabel
            // 
            untaggedLabel.AutoSize = true;
            untaggedLabel.Location = new Point(28, 79);
            untaggedLabel.Name = "untaggedLabel";
            untaggedLabel.Size = new Size(93, 15);
            untaggedLabel.TabIndex = 3;
            untaggedLabel.Text = "Untagged Plates";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(165, 99);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 4;
            label5.Text = "Edit ";
            // 
            // lblTagged
            // 
            lblTagged.AutoSize = true;
            lblTagged.Location = new Point(406, 79);
            lblTagged.Margin = new Padding(0, 2, 0, 2);
            lblTagged.Name = "lblTagged";
            lblTagged.Size = new Size(101, 15);
            lblTagged.TabIndex = 5;
            lblTagged.Text = "Tagged for review";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = LicencePlateManagement.Properties.Resources.Logo;
            pictureBox1.Location = new Point(226, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lstUntagged
            // 
            lstUntagged.FormattingEnabled = true;
            lstUntagged.Location = new Point(28, 99);
            lstUntagged.Margin = new Padding(3, 2, 3, 2);
            lstUntagged.Name = "lstUntagged";
            lstUntagged.SelectionMode = SelectionMode.MultiExtended;
            lstUntagged.Size = new Size(132, 169);
            lstUntagged.TabIndex = 7;
            lstUntagged.SelectedIndexChanged += SelectedIndexChanged;
            // 
            // lstTagged
            // 
            lstTagged.FormattingEnabled = true;
            lstTagged.Location = new Point(406, 99);
            lstTagged.Margin = new Padding(3, 2, 3, 2);
            lstTagged.Name = "lstTagged";
            lstTagged.SelectionMode = SelectionMode.MultiExtended;
            lstTagged.Size = new Size(132, 169);
            lstTagged.TabIndex = 8;
            lstTagged.SelectedIndexChanged += SelectedIndexChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusMsg });
            statusStrip1.Location = new Point(0, 316);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(550, 22);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
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
            txtInput.Size = new Size(237, 23);
            txtInput.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(165, 167);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += Add;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(165, 219);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(319, 142);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += BtnSearch_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(165, 141);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 22);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Red;
            btnReset.ForeColor = SystemColors.Window;
            btnReset.Location = new Point(458, 292);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(82, 22);
            btnReset.TabIndex = 16;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += BtnReset_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(370, 9);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(458, 9);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(82, 22);
            btnLoad.TabIndex = 18;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // rdoBinary
            // 
            rdoBinary.AutoSize = true;
            rdoBinary.Location = new Point(5, 20);
            rdoBinary.Margin = new Padding(3, 2, 3, 2);
            rdoBinary.Name = "rdoBinary";
            rdoBinary.Size = new Size(58, 19);
            rdoBinary.TabIndex = 19;
            rdoBinary.TabStop = true;
            rdoBinary.Text = "Binary";
            rdoBinary.UseVisualStyleBackColor = true;
            // 
            // rdoLinear
            // 
            rdoLinear.AutoSize = true;
            rdoLinear.Location = new Point(5, 42);
            rdoLinear.Margin = new Padding(3, 2, 3, 2);
            rdoLinear.Name = "rdoLinear";
            rdoLinear.Size = new Size(57, 19);
            rdoLinear.TabIndex = 20;
            rdoLinear.TabStop = true;
            rdoLinear.Text = "Linear";
            rdoLinear.UseVisualStyleBackColor = true;
            // 
            // grpSearchAlgorithm
            // 
            grpSearchAlgorithm.Controls.Add(rdoBinary);
            grpSearchAlgorithm.Controls.Add(rdoLinear);
            grpSearchAlgorithm.Location = new Point(252, 168);
            grpSearchAlgorithm.Margin = new Padding(3, 2, 3, 2);
            grpSearchAlgorithm.Name = "grpSearchAlgorithm";
            grpSearchAlgorithm.Padding = new Padding(3, 2, 3, 2);
            grpSearchAlgorithm.Size = new Size(149, 72);
            grpSearchAlgorithm.TabIndex = 21;
            grpSearchAlgorithm.TabStop = false;
            grpSearchAlgorithm.Text = "Search Algorithm";
            // 
            // LicencePlateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 338);
            Controls.Add(grpSearchAlgorithm);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnReset);
            Controls.Add(btnTag);
            Controls.Add(btnEdit);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(txtInput);
            Controls.Add(statusStrip1);
            Controls.Add(lstTagged);
            Controls.Add(lstUntagged);
            Controls.Add(pictureBox1);
            Controls.Add(lblTagged);
            Controls.Add(label5);
            Controls.Add(untaggedLabel);
            Controls.Add(subtitle);
            Controls.Add(lblDay);
            Controls.Add(title);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LicencePlateForm";
            Text = "Active Systems Pty.";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            grpSearchAlgorithm.ResumeLayout(false);
            grpSearchAlgorithm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label lblDay;
        private Label subtitle;
        private Label untaggedLabel;
        private Label label5;
        private Label lblTagged;
        private PictureBox pictureBox1;
        private ListBox lstUntagged;
        private ListBox lstTagged;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusMsg;
        private TextBox txtInput;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnEdit;
        private Button btnTag;
        private Button btnReset;
        private Button btnSave;
        private Button btnLoad;
        private RadioButton rdoBinary;
        private RadioButton rdoLinear;
        private GroupBox grpSearchAlgorithm;
    }
}

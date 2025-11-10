namespace LicencePlateManager
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
            Button btnTag;
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
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            textBox1 = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnEdit = new Button();
            btnReset = new Button();
            btnSave = new Button();
            button8 = new Button();
            rdoBinary = new RadioButton();
            rdoLinear = new RadioButton();
            groupBox1 = new GroupBox();
            btnTag = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTag
            // 
            btnTag.Location = new Point(31, 367);
            btnTag.Name = "btnTag";
            btnTag.Size = new Size(94, 29);
            btnTag.TabIndex = 15;
            btnTag.Text = "Tag";
            btnTag.UseVisualStyleBackColor = true;
            //btnTag.Click += btnTag_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 16F);
            title.Location = new Point(12, 9);
            title.Name = "title";
            title.Size = new Size(240, 37);
            title.TabIndex = 0;
            title.Text = "Active Systems Pty.";
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Location = new Point(423, 48);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(55, 20);
            lblDay.TabIndex = 1;
            lblDay.Text = "day {n}";
            // 
            // subtitle
            // 
            subtitle.AutoSize = true;
            subtitle.Font = new Font("Segoe UI", 10F);
            subtitle.Location = new Point(21, 46);
            subtitle.Name = "subtitle";
            subtitle.Size = new Size(216, 23);
            subtitle.TabIndex = 2;
            subtitle.Text = "Licence Plate Management";
            // 
            // untaggedLabel
            // 
            untaggedLabel.AutoSize = true;
            untaggedLabel.Location = new Point(31, 151);
            untaggedLabel.Name = "untaggedLabel";
            untaggedLabel.Size = new Size(118, 20);
            untaggedLabel.TabIndex = 3;
            untaggedLabel.Text = "Untagged Plates";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(187, 177);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 4;
            label5.Text = "Edit ";
            // 
            // lblTagged
            // 
            lblTagged.AutoSize = true;
            lblTagged.Location = new Point(463, 151);
            lblTagged.Margin = new Padding(0, 3, 0, 3);
            lblTagged.Name = "lblTagged";
            lblTagged.Size = new Size(128, 20);
            lblTagged.TabIndex = 5;
            lblTagged.Text = "Tagged for review";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = LicencePlateManagement.Properties.Resources.Logo;
            pictureBox1.Location = new Point(258, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lstUntagged
            // 
            lstUntagged.FormattingEnabled = true;
            lstUntagged.Location = new Point(31, 177);
            lstUntagged.Name = "lstUntagged";
            lstUntagged.Size = new Size(150, 184);
            lstUntagged.TabIndex = 7;
            // 
            // lstTagged
            // 
            lstTagged.FormattingEnabled = true;
            lstTagged.Location = new Point(463, 177);
            lstTagged.Name = "lstTagged";
            lstTagged.Size = new Size(150, 184);
            lstTagged.TabIndex = 8;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(629, 26);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(184, 20);
            toolStripStatusLabel1.Text = "Messages will appear here";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(187, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 27);
            textBox1.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(187, 268);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(187, 337);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(363, 235);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(187, 233);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Red;
            btnReset.ForeColor = SystemColors.Window;
            btnReset.Location = new Point(519, 392);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 16;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(423, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(523, 12);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 18;
            button8.Text = "Load";
            button8.UseVisualStyleBackColor = true;
            // 
            // rdoBinary
            // 
            rdoBinary.AutoSize = true;
            rdoBinary.Location = new Point(6, 26);
            rdoBinary.Name = "rdoBinary";
            rdoBinary.Size = new Size(71, 24);
            rdoBinary.TabIndex = 19;
            rdoBinary.TabStop = true;
            rdoBinary.Text = "Binary";
            rdoBinary.UseVisualStyleBackColor = true;
            // 
            // rdoLinear
            // 
            rdoLinear.AutoSize = true;
            rdoLinear.Location = new Point(6, 56);
            rdoLinear.Name = "rdoLinear";
            rdoLinear.Size = new Size(70, 24);
            rdoLinear.TabIndex = 20;
            rdoLinear.TabStop = true;
            rdoLinear.Text = "Linear";
            rdoLinear.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoBinary);
            groupBox1.Controls.Add(rdoLinear);
            groupBox1.Location = new Point(287, 270);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(170, 96);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Algorithm";
            // 
            // LicencePlateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 450);
            Controls.Add(groupBox1);
            Controls.Add(button8);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnReset);
            Controls.Add(btnTag);
            Controls.Add(btnEdit);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(textBox1);
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
            Name = "LicencePlateForm";
            Text = "Active Systems Pty.";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TextBox textBox1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnEdit;
        private Button btnTag;
        private Button btnReset;
        private Button btnSave;
        private Button button8;
        private RadioButton rdoBinary;
        private RadioButton rdoLinear;
        private GroupBox groupBox1;
    }
}

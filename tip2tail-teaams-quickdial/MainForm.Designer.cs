namespace tip2tail_teaams_quickdial
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            gbDetails = new GroupBox();
            btnCancel = new Button();
            btnSave = new Button();
            txtMail = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            lstNames = new ListBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            gbDetails.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbDetails
            // 
            gbDetails.Controls.Add(btnCancel);
            gbDetails.Controls.Add(btnSave);
            gbDetails.Controls.Add(txtMail);
            gbDetails.Controls.Add(label2);
            gbDetails.Controls.Add(txtName);
            gbDetails.Controls.Add(label1);
            gbDetails.Enabled = false;
            gbDetails.Location = new Point(210, 12);
            gbDetails.Name = "gbDetails";
            gbDetails.Size = new Size(216, 195);
            gbDetails.TabIndex = 13;
            gbDetails.TabStop = false;
            gbDetails.Text = "  Details  ";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(54, 166);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(135, 166);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(6, 81);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(204, 23);
            txtMail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "E-mail";
            // 
            // txtName
            // 
            txtName.Location = new Point(6, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(204, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // lstNames
            // 
            lstNames.AllowDrop = true;
            lstNames.FormattingEnabled = true;
            lstNames.ItemHeight = 15;
            lstNames.Location = new Point(12, 12);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(192, 319);
            lstNames.TabIndex = 12;
            lstNames.Click += lstNames_Click;
            lstNames.DragDrop += lstNames_DragDrop;
            lstNames.DragOver += lstNames_DragOver;
            lstNames.MouseDown += lstNames_MouseDown;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(210, 284);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(216, 76);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "  About  ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(135, 45);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 2;
            label5.Text = "2023-07-04";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 45);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 1;
            label4.Text = "Version 1.0.2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(194, 15);
            label3.TabIndex = 0;
            label3.Text = "Mark's Teams Lazy Quick Dial Tool";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(144, 337);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(60, 23);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(78, 337);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(60, 23);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 337);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(60, 23);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 372);
            Controls.Add(gbDetails);
            Controls.Add(lstNames);
            Controls.Add(groupBox1);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(454, 411);
            Name = "MainForm";
            Text = "Teams Quickdial";
            WindowState = FormWindowState.Minimized;
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            Shown += MainForm_Shown;
            gbDetails.ResumeLayout(false);
            gbDetails.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDetails;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtMail;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private ListBox lstNames;
        private GroupBox groupBox1;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
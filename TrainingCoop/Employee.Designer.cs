namespace TrainingCoop
{
    partial class Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bClose = new Button();
            bShow = new Button();
            bNew = new Button();
            Salary = new TextBox();
            label4 = new Label();
            label1 = new Label();
            fSex = new RadioButton();
            label2 = new Label();
            mSex = new RadioButton();
            employeeCode = new TextBox();
            label3 = new Label();
            employeeName = new TextBox();
            EmployeePosition = new ComboBox();
            noSex = new RadioButton();
            pictureBox1 = new PictureBox();
            bBrows = new Button();
            openFileDialog1 = new OpenFileDialog();
            bRemove = new Button();
            bEdit = new Button();
            bAdd = new Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label5 = new Label();
            dRow = new DataGridViewTextBoxColumn();
            dItemCode = new DataGridViewTextBoxColumn();
            dItemName = new DataGridViewTextBoxColumn();
            dSalary = new DataGridViewTextBoxColumn();
            dPosition = new DataGridViewTextBoxColumn();
            dSex = new DataGridViewTextBoxColumn();
            dPic = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bClose
            // 
            bClose.BackColor = SystemColors.ButtonFace;
            bClose.Location = new Point(547, 512);
            bClose.Name = "bClose";
            bClose.Size = new Size(75, 42);
            bClose.TabIndex = 14;
            bClose.Text = "Close";
            bClose.UseVisualStyleBackColor = false;
            bClose.Click += bClose_Click;
            // 
            // bShow
            // 
            bShow.BackColor = SystemColors.ButtonFace;
            bShow.Location = new Point(451, 512);
            bShow.Name = "bShow";
            bShow.Size = new Size(75, 42);
            bShow.TabIndex = 13;
            bShow.Text = "Show";
            bShow.UseVisualStyleBackColor = false;
            bShow.Click += bShow_Click;
            // 
            // bNew
            // 
            bNew.BackColor = SystemColors.ButtonFace;
            bNew.Location = new Point(357, 512);
            bNew.Name = "bNew";
            bNew.Size = new Size(75, 42);
            bNew.TabIndex = 12;
            bNew.Text = "New";
            bNew.UseVisualStyleBackColor = false;
            bNew.Click += bNew_Click;
            // 
            // Salary
            // 
            Salary.Location = new Point(112, 428);
            Salary.Name = "Salary";
            Salary.Size = new Size(171, 23);
            Salary.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 430);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 2;
            label4.Text = "เงินเดือน";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 293);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 0;
            label1.Text = "รหัสพนักงาน";
            // 
            // fSex
            // 
            fSex.AccessibleDescription = "";
            fSex.AutoSize = true;
            fSex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fSex.Location = new Point(166, 372);
            fSex.Name = "fSex";
            fSex.Size = new Size(56, 25);
            fSex.TabIndex = 9;
            fSex.TabStop = true;
            fSex.Text = "หญิง";
            fSex.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 317);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 1;
            label2.Text = "ชื่อพนักงาน";
            // 
            // mSex
            // 
            mSex.AutoSize = true;
            mSex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mSex.Location = new Point(166, 347);
            mSex.Name = "mSex";
            mSex.Size = new Size(53, 25);
            mSex.TabIndex = 8;
            mSex.TabStop = true;
            mSex.Text = "ชาย";
            mSex.UseVisualStyleBackColor = true;
            // 
            // employeeCode
            // 
            employeeCode.Location = new Point(112, 290);
            employeeCode.Name = "employeeCode";
            employeeCode.Size = new Size(171, 23);
            employeeCode.TabIndex = 5;
            employeeCode.KeyDown += employeeCode_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 471);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 4;
            label3.Text = "ตำแหน่ง";
            // 
            // employeeName
            // 
            employeeName.Location = new Point(112, 319);
            employeeName.Name = "employeeName";
            employeeName.Size = new Size(171, 23);
            employeeName.TabIndex = 6;
            employeeName.KeyDown += employeeName_KeyDown;
            // 
            // EmployeePosition
            // 
            EmployeePosition.FormattingEnabled = true;
            EmployeePosition.Items.AddRange(new object[] { "บัญชี", "ตลาด", "ขาย", "บุคคล", "IT" });
            EmployeePosition.Location = new Point(112, 471);
            EmployeePosition.Name = "EmployeePosition";
            EmployeePosition.Size = new Size(171, 23);
            EmployeePosition.TabIndex = 11;
            // 
            // noSex
            // 
            noSex.AccessibleDescription = "";
            noSex.AutoSize = true;
            noSex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            noSex.Location = new Point(166, 397);
            noSex.Name = "noSex";
            noSex.Size = new Size(64, 25);
            noSex.TabIndex = 10;
            noSex.TabStop = true;
            noSex.Text = "ไม่ระบุ";
            noSex.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(104, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // bBrows
            // 
            bBrows.Location = new Point(157, 233);
            bBrows.Name = "bBrows";
            bBrows.Size = new Size(75, 36);
            bBrows.TabIndex = 16;
            bBrows.Text = "BrowsPic";
            bBrows.UseVisualStyleBackColor = true;
            bBrows.Click += bBrows_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // bRemove
            // 
            bRemove.BackColor = Color.Lime;
            bRemove.Location = new Point(739, 46);
            bRemove.Name = "bRemove";
            bRemove.Size = new Size(75, 45);
            bRemove.TabIndex = 20;
            bRemove.Text = "Remove";
            bRemove.UseVisualStyleBackColor = false;
            bRemove.Click += bRemove_Click;
            // 
            // bEdit
            // 
            bEdit.BackColor = Color.Lime;
            bEdit.Location = new Point(643, 46);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(75, 45);
            bEdit.TabIndex = 19;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = false;
            bEdit.Click += bEdit_Click;
            // 
            // bAdd
            // 
            bAdd.BackColor = Color.Lime;
            bAdd.Location = new Point(549, 46);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(75, 45);
            bAdd.TabIndex = 18;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = false;
            bAdd.Click += bAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Lime;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dRow, dItemCode, dItemName, dSalary, dPosition, dSex, dPic });
            dataGridView1.Location = new Point(299, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(788, 371);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(113, 349);
            label5.Name = "label5";
            label5.Size = new Size(34, 21);
            label5.TabIndex = 22;
            label5.Text = "เพศ";
            // 
            // dRow
            // 
            dRow.HeaderText = "No.";
            dRow.Name = "dRow";
            dRow.ReadOnly = true;
            dRow.Width = 50;
            // 
            // dItemCode
            // 
            dItemCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dItemCode.HeaderText = "Code";
            dItemCode.Name = "dItemCode";
            dItemCode.ReadOnly = true;
            // 
            // dItemName
            // 
            dItemName.HeaderText = "Name";
            dItemName.Name = "dItemName";
            dItemName.ReadOnly = true;
            dItemName.Width = 150;
            // 
            // dSalary
            // 
            dSalary.HeaderText = "Salary";
            dSalary.Name = "dSalary";
            dSalary.ReadOnly = true;
            dSalary.Width = 150;
            // 
            // dPosition
            // 
            dPosition.HeaderText = "Position";
            dPosition.Name = "dPosition";
            dPosition.ReadOnly = true;
            dPosition.Width = 120;
            // 
            // dSex
            // 
            dSex.HeaderText = "Sex";
            dSex.Name = "dSex";
            dSex.ReadOnly = true;
            dSex.Width = 80;
            // 
            // dPic
            // 
            dPic.HeaderText = "Picture";
            dPic.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dPic.Name = "dPic";
            dPic.ReadOnly = true;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1110, 600);
            Controls.Add(fSex);
            Controls.Add(label5);
            Controls.Add(mSex);
            Controls.Add(noSex);
            Controls.Add(bRemove);
            Controls.Add(bEdit);
            Controls.Add(bAdd);
            Controls.Add(dataGridView1);
            Controls.Add(bBrows);
            Controls.Add(pictureBox1);
            Controls.Add(bClose);
            Controls.Add(bShow);
            Controls.Add(bNew);
            Controls.Add(Salary);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(employeeCode);
            Controls.Add(label3);
            Controls.Add(employeeName);
            Controls.Add(EmployeePosition);
            Name = "Employee";
            Text = "Employee";
            Load += Employee_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bClose;
        private Button bShow;
        private Button bNew;
        private TextBox Salary;
        private Label label4;
        private Label label1;
        private RadioButton fSex;
        private Label label2;
        private RadioButton mSex;
        private TextBox employeeCode;
        private Label label3;
        private TextBox employeeName;
        private ComboBox EmployeePosition;
        private RadioButton noSex;
        private PictureBox pictureBox1;
        private Button bBrows;
        private OpenFileDialog openFileDialog1;
        private Button bRemove;
        private Button bEdit;
        private Button bAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Label label5;
        private DataGridViewTextBoxColumn dRow;
        private DataGridViewTextBoxColumn dItemCode;
        private DataGridViewTextBoxColumn dItemName;
        private DataGridViewTextBoxColumn dSalary;
        private DataGridViewTextBoxColumn dPosition;
        private DataGridViewTextBoxColumn dSex;
        private DataGridViewImageColumn dPic;
    }
}
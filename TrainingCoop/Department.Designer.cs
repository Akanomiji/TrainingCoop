namespace TrainingCoop
{
    partial class Department
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
            departmentName = new TextBox();
            departmentCode = new TextBox();
            label2 = new Label();
            label1 = new Label();
            bRemove = new Button();
            bEdit = new Button();
            bAdd = new Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            dItemCode = new DataGridViewTextBoxColumn();
            dItemName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bClose
            // 
            bClose.BackColor = SystemColors.ButtonFace;
            bClose.Location = new Point(471, 536);
            bClose.Name = "bClose";
            bClose.Size = new Size(75, 44);
            bClose.TabIndex = 7;
            bClose.Text = "Close";
            bClose.UseVisualStyleBackColor = false;
            bClose.Click += bClose_Click;
            // 
            // bShow
            // 
            bShow.BackColor = SystemColors.ButtonFace;
            bShow.Location = new Point(375, 536);
            bShow.Name = "bShow";
            bShow.Size = new Size(75, 44);
            bShow.TabIndex = 6;
            bShow.Text = "Show";
            bShow.UseVisualStyleBackColor = false;
            bShow.Click += bShow_Click;
            // 
            // bNew
            // 
            bNew.BackColor = SystemColors.ButtonFace;
            bNew.Location = new Point(281, 536);
            bNew.Name = "bNew";
            bNew.Size = new Size(75, 44);
            bNew.TabIndex = 5;
            bNew.Text = "New";
            bNew.UseVisualStyleBackColor = false;
            bNew.Click += bNew_Click;
            // 
            // departmentName
            // 
            departmentName.Location = new Point(479, 118);
            departmentName.Name = "departmentName";
            departmentName.Size = new Size(171, 23);
            departmentName.TabIndex = 4;
            // 
            // departmentCode
            // 
            departmentCode.Location = new Point(191, 118);
            departmentCode.Name = "departmentCode";
            departmentCode.Size = new Size(171, 23);
            departmentCode.TabIndex = 3;
            departmentCode.KeyDown += departmentCode_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(385, 121);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 2;
            label2.Text = "ชื่อแผนก";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(97, 121);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 1;
            label1.Text = "รหัสแผนก";
            // 
            // bRemove
            // 
            bRemove.BackColor = Color.Lime;
            bRemove.Location = new Point(471, 201);
            bRemove.Name = "bRemove";
            bRemove.Size = new Size(75, 45);
            bRemove.TabIndex = 13;
            bRemove.Text = "Remove";
            bRemove.UseVisualStyleBackColor = false;
            bRemove.Click += bRemove_Click;
            // 
            // bEdit
            // 
            bEdit.BackColor = Color.Lime;
            bEdit.Location = new Point(375, 201);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(75, 45);
            bEdit.TabIndex = 12;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = false;
            bEdit.Click += bEdit_Click;
            // 
            // bAdd
            // 
            bAdd.BackColor = Color.Lime;
            bAdd.Location = new Point(281, 201);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(75, 45);
            bAdd.TabIndex = 11;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dItemCode, dItemName });
            dataGridView1.Location = new Point(191, 298);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(443, 183);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dItemCode
            // 
            dItemCode.HeaderText = "Code";
            dItemCode.Name = "dItemCode";
            dItemCode.ReadOnly = true;
            dItemCode.Width = 200;
            // 
            // dItemName
            // 
            dItemName.HeaderText = "Name";
            dItemName.Name = "dItemName";
            dItemName.ReadOnly = true;
            dItemName.Width = 200;
            // 
            // Department
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 616);
            Controls.Add(dataGridView1);
            Controls.Add(bRemove);
            Controls.Add(bEdit);
            Controls.Add(bAdd);
            Controls.Add(bClose);
            Controls.Add(bShow);
            Controls.Add(bNew);
            Controls.Add(departmentName);
            Controls.Add(departmentCode);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Department";
            Text = "Department";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bClose;
        private Button bShow;
        private Button bNew;
        private TextBox departmentName;
        private TextBox departmentCode;
        private Label label2;
        private Label label1;
        private Button bRemove;
        private Button bEdit;
        private Button bAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dItemCode;
        private DataGridViewTextBoxColumn dItemName;
    }
}
namespace TrainingCoop
{
    partial class Customer
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
            customerName = new TextBox();
            customerCode = new TextBox();
            label2 = new Label();
            label1 = new Label();
            County = new ComboBox();
            label3 = new Label();
            bRemove = new Button();
            bEdit = new Button();
            bAdd = new Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            dRow = new DataGridViewTextBoxColumn();
            dItemCode = new DataGridViewTextBoxColumn();
            dItemName = new DataGridViewTextBoxColumn();
            dCounty = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bClose
            // 
            bClose.BackColor = Color.WhiteSmoke;
            bClose.Location = new Point(482, 550);
            bClose.Name = "bClose";
            bClose.Size = new Size(75, 39);
            bClose.TabIndex = 8;
            bClose.Text = "Close";
            bClose.UseVisualStyleBackColor = false;
            bClose.Click += bClose_Click;
            // 
            // bShow
            // 
            bShow.BackColor = Color.WhiteSmoke;
            bShow.Location = new Point(386, 550);
            bShow.Name = "bShow";
            bShow.Size = new Size(75, 39);
            bShow.TabIndex = 7;
            bShow.Text = "Show";
            bShow.UseVisualStyleBackColor = false;
            bShow.Click += bShow_Click;
            // 
            // bNew
            // 
            bNew.BackColor = Color.WhiteSmoke;
            bNew.Location = new Point(292, 550);
            bNew.Name = "bNew";
            bNew.Size = new Size(75, 39);
            bNew.TabIndex = 6;
            bNew.Text = "New";
            bNew.UseVisualStyleBackColor = false;
            bNew.Click += bNew_Click;
            // 
            // customerName
            // 
            customerName.Location = new Point(352, 133);
            customerName.Name = "customerName";
            customerName.Size = new Size(171, 23);
            customerName.TabIndex = 4;
            // 
            // customerCode
            // 
            customerCode.Location = new Point(352, 86);
            customerCode.Name = "customerCode";
            customerCode.Size = new Size(171, 23);
            customerCode.TabIndex = 3;
            customerCode.KeyDown += customerCode_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(258, 136);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 1;
            label2.Text = "ชื่อลูกค้า";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(258, 89);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 0;
            label1.Text = "รหัสลูกค้า";
            // 
            // County
            // 
            County.FormattingEnabled = true;
            County.Items.AddRange(new object[] { "เชียงราย", "พะเยา", "แพร่", "น่าน", "ลำปาง", "เชียงใหม่", "ลำพูน", "แม่ฮ่องสอน" });
            County.Location = new Point(352, 179);
            County.Name = "County";
            County.Size = new Size(171, 23);
            County.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(258, 182);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 2;
            label3.Text = "จังหวัด";
            // 
            // bRemove
            // 
            bRemove.BackColor = Color.Lime;
            bRemove.Location = new Point(448, 251);
            bRemove.Name = "bRemove";
            bRemove.Size = new Size(75, 45);
            bRemove.TabIndex = 14;
            bRemove.Text = "Remove";
            bRemove.UseVisualStyleBackColor = false;
            // 
            // bEdit
            // 
            bEdit.BackColor = Color.Lime;
            bEdit.Location = new Point(352, 251);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(75, 45);
            bEdit.TabIndex = 13;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = false;
            bEdit.Click += bEdit_Click;
            // 
            // bAdd
            // 
            bAdd.BackColor = Color.Lime;
            bAdd.Location = new Point(258, 251);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(75, 45);
            bAdd.TabIndex = 12;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dRow, dItemCode, dItemName, dCounty });
            dataGridView1.Location = new Point(157, 332);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(484, 183);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
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
            dItemCode.HeaderText = "Code";
            dItemCode.Name = "dItemCode";
            dItemCode.ReadOnly = true;
            dItemCode.Width = 130;
            // 
            // dItemName
            // 
            dItemName.HeaderText = "Name";
            dItemName.Name = "dItemName";
            dItemName.ReadOnly = true;
            dItemName.Width = 130;
            // 
            // dCounty
            // 
            dCounty.HeaderText = "County";
            dCounty.Name = "dCounty";
            dCounty.ReadOnly = true;
            dCounty.Width = 130;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 601);
            Controls.Add(bRemove);
            Controls.Add(bEdit);
            Controls.Add(bAdd);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(County);
            Controls.Add(bClose);
            Controls.Add(bShow);
            Controls.Add(bNew);
            Controls.Add(customerName);
            Controls.Add(customerCode);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Customer";
            Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bClose;
        private Button bShow;
        private Button bNew;
        private TextBox customerName;
        private TextBox customerCode;
        private Label label2;
        private Label label1;
        private ComboBox County;
        private Label label3;
        private Button bRemove;
        private Button bEdit;
        private Button bAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dRow;
        private DataGridViewTextBoxColumn dItemCode;
        private DataGridViewTextBoxColumn dItemName;
        private DataGridViewTextBoxColumn dCounty;
    }
}
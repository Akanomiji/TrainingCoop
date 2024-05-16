namespace TrainingCoop
{
    partial class ItemType
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            typeCode = new TextBox();
            typeName = new TextBox();
            bNew = new Button();
            bShow = new Button();
            bClose = new Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            dRow = new DataGridViewTextBoxColumn();
            dItemCode = new DataGridViewTextBoxColumn();
            dItemName = new DataGridViewTextBoxColumn();
            bRemove = new Button();
            bEdit = new Button();
            bAdd = new Button();
            bShowC = new Button();
            bSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(63, 110);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 0;
            label1.Text = "รหัสประเภทสินค้า";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(383, 110);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 1;
            label2.Text = "ชื่อประเภทสินค้า";
            // 
            // typeCode
            // 
            typeCode.Location = new Point(183, 108);
            typeCode.Name = "typeCode";
            typeCode.Size = new Size(171, 23);
            typeCode.TabIndex = 2;
            typeCode.KeyDown += typeCode_KeyDown;
            // 
            // typeName
            // 
            typeName.Location = new Point(496, 108);
            typeName.Name = "typeName";
            typeName.Size = new Size(171, 23);
            typeName.TabIndex = 3;
            // 
            // bNew
            // 
            bNew.BackColor = SystemColors.ButtonFace;
            bNew.Location = new Point(269, 504);
            bNew.Name = "bNew";
            bNew.Size = new Size(75, 45);
            bNew.TabIndex = 4;
            bNew.Text = "New";
            bNew.UseVisualStyleBackColor = false;
            bNew.Click += bNew_Click;
            // 
            // bShow
            // 
            bShow.BackColor = SystemColors.ButtonFace;
            bShow.Location = new Point(363, 504);
            bShow.Name = "bShow";
            bShow.Size = new Size(75, 45);
            bShow.TabIndex = 5;
            bShow.Text = "Show";
            bShow.UseVisualStyleBackColor = false;
            bShow.Click += bShow_Click;
            // 
            // bClose
            // 
            bClose.BackColor = SystemColors.ButtonFace;
            bClose.Location = new Point(459, 504);
            bClose.Name = "bClose";
            bClose.Size = new Size(75, 45);
            bClose.TabIndex = 6;
            bClose.Text = "Close";
            bClose.UseVisualStyleBackColor = false;
            bClose.Click += bClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Lime;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dRow, dItemCode, dItemName });
            dataGridView1.Location = new Point(121, 291);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(493, 183);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            dItemCode.Width = 200;
            // 
            // dItemName
            // 
            dItemName.HeaderText = "Name";
            dItemName.Name = "dItemName";
            dItemName.ReadOnly = true;
            dItemName.Width = 200;
            // 
            // bRemove
            // 
            bRemove.BackColor = Color.Lime;
            bRemove.Location = new Point(440, 204);
            bRemove.Name = "bRemove";
            bRemove.Size = new Size(75, 45);
            bRemove.TabIndex = 10;
            bRemove.Text = "Remove";
            bRemove.UseVisualStyleBackColor = false;
            bRemove.Click += bRemove_Click;
            // 
            // bEdit
            // 
            bEdit.BackColor = Color.Lime;
            bEdit.Location = new Point(344, 204);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(75, 45);
            bEdit.TabIndex = 9;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = false;
            bEdit.Click += bEdit_Click;
            // 
            // bAdd
            // 
            bAdd.BackColor = Color.Lime;
            bAdd.Location = new Point(250, 204);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(75, 45);
            bAdd.TabIndex = 8;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = false;
            bAdd.Click += bAdd_Click;
            // 
            // bShowC
            // 
            bShowC.Location = new Point(556, 204);
            bShowC.Name = "bShowC";
            bShowC.Size = new Size(75, 45);
            bShowC.TabIndex = 11;
            bShowC.Text = "ShowCode";
            bShowC.UseVisualStyleBackColor = true;
            bShowC.Click += bShowC_Click;
            // 
            // bSearch
            // 
            bSearch.Location = new Point(556, 152);
            bSearch.Name = "bSearch";
            bSearch.Size = new Size(75, 36);
            bSearch.TabIndex = 12;
            bSearch.Text = "Search";
            bSearch.UseVisualStyleBackColor = true;
            bSearch.Click += bSearch_Click;
            // 
            // ItemType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(770, 623);
            Controls.Add(bSearch);
            Controls.Add(bShowC);
            Controls.Add(bRemove);
            Controls.Add(bEdit);
            Controls.Add(bAdd);
            Controls.Add(dataGridView1);
            Controls.Add(bClose);
            Controls.Add(bShow);
            Controls.Add(bNew);
            Controls.Add(typeName);
            Controls.Add(typeCode);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ItemType";
            Text = "ItemType";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox typeCode;
        private TextBox typeName;
        private Button bNew;
        private Button bShow;
        private Button bClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Button bRemove;
        private Button bEdit;
        private Button bAdd;
        private Button bShowC;
        private DataGridViewTextBoxColumn dRow;
        private DataGridViewTextBoxColumn dItemCode;
        private DataGridViewTextBoxColumn dItemName;
        private Button bSearch;
    }
}
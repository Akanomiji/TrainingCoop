namespace TrainingCoop
{
    partial class Item
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
            label1 = new Label();
            label2 = new Label();
            itemCode = new TextBox();
            itemName = new TextBox();
            typeName = new ComboBox();
            label3 = new Label();
            Vat = new RadioButton();
            noVat = new RadioButton();
            label4 = new Label();
            price = new TextBox();
            label5 = new Label();
            qty = new TextBox();
            label6 = new Label();
            amount = new TextBox();
            label7 = new Label();
            bRemove = new Button();
            bEdit = new Button();
            bAdd = new Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            dRow = new DataGridViewTextBoxColumn();
            dItemCode = new DataGridViewTextBoxColumn();
            dItemName = new DataGridViewTextBoxColumn();
            dType = new DataGridViewTextBoxColumn();
            dPrice = new DataGridViewTextBoxColumn();
            dVat = new DataGridViewTextBoxColumn();
            dQty = new DataGridViewTextBoxColumn();
            dAmount = new DataGridViewTextBoxColumn();
            label8 = new Label();
            tTotalAmount = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bClose
            // 
            bClose.BackColor = SystemColors.ButtonFace;
            bClose.Location = new Point(573, 605);
            bClose.Margin = new Padding(4);
            bClose.Name = "bClose";
            bClose.Size = new Size(96, 59);
            bClose.TabIndex = 15;
            bClose.Text = "Close";
            bClose.UseVisualStyleBackColor = false;
            bClose.Click += bClose_Click;
            // 
            // bShow
            // 
            bShow.BackColor = SystemColors.ButtonFace;
            bShow.Location = new Point(450, 605);
            bShow.Margin = new Padding(4);
            bShow.Name = "bShow";
            bShow.Size = new Size(96, 59);
            bShow.TabIndex = 14;
            bShow.Text = "Show";
            bShow.UseVisualStyleBackColor = false;
            bShow.Click += bShow_Click;
            // 
            // bNew
            // 
            bNew.BackColor = SystemColors.ButtonFace;
            bNew.Location = new Point(329, 605);
            bNew.Margin = new Padding(4);
            bNew.Name = "bNew";
            bNew.Size = new Size(96, 59);
            bNew.TabIndex = 13;
            bNew.Text = "New";
            bNew.UseVisualStyleBackColor = false;
            bNew.Click += bNew_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(100, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 0;
            label1.Text = "รหัสสินค้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(468, 46);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 1;
            label2.Text = "ชื่อสินค้า";
            // 
            // itemCode
            // 
            itemCode.Location = new Point(221, 37);
            itemCode.Margin = new Padding(4);
            itemCode.Name = "itemCode";
            itemCode.Size = new Size(219, 29);
            itemCode.TabIndex = 5;
            itemCode.KeyDown += itemCode_KeyDown;
            // 
            // itemName
            // 
            itemName.Location = new Point(589, 42);
            itemName.Margin = new Padding(4);
            itemName.Name = "itemName";
            itemName.Size = new Size(219, 29);
            itemName.TabIndex = 6;
            itemName.KeyDown += itemName_KeyDown;
            // 
            // typeName
            // 
            typeName.FormattingEnabled = true;
            typeName.Items.AddRange(new object[] { "เครื่องใช้ไฟฟ้า", "อุปกรณ์คอมพิวเตอร์", "อุปกรณ์สำนักงาน", "อุปโภค-บริโภค" });
            typeName.Location = new Point(221, 99);
            typeName.Margin = new Padding(4);
            typeName.Name = "typeName";
            typeName.Size = new Size(219, 29);
            typeName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(100, 103);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 1;
            label3.Text = "ประเภทสินค้า";
            // 
            // Vat
            // 
            Vat.AutoSize = true;
            Vat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Vat.Location = new Point(595, 93);
            Vat.Margin = new Padding(4);
            Vat.Name = "Vat";
            Vat.Size = new Size(72, 25);
            Vat.TabIndex = 8;
            Vat.TabStop = true;
            Vat.Text = "คิด Vat";
            Vat.UseVisualStyleBackColor = true;
            Vat.CheckedChanged += Vat_CheckedChanged;
            // 
            // noVat
            // 
            noVat.AccessibleDescription = "";
            noVat.AutoSize = true;
            noVat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            noVat.Location = new Point(595, 128);
            noVat.Margin = new Padding(4);
            noVat.Name = "noVat";
            noVat.Size = new Size(87, 25);
            noVat.TabIndex = 9;
            noVat.TabStop = true;
            noVat.Text = "ไม่คิด Vat";
            noVat.UseVisualStyleBackColor = true;
            noVat.CheckedChanged += noVat_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(100, 175);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 21);
            label4.TabIndex = 2;
            label4.Text = "ราคา";
            // 
            // price
            // 
            price.Location = new Point(221, 170);
            price.Margin = new Padding(4);
            price.Name = "price";
            price.Size = new Size(219, 29);
            price.TabIndex = 10;
            price.KeyDown += price_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(474, 175);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 3;
            label5.Text = "จำนวน";
            // 
            // qty
            // 
            qty.Location = new Point(595, 170);
            qty.Margin = new Padding(4);
            qty.Name = "qty";
            qty.Size = new Size(219, 29);
            qty.TabIndex = 11;
            qty.KeyDown += qty_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(329, 226);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 21);
            label6.TabIndex = 4;
            label6.Text = "เป็นเงิน";
            // 
            // amount
            // 
            amount.Location = new Point(450, 221);
            amount.Margin = new Padding(4);
            amount.Name = "amount";
            amount.Size = new Size(219, 29);
            amount.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(474, 99);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(32, 21);
            label7.TabIndex = 16;
            label7.Text = "Vat";
            // 
            // bRemove
            // 
            bRemove.BackColor = Color.Lime;
            bRemove.Enabled = false;
            bRemove.Location = new Point(530, 271);
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
            bEdit.Enabled = false;
            bEdit.Location = new Point(434, 271);
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
            bAdd.Location = new Point(340, 271);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dRow, dItemCode, dItemName, dType, dPrice, dVat, dQty, dAmount });
            dataGridView1.Location = new Point(100, 332);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(824, 183);
            dataGridView1.TabIndex = 17;
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
            // 
            // dItemName
            // 
            dItemName.HeaderText = "Name";
            dItemName.Name = "dItemName";
            dItemName.ReadOnly = true;
            dItemName.Width = 150;
            // 
            // dType
            // 
            dType.HeaderText = "Type";
            dType.Name = "dType";
            dType.ReadOnly = true;
            // 
            // dPrice
            // 
            dPrice.HeaderText = "Price";
            dPrice.Name = "dPrice";
            dPrice.ReadOnly = true;
            // 
            // dVat
            // 
            dVat.HeaderText = "Vat";
            dVat.Name = "dVat";
            dVat.ReadOnly = true;
            dVat.Width = 80;
            // 
            // dQty
            // 
            dQty.HeaderText = "Qty";
            dQty.Name = "dQty";
            dQty.ReadOnly = true;
            // 
            // dAmount
            // 
            dAmount.HeaderText = "Amount";
            dAmount.Name = "dAmount";
            dAmount.ReadOnly = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(604, 540);
            label8.Name = "label8";
            label8.Size = new Size(102, 21);
            label8.TabIndex = 21;
            label8.Text = "Total Amount";
            // 
            // tTotalAmount
            // 
            tTotalAmount.Location = new Point(712, 532);
            tTotalAmount.Name = "tTotalAmount";
            tTotalAmount.Size = new Size(162, 29);
            tTotalAmount.TabIndex = 22;
            tTotalAmount.Text = "0";
            tTotalAmount.TextAlign = HorizontalAlignment.Right;
            tTotalAmount.TextChanged += tTotalAmount_TextChanged;
            // 
            // Item
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1029, 687);
            Controls.Add(tTotalAmount);
            Controls.Add(label8);
            Controls.Add(bRemove);
            Controls.Add(bEdit);
            Controls.Add(bAdd);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(amount);
            Controls.Add(label6);
            Controls.Add(bClose);
            Controls.Add(qty);
            Controls.Add(bShow);
            Controls.Add(label5);
            Controls.Add(bNew);
            Controls.Add(price);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(noVat);
            Controls.Add(label2);
            Controls.Add(Vat);
            Controls.Add(itemCode);
            Controls.Add(label3);
            Controls.Add(itemName);
            Controls.Add(typeName);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Item";
            Text = "Item";
            Load += Item_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bClose;
        private Button bShow;
        private Button bNew;
        private Label label1;
        private Label label2;
        private TextBox itemCode;
        private TextBox itemName;
        private ComboBox typeName;
        private Label label3;
        private RadioButton Vat;
        private RadioButton noVat;
        private Label label4;
        private TextBox price;
        private Label label5;
        private TextBox qty;
        private Label label6;
        private TextBox amount;
        private Label label7;
        private Button bRemove;
        private Button bEdit;
        private Button bAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Label label8;
        private TextBox tTotalAmount;
        private DataGridViewTextBoxColumn dRow;
        private DataGridViewTextBoxColumn dItemCode;
        private DataGridViewTextBoxColumn dItemName;
        private DataGridViewTextBoxColumn dType;
        private DataGridViewTextBoxColumn dPrice;
        private DataGridViewTextBoxColumn dVat;
        private DataGridViewTextBoxColumn dQty;
        private DataGridViewTextBoxColumn dAmount;
    }
}
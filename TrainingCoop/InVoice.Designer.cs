namespace TrainingCoop
{
    partial class InVoice
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
            label1 = new Label();
            tNumber = new TextBox();
            label2 = new Label();
            tCodeCustomer = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            gCustomer = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            tProvinceCustomer = new TextBox();
            tNameCustomer = new TextBox();
            label3 = new Label();
            gItem = new GroupBox();
            tAmountItem = new TextBox();
            label11 = new Label();
            tQtyItem = new TextBox();
            label10 = new Label();
            tPriceItem = new TextBox();
            label9 = new Label();
            tTypeItem = new TextBox();
            label8 = new Label();
            tNameItem = new TextBox();
            label7 = new Label();
            tCodeItem = new TextBox();
            label6 = new Label();
            bAdd = new Button();
            bEdit = new Button();
            bRemove = new Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Number = new DataGridViewTextBoxColumn();
            cCode = new DataGridViewTextBoxColumn();
            cName = new DataGridViewTextBoxColumn();
            cType = new DataGridViewTextBoxColumn();
            cPrice = new DataGridViewTextBoxColumn();
            cQty = new DataGridViewTextBoxColumn();
            cAmount = new DataGridViewTextBoxColumn();
            gEmployee = new GroupBox();
            tEmployeeName = new TextBox();
            label13 = new Label();
            tEmployeeCode = new TextBox();
            label12 = new Label();
            tTotalAmount = new TextBox();
            label14 = new Label();
            tVat = new TextBox();
            label15 = new Label();
            tTotal = new TextBox();
            label16 = new Label();
            gTAmount = new GroupBox();
            bNew = new Button();
            bShow = new Button();
            bClose = new Button();
            gCustomer.SuspendLayout();
            gItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gEmployee.SuspendLayout();
            gTAmount.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(284, 39);
            label1.Name = "label1";
            label1.Size = new Size(25, 16);
            label1.TabIndex = 0;
            label1.Text = "No";
            // 
            // tNumber
            // 
            tNumber.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tNumber.Location = new Point(324, 36);
            tNumber.Name = "tNumber";
            tNumber.Size = new Size(100, 22);
            tNumber.TabIndex = 1;
            tNumber.KeyDown += tNumber_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(507, 44);
            label2.Name = "label2";
            label2.Size = new Size(36, 16);
            label2.TabIndex = 2;
            label2.Text = "Date";
            // 
            // tCodeCustomer
            // 
            tCodeCustomer.Location = new Point(92, 49);
            tCodeCustomer.Name = "tCodeCustomer";
            tCodeCustomer.Size = new Size(100, 22);
            tCodeCustomer.TabIndex = 3;
            tCodeCustomer.KeyDown += tCodeCustomer_KeyDown;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(564, 36);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 22);
            dateTimePicker1.TabIndex = 4;
            // 
            // gCustomer
            // 
            gCustomer.Controls.Add(label5);
            gCustomer.Controls.Add(label4);
            gCustomer.Controls.Add(tProvinceCustomer);
            gCustomer.Controls.Add(tNameCustomer);
            gCustomer.Controls.Add(label3);
            gCustomer.Controls.Add(tCodeCustomer);
            gCustomer.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            gCustomer.Location = new Point(111, 73);
            gCustomer.Name = "gCustomer";
            gCustomer.Size = new Size(848, 100);
            gCustomer.TabIndex = 5;
            gCustomer.TabStop = false;
            gCustomer.Text = "Customer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(533, 51);
            label5.Name = "label5";
            label5.Size = new Size(60, 16);
            label5.TabIndex = 9;
            label5.Text = "Province";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 51);
            label4.Name = "label4";
            label4.Size = new Size(44, 16);
            label4.TabIndex = 9;
            label4.Text = "Name";
            // 
            // tProvinceCustomer
            // 
            tProvinceCustomer.Location = new Point(609, 48);
            tProvinceCustomer.Name = "tProvinceCustomer";
            tProvinceCustomer.Size = new Size(197, 22);
            tProvinceCustomer.TabIndex = 8;
            tProvinceCustomer.KeyDown += tProvinceCustomer_KeyDown;
            // 
            // tNameCustomer
            // 
            tNameCustomer.Location = new Point(275, 49);
            tNameCustomer.Name = "tNameCustomer";
            tNameCustomer.Size = new Size(239, 22);
            tNameCustomer.TabIndex = 8;
            tNameCustomer.KeyDown += tNameCustomer_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 51);
            label3.Name = "label3";
            label3.Size = new Size(40, 16);
            label3.TabIndex = 7;
            label3.Text = "Code";
            // 
            // gItem
            // 
            gItem.Controls.Add(tAmountItem);
            gItem.Controls.Add(label11);
            gItem.Controls.Add(tQtyItem);
            gItem.Controls.Add(label10);
            gItem.Controls.Add(tPriceItem);
            gItem.Controls.Add(label9);
            gItem.Controls.Add(tTypeItem);
            gItem.Controls.Add(label8);
            gItem.Controls.Add(tNameItem);
            gItem.Controls.Add(label7);
            gItem.Controls.Add(tCodeItem);
            gItem.Controls.Add(label6);
            gItem.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            gItem.Location = new Point(111, 189);
            gItem.Name = "gItem";
            gItem.Size = new Size(848, 151);
            gItem.TabIndex = 6;
            gItem.TabStop = false;
            gItem.Text = "Item";
            // 
            // tAmountItem
            // 
            tAmountItem.Enabled = false;
            tAmountItem.Location = new Point(484, 103);
            tAmountItem.Name = "tAmountItem";
            tAmountItem.Size = new Size(100, 22);
            tAmountItem.TabIndex = 18;
            tAmountItem.Text = "0";
            tAmountItem.TextAlign = HorizontalAlignment.Right;
            tAmountItem.KeyDown += tAmountItem_KeyDown;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(412, 111);
            label11.Name = "label11";
            label11.Size = new Size(52, 16);
            label11.TabIndex = 17;
            label11.Text = "Amount";
            // 
            // tQtyItem
            // 
            tQtyItem.Location = new Point(275, 103);
            tQtyItem.Name = "tQtyItem";
            tQtyItem.Size = new Size(100, 22);
            tQtyItem.TabIndex = 16;
            tQtyItem.KeyDown += tQtyItem_KeyDown;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(223, 111);
            label10.Name = "label10";
            label10.Size = new Size(27, 16);
            label10.TabIndex = 15;
            label10.Text = "Qty";
            // 
            // tPriceItem
            // 
            tPriceItem.Location = new Point(78, 103);
            tPriceItem.Name = "tPriceItem";
            tPriceItem.Size = new Size(100, 22);
            tPriceItem.TabIndex = 14;
            tPriceItem.KeyDown += tPriceItem_KeyDown;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 111);
            label9.Name = "label9";
            label9.Size = new Size(38, 16);
            label9.TabIndex = 13;
            label9.Text = "Price";
            // 
            // tTypeItem
            // 
            tTypeItem.Location = new Point(609, 39);
            tTypeItem.Name = "tTypeItem";
            tTypeItem.Size = new Size(197, 22);
            tTypeItem.TabIndex = 12;
            tTypeItem.KeyDown += tTypeItem_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(557, 47);
            label8.Name = "label8";
            label8.Size = new Size(39, 16);
            label8.TabIndex = 11;
            label8.Text = "Type";
            // 
            // tNameItem
            // 
            tNameItem.Location = new Point(275, 39);
            tNameItem.Name = "tNameItem";
            tNameItem.Size = new Size(239, 22);
            tNameItem.TabIndex = 10;
            tNameItem.KeyDown += tNameItem_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(223, 47);
            label7.Name = "label7";
            label7.Size = new Size(44, 16);
            label7.TabIndex = 9;
            label7.Text = "Name";
            // 
            // tCodeItem
            // 
            tCodeItem.Location = new Point(78, 39);
            tCodeItem.Name = "tCodeItem";
            tCodeItem.Size = new Size(100, 22);
            tCodeItem.TabIndex = 8;
            tCodeItem.KeyDown += tCodeItem_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 47);
            label6.Name = "label6";
            label6.Size = new Size(40, 16);
            label6.TabIndex = 7;
            label6.Text = "Code";
            // 
            // bAdd
            // 
            bAdd.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bAdd.Location = new Point(374, 346);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(75, 37);
            bAdd.TabIndex = 7;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // bEdit
            // 
            bEdit.Enabled = false;
            bEdit.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bEdit.Location = new Point(468, 346);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(75, 37);
            bEdit.TabIndex = 8;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = true;
            bEdit.Click += bEdit_Click;
            // 
            // bRemove
            // 
            bRemove.Enabled = false;
            bRemove.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bRemove.Location = new Point(562, 346);
            bRemove.Name = "bRemove";
            bRemove.Size = new Size(75, 37);
            bRemove.TabIndex = 9;
            bRemove.Text = "Remove";
            bRemove.UseVisualStyleBackColor = true;
            bRemove.Click += bRemove_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Number, cCode, cName, cType, cPrice, cQty, cAmount });
            dataGridView1.Location = new Point(65, 389);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(969, 150);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Number
            // 
            Number.HeaderText = "No.";
            Number.Name = "Number";
            Number.Width = 40;
            // 
            // cCode
            // 
            cCode.HeaderText = "Code";
            cCode.Name = "cCode";
            // 
            // cName
            // 
            cName.HeaderText = "Name";
            cName.Name = "cName";
            cName.Width = 150;
            // 
            // cType
            // 
            cType.HeaderText = "Type";
            cType.Name = "cType";
            // 
            // cPrice
            // 
            cPrice.HeaderText = "Price";
            cPrice.Name = "cPrice";
            // 
            // cQty
            // 
            cQty.HeaderText = "Qty";
            cQty.Name = "cQty";
            // 
            // cAmount
            // 
            cAmount.HeaderText = "Amount";
            cAmount.Name = "cAmount";
            // 
            // gEmployee
            // 
            gEmployee.Controls.Add(tEmployeeName);
            gEmployee.Controls.Add(label13);
            gEmployee.Controls.Add(tEmployeeCode);
            gEmployee.Controls.Add(label12);
            gEmployee.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            gEmployee.Location = new Point(111, 554);
            gEmployee.Name = "gEmployee";
            gEmployee.Size = new Size(464, 85);
            gEmployee.TabIndex = 11;
            gEmployee.TabStop = false;
            gEmployee.Text = "Employee";
            // 
            // tEmployeeName
            // 
            tEmployeeName.Location = new Point(204, 34);
            tEmployeeName.Name = "tEmployeeName";
            tEmployeeName.Size = new Size(212, 25);
            tEmployeeName.TabIndex = 22;
            tEmployeeName.KeyDown += tEmployeeName_KeyDown;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(155, 37);
            label13.Name = "label13";
            label13.Size = new Size(43, 17);
            label13.TabIndex = 21;
            label13.Text = "Name";
            // 
            // tEmployeeCode
            // 
            tEmployeeCode.Location = new Point(40, 34);
            tEmployeeCode.Name = "tEmployeeCode";
            tEmployeeCode.Size = new Size(100, 25);
            tEmployeeCode.TabIndex = 20;
            tEmployeeCode.KeyDown += tEmployeeCode_KeyDown;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 37);
            label12.Name = "label12";
            label12.Size = new Size(39, 17);
            label12.TabIndex = 19;
            label12.Text = "Code";
            // 
            // tTotalAmount
            // 
            tTotalAmount.Enabled = false;
            tTotalAmount.Location = new Point(93, 31);
            tTotalAmount.Name = "tTotalAmount";
            tTotalAmount.Size = new Size(100, 23);
            tTotalAmount.TabIndex = 24;
            tTotalAmount.Text = "0";
            tTotalAmount.TextAlign = HorizontalAlignment.Right;
            tTotalAmount.KeyDown += tTotalAmount_KeyDown;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(8, 39);
            label14.Name = "label14";
            label14.Size = new Size(79, 15);
            label14.TabIndex = 23;
            label14.Text = "Total Amount";
            // 
            // tVat
            // 
            tVat.Enabled = false;
            tVat.Location = new Point(93, 60);
            tVat.Name = "tVat";
            tVat.Size = new Size(100, 23);
            tVat.TabIndex = 26;
            tVat.Text = "0";
            tVat.TextAlign = HorizontalAlignment.Right;
            tVat.KeyDown += tVat_KeyDown;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(29, 68);
            label15.Name = "label15";
            label15.Size = new Size(42, 15);
            label15.TabIndex = 25;
            label15.Text = "Vat 7%";
            // 
            // tTotal
            // 
            tTotal.Enabled = false;
            tTotal.Location = new Point(93, 93);
            tTotal.Name = "tTotal";
            tTotal.Size = new Size(100, 23);
            tTotal.TabIndex = 28;
            tTotal.Text = "0";
            tTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(29, 96);
            label16.Name = "label16";
            label16.Size = new Size(32, 15);
            label16.TabIndex = 27;
            label16.Text = "Total";
            // 
            // gTAmount
            // 
            gTAmount.Controls.Add(tTotal);
            gTAmount.Controls.Add(tVat);
            gTAmount.Controls.Add(label16);
            gTAmount.Controls.Add(label14);
            gTAmount.Controls.Add(tTotalAmount);
            gTAmount.Controls.Add(label15);
            gTAmount.Location = new Point(615, 554);
            gTAmount.Name = "gTAmount";
            gTAmount.Size = new Size(249, 160);
            gTAmount.TabIndex = 12;
            gTAmount.TabStop = false;
            // 
            // bNew
            // 
            bNew.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bNew.Location = new Point(189, 677);
            bNew.Name = "bNew";
            bNew.Size = new Size(75, 37);
            bNew.TabIndex = 13;
            bNew.Text = "New";
            bNew.UseVisualStyleBackColor = true;
            bNew.Click += bNew_Click;
            // 
            // bShow
            // 
            bShow.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bShow.Location = new Point(284, 677);
            bShow.Name = "bShow";
            bShow.Size = new Size(75, 37);
            bShow.TabIndex = 14;
            bShow.Text = "Show";
            bShow.UseVisualStyleBackColor = true;
            bShow.Click += bShow_Click;
            // 
            // bClose
            // 
            bClose.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bClose.Location = new Point(386, 677);
            bClose.Name = "bClose";
            bClose.Size = new Size(75, 37);
            bClose.TabIndex = 15;
            bClose.Text = "Close";
            bClose.UseVisualStyleBackColor = true;
            bClose.Click += bClose_Click;
            // 
            // InVoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 740);
            Controls.Add(bClose);
            Controls.Add(bShow);
            Controls.Add(bNew);
            Controls.Add(gTAmount);
            Controls.Add(gEmployee);
            Controls.Add(dataGridView1);
            Controls.Add(bRemove);
            Controls.Add(bEdit);
            Controls.Add(bAdd);
            Controls.Add(gItem);
            Controls.Add(gCustomer);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(tNumber);
            Controls.Add(label1);
            Name = "InVoice";
            Text = "Training Company";
            gCustomer.ResumeLayout(false);
            gCustomer.PerformLayout();
            gItem.ResumeLayout(false);
            gItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gEmployee.ResumeLayout(false);
            gEmployee.PerformLayout();
            gTAmount.ResumeLayout(false);
            gTAmount.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tNumber;
        private Label label2;
        private TextBox tCodeCustomer;
        private DateTimePicker dateTimePicker1;
        private GroupBox gCustomer;
        private GroupBox gItem;
        private Label label5;
        private Label label4;
        private TextBox tProvinceCustomer;
        private TextBox tNameCustomer;
        private Label label3;
        private TextBox tCodeItem;
        private Label label6;
        private TextBox tQtyItem;
        private Label label10;
        private TextBox tPriceItem;
        private Label label9;
        private TextBox tTypeItem;
        private Label label8;
        private TextBox tNameItem;
        private Label label7;
        private TextBox tAmountItem;
        private Label label11;
        private Button bAdd;
        private Button bEdit;
        private Button bRemove;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GroupBox gEmployee;
        private TextBox tEmployeeName;
        private Label label13;
        private TextBox tEmployeeCode;
        private Label label12;
        private TextBox tTotalAmount;
        private Label label14;
        private TextBox tVat;
        private Label label15;
        private TextBox tTotal;
        private Label label16;
        private GroupBox gTAmount;
        private Button bNew;
        private Button bShow;
        private Button bClose;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn cCode;
        private DataGridViewTextBoxColumn cName;
        private DataGridViewTextBoxColumn cType;
        private DataGridViewTextBoxColumn cPrice;
        private DataGridViewTextBoxColumn cQty;
        private DataGridViewTextBoxColumn cAmount;
    }
}
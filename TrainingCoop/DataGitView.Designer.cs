namespace TrainingCoop
{
    partial class DataGridView
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            dCode = new DataGridViewTextBoxColumn();
            dName = new DataGridViewTextBoxColumn();
            dM = new DataGridViewComboBoxColumn();
            dS = new DataGridViewCheckBoxColumn();
            dSs = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dCode, dName, dM, dS, dSs });
            dataGridView1.Location = new Point(82, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(644, 414);
            dataGridView1.TabIndex = 0;
            // 
            // dCode
            // 
            dCode.HeaderText = "รหัส";
            dCode.Name = "dCode";
            dCode.Resizable = DataGridViewTriState.True;
            // 
            // dName
            // 
            dName.HeaderText = "ชื่อ";
            dName.Name = "dName";
            dName.Width = 200;
            // 
            // dM
            // 
            dM.HeaderText = "สาขา";
            dM.Items.AddRange(new object[] { "มนุษย์ศาสตร์", "วิศวกรรมศาสตร์", "วิทยาศสตร์" });
            dM.Name = "dM";
            dM.Resizable = DataGridViewTriState.True;
            dM.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dS
            // 
            dS.HeaderText = "สถาณะ";
            dS.Name = "dS";
            dS.Resizable = DataGridViewTriState.True;
            dS.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dSs
            // 
            dSs.HeaderText = "สถาณะ";
            dSs.Name = "dSs";
            // 
            // DataGridView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Controls.Add(dataGridView1);
            Name = "DataGridView";
            Text = "DataGridView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dCode;
        private DataGridViewTextBoxColumn dName;
        private DataGridViewComboBoxColumn dM;
        private DataGridViewCheckBoxColumn dS;
        private DataGridViewButtonColumn dSs;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingCoop
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void customerCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                customerName.Focus();
            }
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            customerCode.Clear();
            customerName.Clear();
            County.Text = "";
            customerCode.Focus();
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label1.Text + " = " + customerCode.Text + "\n" +
                            label2.Text + " = " + customerName.Text + "\n" +
                            label3.Text + " = " + County.Text, "ข้อมูลประเภทสินค้า");
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการที่จะปิดหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            int r = dataGridView1.Rows.Count;
            dataGridView1.Rows[r - 1].Cells[0].Value = customerCode.Text;
            dataGridView1.Rows[r - 1].Cells[1].Value = customerName.Text;
            dataGridView1.Rows[r - 1].Cells[2].Value = County.Text;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            customerCode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            customerName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            County.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}

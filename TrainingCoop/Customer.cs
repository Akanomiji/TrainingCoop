using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private int searchCode()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value + "" == customerCode.Text)
                {
                    return i;

                }
            }
            return -1;
        }
        private void customerCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                customerName.Focus();
                int index = searchCode();
                if (index >= 0)
                {
                    MessageBox.Show("ข้อมูลซ้ำ");
                    customerCode.Focus();
                    return;
                }
                /*
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value + "" == customerCode.Text)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                        customerCode.Text = dataGridView1.Rows[i].Cells[1].Value + "";
                        customerName.Text = dataGridView1.Rows[i].Cells[2].Value + "";
                        County.Text = dataGridView1.Rows[i].Cells[3].Value + "";
                    }
                }
                */
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


        private void EButtonF()
        {
            bEdit.Enabled = false;
            bRemove.Enabled = false;
        }

        private void EButtonT()
        {
            bEdit.Enabled = true;
            bRemove.Enabled = true;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            int r = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[r].Cells[0].Value = r + 1;
            dataGridView1.Rows[r].Cells[1].Value = customerCode.Text;
            dataGridView1.Rows[r].Cells[2].Value = customerName.Text;
            dataGridView1.Rows[r].Cells[3].Value = County.Text;
            EButtonF();
            bNew.PerformClick();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            customerCode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            customerName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            County.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            EButtonT();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[r].Cells[1].Value = customerCode.Text;
            dataGridView1.Rows[r].Cells[2].Value = customerName.Text;
            dataGridView1.Rows[r].Cells[3].Value = County.Text;
        }
    }
}

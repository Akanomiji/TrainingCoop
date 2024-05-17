using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingCoop
{
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }
        private int searchCode()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value + "" == departmentCode.Text)
                {

                    return i;

                }
            }
            return -1;
        }

        private void departmentCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                departmentName.Focus();
                int index = searchCode();
                if (index >= 0)
                {
                    MessageBox.Show("ข้อมูลซ้ำ");
                    departmentCode.Focus();
                    return;
                }
                /*
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value + "" == departmentCode.Text)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                        departmentCode.Text = dataGridView1.Rows[i].Cells[1].Value + "";
                        departmentName.Text = dataGridView1.Rows[i].Cells[2].Value + "";
                        //County.Text = dataGridView1.Rows[i].Cells[3].Value + "";
                    }
                }
                */
            }
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            departmentCode.Clear();
            departmentName.Clear();
            departmentCode.Focus();
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label1.Text + " = " + departmentCode.Text + "\n" +
                            label2.Text + " = " + departmentName.Text, "ข้อมูลแผนก");
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            departmentCode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            departmentName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            EButtonT();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            int r = dataGridView1.Rows.Count-1;
            dataGridView1.Rows[r].Cells[0].Value = r + 1;
            dataGridView1.Rows[r].Cells[1].Value = departmentCode.Text;
            dataGridView1.Rows[r].Cells[2].Value = departmentName.Text;
            EButtonF();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[r].Cells[1].Value = departmentCode.Text;
            dataGridView1.Rows[r].Cells[2].Value = departmentName.Text;
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(r);
            for (int i = 0; i < dataGridView1.Rows.Count; i++) { dataGridView1.Rows[i].Cells[0].Value = i + 1; }
        }
    }
}

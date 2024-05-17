using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingCoop
{
    public partial class Employee : Form
    {
        string sex = "";
        public Employee()
        {
            InitializeComponent();
            inSex();
        }


        private void employeeCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                employeeName.Focus();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value + "" == employeeCode.Text)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                        employeeCode.Text = dataGridView1.Rows[i].Cells[1].Value + "";
                        employeeName.Text = dataGridView1.Rows[i].Cells[2].Value + "";
                        Salary.Text = dataGridView1.Rows[i].Cells[3].Value + "";
                        EmployeePosition.Text = dataGridView1.Rows[i].Cells[4].Value + "";
                        sex = dataGridView1.Rows[i].Cells[5].Value + "";
                        pictureBox1.Image = (Image)dataGridView1.Rows[i].Cells[6].Value;
                    }
                }
            }
        }

        private void employeeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Salary.Focus();
            }
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            employeeCode.Clear();
            employeeName.Clear();
            Salary.Clear();
            mSex.Checked = false;
            fSex.Checked = false;
            noSex.Checked = false;
            EmployeePosition.Text = "";
            employeeCode.Focus();
        }

        private void inSex()
        {

            if (mSex.Checked)
            {
                sex = mSex.Text;
            }
            else if (fSex.Checked)
            {
                sex = fSex.Text;
            }
            else
            {
                sex = noSex.Text;
            }
        }
        private void bShow_Click(object sender, EventArgs e)
        {
            //string sex = "";
            inSex();
            /*
            if (mSex.Checked)
            {
                sex = mSex.Text;
            }
            else if (fSex.Checked)
            {
                sex = fSex.Text;
            }
            else
            {
                sex = noSex.Text;
            }
            */
            MessageBox.Show(label1.Text + " = " + employeeCode.Text + "\n" +
                            label2.Text + " = " + employeeName.Text + "\n" +
                            label4.Text + " = " + Salary.Text + "\n" +
                            label5.Text + " = " + sex + "\n" +
                            label3.Text + " = " + EmployeePosition.Text + "\n", "ข้อมูลพนักงาน");
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการที่จะปิดหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bBrows_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeCode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            employeeName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Salary.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            EmployeePosition.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            sex = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() + "");

            pictureBox1.Image = (Image)dataGridView1.Rows[e.RowIndex].Cells[6].Value; // view picture column in picturebox
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            inSex();
            dataGridView1.Rows.Add();
            int r = dataGridView1.Rows.Count-1;
            dataGridView1.Rows[r].Cells[0].Value = r + 1;
            dataGridView1.Rows[r].Cells[1].Value = employeeCode.Text;
            dataGridView1.Rows[r].Cells[2].Value = employeeName.Text;
            dataGridView1.Rows[r].Cells[3].Value = Salary.Text;
            dataGridView1.Rows[r].Cells[4].Value = EmployeePosition.Text;
            dataGridView1.Rows[r].Cells[5].Value = sex;
            dataGridView1.Rows[r].Cells[6].Value = pictureBox1.Image; // add picture to column 
            dataGridView1.Rows[r].Height = 50; // column height
            dataGridView1.Columns[6].Width = 50;  // column width 

        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[r].Cells[1].Value = employeeCode.Text;
            dataGridView1.Rows[r].Cells[2].Value = employeeName.Text;
            dataGridView1.Rows[r].Cells[3].Value = Salary.Text;
            dataGridView1.Rows[r].Cells[4].Value = EmployeePosition.Text;
            dataGridView1.Rows[r].Cells[5].Value = sex;
            dataGridView1.Rows[r].Cells[6].Value = pictureBox1.Image;
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(r);
            for (int i = 0; i < dataGridView1.Rows.Count; i++) { dataGridView1.Rows[i].Cells[0].Value = i + 1; }
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }
    }
}

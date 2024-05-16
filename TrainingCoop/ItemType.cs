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
    public partial class ItemType : Form
    {
        public ItemType()
        {
            InitializeComponent();
        }
        private void typeCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                typeName.Focus();
            }
        }
        private void bNew_Click(object sender, EventArgs e)
        {
            typeCode.Clear();
            typeName.Clear();
            typeCode.Focus();
        }
        private void bShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label1.Text + " = " + typeCode.Text + "\n" +
                            label2.Text + " = " + typeName.Text, "ข้อมูลประเภทสินค้า");
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการที่จะปิดหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            //MessageBox.Show(dataGridView1.Rows.Count + "");
            int r = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[r].Cells[0].Value = r + 1;
            dataGridView1.Rows[r].Cells[1].Value = typeCode.Text;
            dataGridView1.Rows[r].Cells[2].Value = typeName.Text;
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            /*
            if (this.dataGridView1.SelectedRows.Count > 0) 
            { 
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index); 
            }
            //dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            */
            int r = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(r);
            //dataGridView1.Rows[r].Cells[0].Value = typeCode.Text;
            //dataGridView1.Rows[r].Cells[1].Value = typeName.Text;
            for (int i = 0; i < dataGridView1.Rows.Count; i++) { dataGridView1.Rows[i].Cells[0].Value = i + 1; }

        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[r].Cells[1].Value = typeCode.Text;
            dataGridView1.Rows[r].Cells[2].Value = typeName.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.RowIndex + "");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.RowIndex + "");
            typeCode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            typeName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void bShowC_Click(object sender, EventArgs e)
        {

            string Msb = "";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Msb = Msb + dataGridView1.Rows[i].Cells[0].Value + "\n";
            }
            MessageBox.Show(Msb + "");


            /*
            for (int i = 0; i< dataGridView1.RowCount; i++) { MessageBox.Show(dataGridView1.Rows[i].Cells[i].Value.ToString()); }
            */
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0;i < dataGridView1.RowCount;i++) 
            {
                if (dataGridView1.Rows[i].Cells[1].Value + "" == typeCode.Text ) 
                {
                    typeName.Text = dataGridView1.Rows[i].Cells[2].Value + "";
                }
            }
        }
    }
}

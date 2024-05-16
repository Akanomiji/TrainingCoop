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
    public partial class InVoice : Form
    {
        //double price = 0;


        public InVoice()
        {
            InitializeComponent();
        }

        private void tNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                tCodeCustomer.Focus();
            }
        }

        private void tCodeCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tNameCustomer.Focus();
            }
        }

        private void tNameCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tProvinceCustomer.Focus();
            }
        }

        private void tProvinceCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tCodeItem.Focus();
            }
        }

        private void tCodeItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tNameItem.Focus();
            }
        }

        private void tNameItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tTypeItem.Focus();
            }
        }

        private void tTypeItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tPriceItem.Focus();
            }
        }

        private void tPriceItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                tQtyItem.Focus();
            }
        }

        private void tQtyItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double amount = int.Parse(tPriceItem.Text) * int.Parse(tQtyItem.Text);
                tAmountItem.Text = amount.ToString();
                tEmployeeCode.Focus();
            }
        }

        private void tAmountItem_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tEmployeeCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tEmployeeName.Focus();
            }
        }

        private void tEmployeeName_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tTotalAmount_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tVat_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            int r = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[r].Cells[0].Value = r + 1;
            dataGridView1.Rows[r].Cells[1].Value = tCodeItem.Text;
            dataGridView1.Rows[r].Cells[2].Value = tNameItem.Text;
            dataGridView1.Rows[r].Cells[3].Value = tTypeItem.Text;
            dataGridView1.Rows[r].Cells[4].Value = tPriceItem.Text;
            dataGridView1.Rows[r].Cells[5].Value = tQtyItem.Text;
            dataGridView1.Rows[r].Cells[6].Value = tAmountItem.Text;

            tNumber.Text = dataGridView1.Rows[r].Cells[0].Value+"";


            double amt = double.Parse(tAmountItem.Text);
            double tTotalA = double.Parse(tAmountItem.Text);
            tTotalA = amt;
            tTotalAmount.Text = tTotalA.ToString();
            double vat = 0.07;
            double total;
            vat = vat* tTotalA ;
            tVat.Text = vat.ToString("#,##0.00");
            total = tTotalA - vat;
            tTotal.Text = total.ToString("#,##0.00");

            //bNew.PerformClick();

        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            //dataGridView1.Rows[r].Cells[0].Value = tNumber.Text;
            dataGridView1.Rows[r].Cells[1].Value = tCodeItem.Text;
            dataGridView1.Rows[r].Cells[2].Value = tNameItem.Text;
            dataGridView1.Rows[r].Cells[3].Value = tTypeItem.Text;
            dataGridView1.Rows[r].Cells[4].Value = tPriceItem.Text;
            dataGridView1.Rows[r].Cells[5].Value = tQtyItem.Text;
            dataGridView1.Rows[r].Cells[6].Value = tAmountItem;


            double amt = double.Parse(tAmountItem.Text);
            double tTotalA = double.Parse(tAmountItem.Text);
            tTotalA = amt;
            tTotalAmount.Text = tTotalA.ToString();
            double vat = 0.07;
            double total;
            vat = vat * tTotalA;
            tVat.Text = vat.ToString("#,##0.00");
            total = tTotalA - vat;
            tTotal.Text = total.ToString("#,##0.00");
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            double amt = double.Parse(dataGridView1.Rows[r].Cells[6].Value + "");
            double tTotalA = double.Parse(tTotalAmount.Text);
            tTotalA = amt;
            tTotalAmount.Text = tTotalA.ToString();
            double vat = 0.07;
            double total;
            vat = vat * tTotalA;
            tVat.Text = vat.ToString("#,##0.00");
            total = tTotalA - vat;
            tTotal.Text = total.ToString("#,##0.00");
            dataGridView1.Rows.RemoveAt(r);
            for (int i = 0; i < dataGridView1.Rows.Count; i++) { dataGridView1.Rows[i].Cells[0].Value = i + 1; }
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            tAmountItem.Clear();
            tCodeCustomer.Clear();
            tCodeItem.Clear();
            tEmployeeCode.Clear();
            //tNumber.Clear();
            tEmployeeName.Clear();
            tNameItem.Clear();
            tQtyItem.Clear();
            tAmountItem.Clear();
            tTotalAmount.Clear();
            tVat.Clear();
            tTotal.Clear();
            tPriceItem.Clear();
            tProvinceCustomer.Clear();
            tTypeItem.Clear();
            tNameCustomer.Clear();
        }

        private void bShow_Click(object sender, EventArgs e)
        {

        }

        private void bClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการที่จะปิดหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //tNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tCodeItem.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tNameItem.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tTypeItem.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tPriceItem.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            tQtyItem.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            tAmountItem.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            //tNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value + "";
        }
    }
}

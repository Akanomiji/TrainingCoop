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
    public partial class Item : Form
    {
        string isVat = "";
        double pAmount = 0;
        public Item()
        {
            InitializeComponent();
        }

        private void itemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                itemName.Focus();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value + "" == itemCode.Text)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                        itemName.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        typeName.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        price.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                        if (dataGridView1.Rows[i].Cells[5].Value + "" == Vat.Text)
                        {
                            Vat.Checked = true;
                            //itemName.Focus();
                        }
                        else
                        {
                            noVat.Checked = true;
                            //itemName.Focus();
                        }
                        qty.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                        amount.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
                    }
                }
            }
        }

        private void itemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                typeName.Focus();
            }
        }

        private void price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                qty.Focus();
            }
        }

        private void qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                try
                {
                    double vat = 1, amt = int.Parse(price.Text) * int.Parse(qty.Text);
                    if (Vat.Checked)
                        vat = 0.07;
                    amt = amt-(amt * vat);
                    amount.Text = amt.ToString("#,###.00");
                }
                catch (Exception ex)
                {
                    amount.Clear();
                    MessageBox.Show("ป้อนราคาหรือจำนวนไม่ถูกต้อง", "ข้อมูลผิดพลาด");
                }
            }
        }


        private void clearVat()
        {
            //price.Clear();
            qty.Clear();
            amount.Clear();
            price.Focus();
        }

        private void Vat_CheckedChanged(object sender, EventArgs e)
        {
            clearVat();
            isVat = Vat.Text + "";
        }

        private void noVat_CheckedChanged(object sender, EventArgs e)
        {
            clearVat();
            isVat = noVat.Text + "";
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            itemCode.Clear();
            itemName.Clear();
            typeName.Text = "";
            Vat.Checked = false;
            noVat.Checked = false;
            price.Clear();
            qty.Clear();
            amount.Clear();
            itemCode.Focus();
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label1.Text + " = " + itemCode.Text + "\n" +
                            label2.Text + " = " + itemName.Text + "\n" +
                            label3.Text + " = " + typeName.Text + "\n" +
                            label7.Text + " = " + isVat + "\n" +
                            label4.Text + " = " + price.Text + "\n" +
                            label5.Text + " = " + qty.Text + "\n" +
                            label6.Text + " = " + amount.Text + "\n", "ข้อมูลสินค้า");
        }



        private void bClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการที่จะปิดหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            itemCode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            itemName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            typeName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            price.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[5].Value + "" == Vat.Text)
            {
                Vat.Checked = true;
            }
            else { noVat.Checked = true; }
            qty.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            amount.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();


        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            int r = dataGridView1.Rows.Count - 1;

            dataGridView1.Rows[r].Cells[0].Value = r + 1;
            dataGridView1.Rows[r].Cells[1].Value = itemCode.Text;
            dataGridView1.Rows[r].Cells[2].Value = itemName.Text;
            dataGridView1.Rows[r].Cells[3].Value = typeName.Text;
            dataGridView1.Rows[r].Cells[4].Value = price.Text;
            dataGridView1.Rows[r].Cells[5].Value = isVat;
            dataGridView1.Rows[r].Cells[6].Value = qty.Text;
            dataGridView1.Rows[r].Cells[7].Value = amount.Text;

            double amt = double.Parse(amount.Text);
            double tTotalA = double.Parse(tTotalAmount.Text);
            tTotalA = tTotalA + amt;
            tTotalAmount.Text = tTotalA.ToString();

            bNew.PerformClick();

        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[r].Cells[1].Value = itemCode.Text;
            dataGridView1.Rows[r].Cells[2].Value = itemName.Text;
            dataGridView1.Rows[r].Cells[3].Value = typeName.Text;
            dataGridView1.Rows[r].Cells[4].Value = price.Text;
            dataGridView1.Rows[r].Cells[5].Value = isVat;
            dataGridView1.Rows[r].Cells[6].Value = qty.Text;



            double amt = double.Parse(amount.Text);
            double tTotalA = double.Parse(tTotalAmount.Text);
            double eTotalA = double.Parse(dataGridView1.Rows[r].Cells[7].Value + "");
            tTotalA = (tTotalA - eTotalA) + amt;
            tTotalAmount.Text = tTotalA.ToString();

            dataGridView1.Rows[r].Cells[7].Value = amount.Text;


        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            double tTotalA = double.Parse(tTotalAmount.Text);
            double amt = double.Parse(dataGridView1.Rows[r].Cells[7].Value + "");
            tTotalA = tTotalA + amt;
            tTotalAmount.Text = tTotalA.ToString("#,##0.00");
            dataGridView1.Rows.RemoveAt(r);
            for (int i = 0; i < dataGridView1.Rows.Count; i++) { dataGridView1.Rows[i].Cells[0].Value = i + 1; }

        }

        private void tTotalAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Item_Load(object sender, EventArgs e)
        {

        }
    }
}

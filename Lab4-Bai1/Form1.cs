using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        { 
                Close();
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Chưa nhập tên khách hàng!", "Thông báo");
            }
            else
            {
                int total = 0;
                if (chkClean.Checked)
                {
                    total += 100000;
                }
                if (chkWhitening.Checked)
                {
                    total += 1200000;
                }
                if (chkXRay.Checked)
                {
                    total += 200000;
                }
                int a = int.Parse(numFilling.Text);
                total += a * 80000;
                txtTotal.Text = "$" + total.ToString();
            }
            // gọi chức năng tính tiền
        //  GetPay();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            lBox1.Items.Add($"{txtName.Text} - {txtTotal.Text}");
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BAI_3
{
    public partial class Form1 : Form
    {
        private object errSonguyen;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtSonguyen_TextChanged(object sender, EventArgs e)
        {
            /*Control ctrSonguyen = (Control)sender;
            if (ctrSonguyen.Text.Length > 0)
            {
                if (!char.IsDigit(ctrSonguyen.Text[ctrSonguyen.Text.Length - 1]))
                {
                    this.errSonguyen = ctrSonguyen;
                    object value = errSonguyen.SetError(ctrSonguyen,"Vui lòng nhập số nguyên");
                    _ = errSonguyen.SetError(ctrSonguyen,"Vui lòng nhập số nguyên");
                }
                else
                {
                    object value = errSonguyen.Clear();
                }
            }*/
            //int a=int.Parse(txtSonguyen.Text);
           
            
        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtSonguyen.Text);
                lstKetqua.Items.Add(txtSonguyen.Text);
                txtSonguyen.Text = "";
                txtSonguyen.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Cần nhập số nguyên!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtSonguyen.Text = "";
                txtSonguyen.Focus();
            }


        }

        private void btTang2_Click(object sender, EventArgs e)
        {
            /* int n = lstKetqua.Items.Count; //Số mục trong lst
             for(int i = 0; i < n; i++)
             {
                 int tam = int.Parse(lstKetqua.Items[i].ToString()) ;
                 int tang = tam + 2;
                 lstKetqua.Items.RemoveAt(i);
                 lstKetqua.Items.Add(txtSonguyen.Text);
                 lstKetqua.Items.Insert(i, tang.ToString());
             }*/
            int n = lstKetqua.Items.Count; //Số mục trong lst
            for (int i = 0; i < n; i++)
            
                lstKetqua.Items[i] = Convert.ToInt32(lstKetqua.Items[i]) + 2;
            
        }

        private void btChonchandau_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count; 
            for(int i = 0; i < n ; i++)
            {
                
                if (Convert.ToInt32(lstKetqua.Items[i]) % 2 == 0)
                {
                    lstKetqua.SelectedIndex = i;
                    return;
                    //Thực hiện được số chẵn đầu thì kết thúc vòng lặp
                }
        
            }
        }

        private void btLecuoi_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count;
            for (int i = n - 1; i >= 0; i--)
            {
                if (Convert.ToInt32(lstKetqua.Items[i].ToString()) % 2 != 0)
                {
                   // string s = lstKetqua.Items[i].ToString(); 
                    lstKetqua.SelectedIndex = i; 
                    break; //Thực hiện được số lẻ đầu (từ dưới lên) thì kết thúc vòng lặp
                }
            }
        }
        
        private void btXoaptdangchon_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.SelectedItems.Count; //Số mục đang được chọn trong lstKetqua
            for(int i = n - 1; i >= 0; i--)
            {
                lstKetqua.Items.Remove(lstKetqua.SelectedItems[i].ToString());
            }
        }

        private void btXoaptdau_Click(object sender, EventArgs e)
        {
           lstKetqua.Items.Remove(lstKetqua.Items[0].ToString());
        }

        private void btXoaptcuoi_Click(object sender, EventArgs e)
        {
           int n = lstKetqua.Items.Count;
            lstKetqua.Items.Remove(lstKetqua.Items[n - 1].ToString());
        }

        private void btKetthuc_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void lstKetqua_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

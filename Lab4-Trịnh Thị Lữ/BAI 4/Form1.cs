using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btTatcaphaisangtrai_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count;
            for (int i = 0; i <= n - 1; i++)
            {
                lstBandau.Items.Add(lstBandau.Items[i].ToString());
                for (int j = n - 1; j >= 0; j--)
                {
                    lstKetqua.Items.Remove(j);
                }
            }
        }

        private void btKetthuc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            lstBandau.Items.Add(txtHoten.Text);
            txtHoten.Text = "";
            txtHoten.Focus();
        }

        private void btTraisangphai_Click(object sender, EventArgs e)
        {
            int n = lstBandau.SelectedItems.Count; //Tổng số mục được chọn
            for (int i = 0; i <= n - 1; i++)
            {
                lstKetqua.Items.Add(lstBandau.SelectedItems[i].ToString());
                for (int j = n - 1; j >= 0; j--)
                {
                    lstBandau.Items.RemoveAt(j);
                }
            }
        }

        private void btTatcatraisangphai_Click(object sender, EventArgs e)
        {
            int n = lstBandau.Items.Count;
            for (int i = 0; i <= n - 1; i++)
            {
                lstKetqua.Items.Add(lstBandau.Items[i].ToString());
                for (int j = n - 1; j >= 0; j--)
                {
                    lstBandau.Items.Remove(lstBandau.SelectedIndex);
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            lstKetqua.Items.Clear();
            lstBandau.Items.Clear();
        }

        private void btPhaisangtrai_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count;
            for (int i = 0; i <= n - 1; i++)
            {
                lstBandau.Items.Add(lstKetqua.Items[i].ToString());
                for (int j = n - 1; j >= 0; j--)
                {
                    lstKetqua.Items.RemoveAt(j);
                }
            }
        }

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
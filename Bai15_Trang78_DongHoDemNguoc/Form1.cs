using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai15_Trang78_DongHoDemNguoc
{
    public partial class Form1 : Form
    {
        ulong tongTG;   // Đơn vị: giây (s)
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrDongHo.Interval = 1000;  // 1s
            txtPhut.MaxLength = 2;
            txtGiay.MaxLength = 2;
        }

        private void txtPhut_KeyPress(object sender, KeyPressEventArgs e)
        {
            // chỉ được nhập số
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnChay_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightBlue;
            btn.ForeColor = Color.Red;
        }

        private void btnChay_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }

        private void btnChay_Click(object sender, EventArgs e)
        {
            if(txtPhut.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số phút");
                txtPhut.Focus();
                return;
            }
            if (txtGiay.Text.Trim() == "" || int.Parse(txtGiay.Text.Trim())>60)
            {
                MessageBox.Show("Bạn phải nhập số giây trong đoạn [0->60]");
                txtGiay.Clear();
                txtGiay.Focus();
                return;
            }

            tongTG = ulong.Parse(txtPhut.Text.Trim())*60 + ulong.Parse(txtGiay.Text.Trim());
            tmrDongHo.Start();
        }

        private void tmrDongHo_Tick(object sender, EventArgs e)
        {
            if (tongTG > 0)
            {
                tongTG -= 1;
                txtPhut.Text = (tongTG / 60).ToString();
                txtGiay.Text = (tongTG % 60).ToString();
            }
            else
            {
                MessageBox.Show("Báo thức ^^");
                tmrDongHo.Stop();
            }
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            tmrDongHo.Stop();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            tongTG = 0;
            txtPhut.Text = (tongTG / 60).ToString();
            txtGiay.Text = (tongTG % 60).ToString();

        }

        private void txtPhut_MouseEnter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox) sender;
            txt.BackColor = Color.Yellow;
            txt.ForeColor = Color.Green;
        }

        private void txtPhut_MouseLeave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.White;
            txt.ForeColor = Color.Black;
        }

        private void txtPhut_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.Yellow;
            txt.ForeColor = Color.Green;
        }
    }
}

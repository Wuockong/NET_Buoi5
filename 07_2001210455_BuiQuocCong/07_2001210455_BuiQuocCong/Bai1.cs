using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_2001210455_BuiQuocCong
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int n = 0, m = 0;
            if (int.TryParse(txtA.Text, out n) &&  int.TryParse(txtB.Text, out m))
                txtKQ.Text = (n + m).ToString();
            else
                txtKQ.Text = "Vui long nhap gia tri so";
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int n = 0, m = 0;
            if (int.TryParse(txtA.Text, out n) &&  int.TryParse(txtB.Text, out m))
                txtKQ.Text = (n - m).ToString();
            else
                txtKQ.Text = "Vui long nhap gia tri so";
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int n = 0, m = 0;
            if (int.TryParse(txtA.Text, out n) &&  int.TryParse(txtB.Text, out m))
                txtKQ.Text = (n * m).ToString();
            else
                txtKQ.Text = "Vui long nhap gia tri so";
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            int n = 0, m = 0;
            if (int.TryParse(txtA.Text, out n) &&  int.TryParse(txtB.Text, out m))
                txtKQ.Text = (n * 1.0 / m).ToString();
            else
                txtKQ.Text = "Vui long nhap gia tri so";
        }
    }
}

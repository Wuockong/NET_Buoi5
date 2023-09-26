using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace _07_2001210455_BuiQuocCong
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnACC_Click(object sender, EventArgs e)
        {
            string a = txtA.Text;
            string b = txtB.Text;

            if (string.IsNullOrWhiteSpace(a) || string.IsNullOrWhiteSpace(b))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(int.TryParse(a, out int n) && int.TryParse(b, out int m)) 
            {
                txtUCLN.Text = UCLN(n,m).ToString();
                txtBCNN.Text = BCNN(n,m).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập hai số nguyên hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private int BCNN(int a, int b)
        {
            return (a * b) / UCLN(a, b);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCTN_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtBCNN.Clear();
            txtUCLN.Clear();

            txtA.Focus();
        }
    }
}

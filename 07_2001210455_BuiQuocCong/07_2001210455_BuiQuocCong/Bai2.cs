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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string pass = txtPass.Text;
            string confirm = txtConFirm.Text;
            if(pass != confirm)
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin vào các trường bắt buộc (*)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string userInfo = string.Format("Tên đăng nhập: {0}\nEmail: {1}\nMật khẩu: {2}", name, email, pass);

            DialogResult result = MessageBox.Show(userInfo, "Xác nhận thông tin đăng ký", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
                this.Close();
        }

        private bool KiemTraDinhDangEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!KiemTraDinhDangEmail(txtEmail.Text))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
        }
        private void Bai2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi form đăng ký?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


    }
}

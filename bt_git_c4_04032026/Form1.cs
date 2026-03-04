using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_git_c4_04032026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textboxmatkhau.PasswordChar = '*';
            btnlogin.Click += Btnlogin_Click;
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            string username = textboxusername.Text;
            string password = textboxmatkhau.Text;

            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textboxusername.Clear();
                textboxmatkhau.Clear();
                textboxusername.Focus();
            }
        }
    }
}

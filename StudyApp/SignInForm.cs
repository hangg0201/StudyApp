using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyApp
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            string pathUser = "D:\\university\\cs526\\data\\user\\info.txt";
            bool validAccount = false;
            string validUser = "";
            using (StreamReader readaer = new StreamReader(pathUser))
            {
                string line;
                while((line = readaer.ReadLine()) != null)
                {
                    string[] parts = line.Split('*');
                    string userName = parts[1];
                    string password = parts[3];
                    if (userName == txtUsername.Text && password == txtPassword.Text)
                    {
                        validAccount = true;
                        validUser = userName;
                        break;
                    }
                }
            }
            if (validAccount)
            {
                MessageBox.Show("Đăng nhập tài khoản thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main formMain = new Main(validUser);
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng, vui lòng thủ lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar != '*')
            {
                txtPassword.PasswordChar = '*';
            }
            else
            {
                txtPassword.PasswordChar = '\0';
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            signUpForm formSignUp = new signUpForm();
            formSignUp.Show();
            this.Hide();
        }

        private void forgotPassLbl_Click(object sender, EventArgs e)
        {
            forgotPassForm fgForm = new forgotPassForm();
            fgForm.Show();
            this.Hide();
        }
    }
}

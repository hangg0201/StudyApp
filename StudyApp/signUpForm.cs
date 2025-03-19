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
    public partial class signUpForm : Form
    {
        string pathImageFrom = "";
        string pathImageTo = "";
        string pathUser = "";
        int ID = -1;
        public signUpForm()
        {
            InitializeComponent();
        }

        private void haveAccount_Click(object sender, EventArgs e)
        {
            SignInForm siForm = new SignInForm();
            siForm.Show();
            this.Hide();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (.jpg, *.jpeg, *.png, *.gif)|.jpg;*.jpeg;*.png;*.gif|All files (.)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathImageFrom = openFileDialog.FileName;
                txtImage.Text = pathImageFrom;
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            bool haveUser = false;
            bool haveEmail = false;
            using (StreamReader reader = new StreamReader(pathUser))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('*');
                    string userName = parts[1];
                    string email = parts[2];
                    if (email == txtEmail.Text)
                    {
                        haveEmail = true;
                        break;
                    }
                    if (userName == txtUsername.Text)
                    {
                        haveUser = true;
                        break;
                    }
                }
            }

            bool errorSignUp = false;
            if (txtUsername.Text == "")
            {
                errorUsername.Visible = true;
                errorUsername.Text = "Vui lòng không để trống";
                errorSignUp = true;
            }else if(haveUser){
                errorUsername.Visible = true;
                errorUsername.Text = "Username đã tồn tại, thử lại!";
                errorSignUp = true;
            }else
            {
                errorUsername.Visible = false;
            }

            if (txtEmail.Text == "")
            {
                errorEmail.Visible = true;
                errorEmail.Text = "Vui lòng không để trống";
                errorSignUp = true;
            }else if(haveEmail)
            {
                errorEmail.Visible = true;
                errorEmail.Text = "Email đã tồn tại, thử lại!";
                errorSignUp = true;
            }
            else
            {
                errorEmail.Visible = false;
            }

            if (txtName.Text == "")
            {
                errorName.Visible = true;
                errorName.Text = "Vui lòng không để trống";
                errorSignUp = true;
            }
            else
            {
                errorName.Visible = false;
            }

            if (txtPassword.Text == "")
            {
                errorPassword.Visible = true;
                errorPassword.Text = "Vui lòng không để trống";
                errorSignUp = true;
            }
            else
            {
                errorPassword.Visible= false;
            }

            if (txtImage.Text == "")
            {
                errorAva.Visible = true;
                errorAva.Text = "Vui lòng không để trống";
                errorSignUp = true;
            }
            else
            {
                errorAva.Visible = false;
            }

            if (errorSignUp)
            {
                return;
            }

            try
            {
                pathImageTo = "D:\\university\\cs526\\data\\user\\ava\\" + ID + ".png";
                pathUser = "D:\\university\\cs526\\data\\user\\info.txt";

                StreamWriter sw = new StreamWriter(pathUser, true);
                sw.WriteLine(ID.ToString() + "*" + txtUsername.Text + "*" + txtEmail.Text + "*" + txtPassword.Text + "*" + pathImageTo);
                sw.Close();
                FileInfo fi = new FileInfo(pathImageFrom);
                fi.CopyTo(pathImageTo);
                MessageBox.Show("Đăng ký tài khoản thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Text = "";
                txtEmail.Text = "";
                txtImage.Text = "";
                txtPassword.Text = "";
                txtName.Text = "";
            }catch
            {
                MessageBox.Show("Đăng ký tài khoản thất bại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void signUpForm_Load(object sender, EventArgs e)
        {
            errorUsername.Visible = false;
            errorPassword.Visible = false;
            errorEmail.Visible = false;
            errorName.Visible = false;
            errorAva.Visible = false;
            pathUser = "D:\\university\\cs526\\data\\user\\info.txt";
            using (StreamReader reader = new StreamReader(pathUser))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('*');
                    ID = int.Parse(parts[0]);
                }
            }
            ID += 1;
        }
        
    }
}

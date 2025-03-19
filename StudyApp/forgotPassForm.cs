using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace StudyApp
{
    public partial class forgotPassForm : Form
    {
        public forgotPassForm()
        {
            InitializeComponent();
        }

        private void backSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
            this.Hide();
        }

        private void forgotPassLbl_Click(object sender, EventArgs e)
        {
            signUpForm SignUpForm = new signUpForm();
            SignUpForm.Show();
            this.Hide();
        }

        private void forgotBtn_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            mail.From = new System.Net.Mail.MailAddress("");
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("", "");
            smtp.Host = "smtp.gmail.com";

            //recipient
            mail.To.Add(new MailAddress(txtEmail.Text));
            mail.IsBodyHtml = true;
            mail.Subject = "Khôi phục mật khẩu";
            mail.Body = "Mật khẩu của bạn là: 12345";

            //for (int i = 0; i < attachmentFilename.Length; i++)
            //    mail.Attachments.Add(new Attachment(attachmentFilename[i]));

            smtp.Send(mail);
            string pathUser = "D:\\university\\cs526\\data\\user\\" + "info.txt"; string tempFile = Path.GetTempFileName();

            bool emailFound = false;

            using (StreamReader reader = new StreamReader(pathUser))
            using (StreamWriter writer = new StreamWriter(tempFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('*');
                    string email = parts[2];
                    string pass = parts[3];

                    if (email == txtEmail.Text)
                    {
                        pass = "12345"; // Đổi mật khẩu thành "12345"
                        emailFound = true;
                    }

                    // Ghi lại dòng đã chỉnh sửa hoặc không
                    writer.WriteLine($"{parts[0]}*{parts[1]}*{parts[2]}*{pass}*{parts[4]}*{parts[5]}");
                }
            }

            // Thay thế tệp gốc bằng tệp đã chỉnh sửa
            File.Delete(pathUser);
            File.Move(tempFile, pathUser);

            if (emailFound)
            {
                MessageBox.Show("Password reset successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Email not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

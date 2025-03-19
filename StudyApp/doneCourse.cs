using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StudyApp
{
    public partial class doneCourse : UserControl
    {
        public event EventHandler reviewClicked;
        string currentName = "";
        string currentEmail = "";
        string currentCourse = "";
        public doneCourse()
        {
            InitializeComponent();
        }

        public void content(string nameCourse, string nameOrg, string courseImgPath, string currentUsr)
        {
            courseLbl.Text = nameCourse;
            orgLbl.Text = nameOrg;
            picThumb.BackgroundImage = Image.FromFile(courseImgPath);
            currentCourse = nameCourse;
            string infoPath = "D:\\university\\cs526\\data\\user\\info.txt";
            string[] lines = File.ReadAllLines(infoPath);
            foreach(string line in lines)
            {
                string[] parts = line.Split('*');
                currentName = parts[4];
                currentEmail = parts[2];
            }
        }

        private void certBtn_Click(object sender, EventArgs e)
        {
            certificateForm certificateForm = new certificateForm(currentName, currentEmail, currentCourse);
            certificateForm.Show();
        }

        private void rateLbl_Click(object sender, EventArgs e)
        {
            reviewClicked?.Invoke(this, e);
        }
    }
}

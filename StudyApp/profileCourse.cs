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
    public partial class profileCourse : UserControl
    {
        public profileCourse()
        {
            InitializeComponent();
        }

        private void profileCourse_Load(object sender, EventArgs e)
        {

        }
        public void content(string course)
        {
            courseName.Text = course;
            string filePath = "D:\\university\\cs526\\data\\courses\\homeCourse.txt";
            string[] lines = File.ReadAllLines(filePath);
            string imgPath = "";
            foreach(string line in lines)
            {
                string[] parts = line.Split('*');
                if (parts[1] == course)
                {
                    imgPath = parts[parts.Length - 1];
                    break;
                }
            }
            picThumb.BackgroundImage = Image.FromFile(imgPath);
        }
    }
}

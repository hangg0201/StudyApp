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
    public partial class progressCourse : UserControl
    {
        public event EventHandler courseClicked;

        public progressCourse()
        {
            InitializeComponent();
            this.Click += courseClick;
        }
        
        
        public void content(string nameCourse, string nameOrg, string avaPath, string orgImagePath, string currentUsr, string trackCoursePath)
        {
            progressBar1.Value = 0;
            string[] lines = File.ReadAllLines(trackCoursePath);
            int countDone = lines.Length;
            string[] lines2 = File.ReadAllLines("D:\\university\\cs526\\data\\courses\\" + nameCourse + "\\" + "courseDetails.txt");
            int count = lines2.Length;
            int progressPercentage = (int)((double)countDone / count * 100);
            progressBar1.Value = progressPercentage;

            courseLbl.Text = nameCourse;
            orgLbl.Text = nameOrg;
            picThumb.BackgroundImage = Image.FromFile(avaPath);
            string coursePath = "D:\\university\\cs526\\data\\courses\\" + nameCourse + "\\" + "courseDetails.txt";
            int ID = -1;
            lines = File.ReadAllLines(trackCoursePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split('*');
                int id = int.Parse(parts[0]);
                if(ID < id)
                {
                    ID = id;
                }
            }
            ID = ID + 1;
            lines = File.ReadAllLines(coursePath);
            if (ID == lines.Length)
            {
                string[] parts = lines[lines.Length - 1].Split('*');
                nextCourseLbl.Text = parts[2];
                timeLbl.Text = parts[4];
                if (parts[2] == "reading")
                {
                    picType.BackgroundImage = Image.FromFile("D:\\university\\cs526\\data\\icon\\book.png");
                }else if (parts[2] == "video")
                {
                    picType.BackgroundImage = Image.FromFile("D:\\university\\cs526\\data\\icon\\video.png");
                }
                else
                {
                    picType.BackgroundImage = Image.FromFile("D:\\university\\cs526\\data\\icon\\quiz.png");
                }
            }
            else
            {
                string[] parts = lines[ID].Split('*');
                nextCourseLbl.Text = parts[2];
                timeLbl.Text = parts[4];
                if (parts[2] == "reading")
                {
                    picType.BackgroundImage = Image.FromFile("D:\\university\\cs526\\data\\icon\\book.png");
                }
                else if (parts[2] == "video")
                {
                    picType.BackgroundImage = Image.FromFile("D:\\university\\cs526\\data\\icon\\video.png");
                }
                else
                {
                    picType.BackgroundImage = Image.FromFile("D:\\university\\cs526\\data\\icon\\quiz.png");
                }
            }
        }

        private void courseClick(object sender, EventArgs e)
        {
            courseClicked?.Invoke(this, e);
        }
    }
}

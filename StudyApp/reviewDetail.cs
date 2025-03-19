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
using Microsoft.Reporting.Map.WebForms.BingMaps;

namespace StudyApp
{
    public partial class reviewDetail : UserControl
    {
        public event EventHandler BackButtonClicked;
        string currentUser = "";
        string currentCourse = "";
        string currentName = "";
        int countStar = 0;
        int currentID = 0;
        string starPath = "D:\\university\\cs526\\data\\icon\\star-click.png";
        string starClickedPath = "D:\\university\\cs526\\data\\icon\\star-clicked.png";
        string userPath = "D:\\university\\cs526\\data\\user\\info.txt";
        string reviewPath = "";
        bool star1Click = false;
        bool star2Click = false;
        bool star3Click = false;
        bool star4Click = false;
        bool star5Click = false;
        public reviewDetail()
        {
            InitializeComponent();
            star1.BackgroundImage = Image.FromFile(starPath);
            star2.BackgroundImage = Image.FromFile(starPath);
            star3.BackgroundImage = Image.FromFile(starPath);
            star4.BackgroundImage = Image.FromFile(starPath);
            star5.BackgroundImage = Image.FromFile(starPath);
            
        }

        void LoadReview()
        {
            flowLayoutPanel1.Controls.Clear();
            reviewPath = "D:\\university\\cs526\\data\\user\\review\\" + currentCourse + ".txt";
            if(File.Exists(reviewPath))
            {
                string[] lines = File.ReadAllLines(reviewPath);
                int totalStar = 0;
                int totalComment = 0;
                foreach (string line in lines)
                {
                    string[] parts = line.Split('*');
                    int id = int.Parse(parts[0]);
                    string name = parts[1];
                    string comment = parts[2];
                    int star = int.Parse(parts[3]);
                    totalStar += star;
                    totalComment += 1;
                    reviewSmall reviewSmall = new reviewSmall();
                    reviewSmall.content(name, star.ToString(), comment);
                    flowLayoutPanel1.Controls.Add(reviewSmall);
                }
                int averageStar = totalStar / totalComment;
                starCount.Text = averageStar.ToString("F1");
                totalLbl.Text = totalComment.ToString();
            }
        }

        public void content(string currentUsr, string nameCourse)
        {
            courseLbl.Text = nameCourse;
            currentUser = currentUsr;
            currentCourse = nameCourse;
            LoadReview();
        }


        private void backbtn_Click_1(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, e);
        }

        private void star1_Click(object sender, EventArgs e)
        {
            if (star1Click)
            {
                star1.BackgroundImage = Image.FromFile(starPath);
                star1Click = false;
                countStar--;
            }
            else
            {
                star1.BackgroundImage = Image.FromFile(starClickedPath);
                star1Click = true;
                countStar++;
            }
        }

        private void star2_Click(object sender, EventArgs e)
        {
            if (star2Click)
            {
                star2.BackgroundImage = Image.FromFile(starPath);
                star2Click = false;
                countStar--;
            }
            else
            {
                star2.BackgroundImage = Image.FromFile(starClickedPath);
                star2Click= true;
                countStar++;
            }
        }

        private void star3_Click(object sender, EventArgs e)
        {
            if (star3Click)
            {
                star3.BackgroundImage = Image.FromFile(starPath);
                star3Click = false;
                countStar--;
            }
            else
            {
                star3.BackgroundImage = Image.FromFile(starClickedPath);
                star3Click= true;
                countStar++;
            }
        }

        private void star4_Click(object sender, EventArgs e)
        {
            if (star4Click)
            {
                star4.BackgroundImage = Image.FromFile(starPath);
                star4Click = false;
                countStar--;
            }
            else
            {
                star4.BackgroundImage = Image.FromFile(starClickedPath);
                star4Click= true;
                countStar++;
            }
        }

        private void star5_Click(object sender, EventArgs e)
        {
            if (star5Click)
            {
                star5.BackgroundImage = Image.FromFile(starPath);
                star5Click = false;
                countStar--;
            }
            else
            {
                star5.BackgroundImage = Image.FromFile(starClickedPath);
                star5Click= true;
                countStar++;
            }
        }

        private void reviewBtn_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(userPath);
            foreach(string line in lines)
            {
                string[] parts = line.Split('*');
                if (parts[1] == currentUser)
                {
                    currentID = int.Parse(parts[0]);
                    currentName = parts[4];
                    break;
                }
            }
            string content = currentID + "*" + currentName + "*" + richTextBox1.Text + "*" + countStar;
            using (StreamWriter sw = File.AppendText(reviewPath))
            {
                sw.WriteLine(content);
            }
            LoadReview();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudyApp
{
    public partial class courseDetail : UserControl
    {
        public event EventHandler BackButtonClicked;
        string currentUsr = "";
        int currentID = -1;
        string currentNameCourse = "";

        public courseDetail()
        {
            InitializeComponent();
        }

        public courseDetail(string currentUsername)
        {
            InitializeComponent();
            currentUsr = currentUsername;

        }

        public void content(string nameCourse, string nameOrg, string courseImgPath)
        {
            currentNameCourse = nameCourse;
            courseName.Text = nameCourse;
            orgName.Text = nameOrg;
            picCourse.BackgroundImage = Image.FromFile(courseImgPath);
            string filePath = "D:\\university\\cs526\\data\\courses\\" + nameCourse;
            learnLabelFromFile(filePath);
            gainLabelFromFile(filePath);

            string[] lines = File.ReadAllLines("D:\\university\\cs526\\data\\user\\info.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split('*');
                int id = int.Parse(parts[0]);
                string accountName = parts[1];
                string email = parts[2];
                string password = parts[3];
                string userName = parts[4];
                string avaPath = parts[5];
                if (currentUsr == accountName)
                {
                    currentID = id;
                }
            }

            string filePath2 = "D:\\university\\cs526\\data\\user\\trackCourse\\" + currentID + "_" + currentNameCourse + ".txt";
            try
            {
                if (!File.Exists(filePath2))
                {
                }
                else
                {
                    enrollBtn.Text = "Enrolled";
                    enrollBtn.BackColor = Color.DimGray;
                }
            }
            catch (Exception ex) { }
            string reviewPath = "D:\\university\\cs526\\data\\user\\review\\" + nameCourse + ".txt";

            if (File.Exists(reviewPath))
            {
                lines = File.ReadAllLines(reviewPath);
                int totalStar = 0;
                int totalComment = 0;
                foreach (string line in lines)
                {
                    string[] parts = line.Split('*');
                    int id = int.Parse(parts[0]);
                    string userPath = "D:\\university\\cs526\\data\\user\\info.txt";
                    string[] lines1 = File.ReadAllLines(userPath);
                    string ava = "";
                    foreach(string line1 in lines1)
                    {
                        string[] parts1 = line1.Split('*');
                        int idUser = int.Parse(parts1[0]);
                        string avaPath = parts1[parts1.Length - 1];
                        if(idUser == id)
                        {
                            ava = avaPath;
                            break;
                        }
                    }

                    string name = parts[1];
                    string comment = parts[2];
                    int star = int.Parse(parts[3]);
                    totalStar += star;
                    totalComment += 1;
                    userReview reviewSmall = new userReview();
                    reviewSmall.content(name, star.ToString(), comment, ava);
                    flowLayoutPanel1.Controls.Add(reviewSmall);
                }
                int averageStar = totalStar / totalComment;
                starCount.Text = averageStar.ToString("F1");
                totalLbl.Text = totalComment.ToString();
            }

        }
        public void inforLabelFromFile(string filePath)
        {
            string skillGainFilePath = Path.Combine(filePath, "information.txt");
            if (File.Exists(skillGainFilePath))
            {
                try
                {
                    string temp = File.ReadAllText(skillGainFilePath);
                    string[] parts = temp.Split('*');
                    purpose.Text = parts[0];
                    level.Text = parts[1];
                    requireLevel.Text = parts[2];
                    timeComplete.Text = parts[3];
                    schedule.Text = parts[4];
                    noteSchedule.Text = parts[5];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading skill gain file: " + ex.Message);
                }
            }
            else
            {
            }
        }
        public void learnLabelFromFile(string filePath)
        {
            string skillGainFilePath = Path.Combine(filePath, "learn.txt");
            if (File.Exists(skillGainFilePath))
            {
                try
                {
                    learnLbl.Text = File.ReadAllText(skillGainFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading skill gain file: " + ex.Message);
                }
            }
            else
            {
                learnLbl.Text = "Skill gain file not found.";
            }
        }
        public void gainLabelFromFile(string filePath)
        {
            string skillGainFilePath = Path.Combine(filePath, "skillgain.txt");
            if (File.Exists(skillGainFilePath))
            {
                try
                {
                    gainLbl.Text = File.ReadAllText(skillGainFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading skill gain file: " + ex.Message);
                }
            }
            else
            {
                gainLbl.Text = "Skill gain file not found.";
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, e);
        }

        private void enrollBtn_Click(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines("D:\\university\\cs526\\data\\user\\info.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split('*');
                int id = int.Parse(parts[0]);
                string accountName = parts[1];
                string email = parts[2];
                string password = parts[3];
                string userName = parts[4];
                string avaPath = parts[5];
                if (currentUsr == accountName)
                {
                    currentID = id;
                }
            }

            string content = "";
            string filePath = "D:\\university\\cs526\\data\\user\\trackCourse\\" + currentID +"_"+ currentNameCourse + ".txt";
            try
            {
                if (!File.Exists(filePath))
                {
                    using (FileStream fs = File.Create(filePath))
                    {
                    }
                    enrollBtn.Text = "Enrolled";
                    enrollBtn.BackColor = Color.DimGray;
                }
            }
            catch (Exception ex) { }
        }
    }
}

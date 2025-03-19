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
    public partial class done : UserControl
    {
        private Main mainForm;
        private DataTable homeCourses;
        string fileHomeCoursePath = "D:\\university\\cs526\\data\\courses\\homeCourse.txt";
        string currentUsr = "";
        int currentID = -1;
        public done(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        public done()
        {
            InitializeComponent();
            LoadHomeCourses();
        }

        public done(string currentUsername)
        {
            InitializeComponent();
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
                if (currentUsername == accountName)
                {
                    currentID = id;
                }
            }
            currentUsr = currentUsername;
            LoadHomeCourses();
        }

        private void LoadHomeCourses()
        {
            flowLayoutPanel1.Controls.Clear();
            homeCourses = Course.Courses;
            for (int i = 0; i < homeCourses.Rows.Count; i++)
            {
                DataRow row = homeCourses.Rows[i];
                int id = (int)row["ID"];
                string nameCourse = (string)row["courseName"];
                string nameOrg = (string)row["organization"];
                string courseImgPath = (string)row["imgCourse"];
                string orgImgPath = (string)row["imgOrg"];
                string filePath = "D:\\university\\cs526\\data\\user\\trackCourse\\" + currentID + "_" + nameCourse + ".txt";
                int maxID = 0;
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('*');
                        int currentID = int.Parse(parts[0]);
                        if (maxID < currentID)
                        {
                            maxID = currentID;
                        }
                    }
                    string coursePath = "D:\\university\\cs526\\data\\courses\\" + nameCourse + "\\" + "courseDetails.txt";
                    string[] lines2 = File.ReadAllLines(coursePath);
                    if (lines.Length == lines2.Length)
                    {
                        doneCourse done = new doneCourse();
                        done.content(nameCourse, nameOrg, courseImgPath, currentUsr);
                        done.reviewClicked += (sender, e) => ShowCourseDetail(id, nameCourse, nameOrg, courseImgPath, orgImgPath, currentUsr);
                        flowLayoutPanel1.Controls.Add(done);
                    }
                }
            }
        }

        private void ShowCourseDetail(int id, string nameCourse, string nameOrd, string courseImgPath, string orgImgPath, string currentUsr)
        {
            flowLayoutPanel1.Controls.Clear();
            reviewDetail rd = new reviewDetail();
            rd.content(currentUsr, nameCourse);
            rd.BackButtonClicked += BackBtn_Click;
            flowLayoutPanel1.Controls.Add(rd);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadHomeCourses();
        }
    }
}

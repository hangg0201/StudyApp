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
    public partial class progress : UserControl
    {
        private Main mainForm;
        private DataTable homeCourses;
        string fileHomeCoursePath = "D:\\university\\cs526\\data\\courses\\homeCourse.txt";
        string currentUsr = "";
        int currentID = -1;
        
        public progress(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        public progress()
        {
            InitializeComponent();
            LoadHomeCourses();
        }

        public progress(string currentUsername)
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
                if (File.Exists(filePath))
                {
                    progressCourse pc = new progressCourse();
                    pc.content(nameCourse, nameOrg, courseImgPath, orgImgPath, currentUsr, filePath);
                    pc.courseClicked += (sender, e) => ShowCourseDetail(id, nameCourse, nameOrg, courseImgPath, orgImgPath, currentUsr);
                    flowLayoutPanel1.Controls.Add(pc);
                }

            }
        }

        private void ShowCourseDetail(int id, string nameCourse, string nameOrd, string courseImgPath, string orgImgPath, string currentUsr)
        {
            flowLayoutPanel1.Controls.Clear();
            courseProcess courseProcess = new courseProcess(currentUsr);
            string filePath = "D:\\university\\cs526\\data\\user\\trackCourse\\" + currentID + "_" + nameCourse + ".txt";
            courseProcess.content(nameCourse, filePath);
            courseProcess.BackButtonClicked += BackBtn_Click;
            flowLayoutPanel1.Controls.Add(courseProcess);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadHomeCourses();
        }
    }
}

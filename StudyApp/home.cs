using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyApp
{
    public partial class home : UserControl
    {
        private Main mainForm;
        private DataTable homeCourses;
        string fileHomeCoursePath = "D:\\university\\cs526\\data\\courses\\homeCourse.txt";
        string currentUsr = "";

        public home(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }


        public home(string currentUsername)
        {
            InitializeComponent();
            currentUsr = currentUsername;
            LoadHomeCourses();
        }

        public home()
        {
            InitializeComponent();
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
                homeCourse hc = new homeCourse();
                hc.content(nameCourse, nameOrg, courseImgPath, orgImgPath, currentUsr);
                hc.courseClicked += (sender, e) => ShowCourseDetail(id, nameCourse, nameOrg, courseImgPath, orgImgPath, currentUsr);
                flowLayoutPanel1.Controls.Add(hc);
            }
        }

        private void ShowCourseDetail(int id, string nameCourse, string nameOrd, string courseImgPath, string orgImgPath, string currentUsr)
        {
            if (string.IsNullOrEmpty(currentUsr))
            {
                MessageBox.Show("currentUsr is empty or null");
                return;
            }
            flowLayoutPanel1.Controls.Clear();
            courseDetail courseDetail = new courseDetail(currentUsr);
            courseDetail.content(nameCourse, nameOrd, courseImgPath);
            courseDetail.BackButtonClicked += BackBtn_Click;
            flowLayoutPanel1.Controls.Add(courseDetail);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadHomeCourses();
        }
    }
}

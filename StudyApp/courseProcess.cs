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
    public partial class courseProcess : UserControl
    {
        public event EventHandler BackButtonClicked;
        string currentUsr = "";
        int currentID = -1;
        string currentNameCourse = "";
        string currentLesson = "";
        private videoDetail currentVideoDetail;
        int currentLessonID = -1;
        string trackCoursePath = "";
        private string[] courseLines;
        public courseProcess()
        {
            InitializeComponent();
        }

        public courseProcess(string usr)
        {
            InitializeComponent();
            currentUsr = usr;
        }

        bool checkCompletedID(int lessonID)
        {
            string[] lines = File.ReadAllLines(trackCoursePath);
            foreach(string line in lines)
            {
                string[] parts = line.Split('*');
                if (parts.Length < 2) continue;
                int ID = int.Parse(parts[0]);
                if(ID == lessonID)
                {
                    return true;
                }
            }
            return false;
        }

        void LoadLesson(int lessonID)
        {
            currentID = lessonID;
            string[] parts = courseLines[currentID].Split('*');
            string lessonName = parts[2];
            string currentType = parts[1];
            string currentFilePath = parts[3];
            lessonLbl.Text = lessonName;
            viewDetailPn.Controls.Clear();
            currentLessonID = currentID;
            if (currentVideoDetail != null)
            {
                currentVideoDetail.Stop();
            }
            if (currentType == "video")
            {
                videoDetail videoDetails = new videoDetail();
                videoDetails.content(currentFilePath);
                videoDetails.NextButtonClicked += Details_NextButtonClicked;
                if (!checkCompletedID(lessonID))
                {
                    videoDetails.VideoCompleted += DetailsCompleted;
                }
                else
                {
                    videoDetails.completed();
                }
                currentVideoDetail = videoDetails;
                viewDetailPn.Controls.Add(videoDetails);
            }
            else if (currentType == "reading")
            {
                readingDetails readingDetails = new readingDetails();
                readingDetails.content(currentFilePath, lessonName);
                readingDetails.NextButtonClicked += Details_NextButtonClicked;
                if (!checkCompletedID(lessonID))
                {
                    readingDetails.ReadingCompleted += DetailsCompleted;
                }
                else
                {
                    readingDetails.completed();
                }
                viewDetailPn.Controls.Add(readingDetails);
            }
            else
            {
                quizDetail quizDetail = new quizDetail();
                quizDetail.content(currentFilePath, lessonName);
                quizDetail.NextButtonClicked += Details_NextButtonClicked;
                if (!checkCompletedID(lessonID))
                {
                    quizDetail.QuizCompleted += DetailsCompleted;
                }
                else
                {
                    quizDetail.completed();
                }
                viewDetailPn.Controls.Add(quizDetail);
            }
        }

        public void content(string nameCourse, string trackCoursePaths)
        {
            string coursePath = "D:\\university\\cs526\\data\\courses\\" + nameCourse + "\\courseDetails.txt";
            trackCoursePath = trackCoursePaths;
            courseLines = File.ReadAllLines(coursePath);
            string[] lines = File.ReadAllLines(trackCoursePaths);
            currentID = 0;
            currentNameCourse = nameCourse;
            LoadLesson(currentID < 0 ? 0 : currentID);
            courseLbl.Text = nameCourse;
            LoadCoursePn();
        }

        public void Details_NextButtonClicked(object sender, EventArgs e)
        {
            if (currentVideoDetail != null)
            {
                currentVideoDetail.Stop();
            }
            if (currentID + 1 < courseLines.Length)
            {
                LoadLesson(currentID + 1);
            }
            else
            {
                MessageBox.Show("This is the last lesson.");
            }
        }

        void LoadCoursePn()
        {
            string coursePath = "D:\\university\\cs526\\data\\courses\\" + currentNameCourse + "\\courseDetails.txt";
            courseLines = File.ReadAllLines(coursePath);
            coursePn.Controls.Clear();
            foreach (string line in courseLines)
            {
                string[] parts = line.Split('*');
                int id = int.Parse(parts[0]);
                string type = parts[1];
                string lessonName = parts[2];
                string time = parts[4];
                string filePath = parts[3];
                string[] trackLines = File.ReadAllLines(trackCoursePath);
                videoDetailsProgress vdp = new videoDetailsProgress();
                vdp.courseClicked += (sender, e) => ShowCourseDetail(id, lessonName, filePath, type);
                vdp.content(lessonName, time, type);
                foreach (string line2 in trackLines)
                {
                    string[] parts2 = line2.Split('*');
                    if (parts2[0] == parts[0])
                    {
                        vdp.changeCompleted();
                        break;
                    }
                }
                coursePn.Controls.Add(vdp);
            }
        }

        private void DetailsCompleted(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(trackCoursePath);
            foreach(string line in lines)
            {
                string[] parts = line.Split('*');
                int ID = int.Parse(parts[0]);
                if (ID == currentLessonID)
                {
                    return;
                }
            }    
            string coursePath = "D:\\university\\cs526\\data\\courses\\" + currentNameCourse + "\\courseDetails.txt";
            lines = File.ReadAllLines(coursePath);
            foreach(string line in lines)
            {
                string[] parts = line.Split('*');
                int ID = int.Parse(parts[0]);
                if(ID == currentLessonID)
                {
                    using (StreamWriter sw = File.AppendText(trackCoursePath))
                    {
                        sw.WriteLine(line);
                    }
                    break;
                }
            }
            LoadCoursePn();

        }

        private void ShowCourseDetail(int id, string lessonName, string filePath, string type)
        {
            currentID = id;
            viewDetailPn.Controls.Clear();
            lessonLbl.Text = lessonName;
            currentLessonID = currentID;
            if (currentVideoDetail != null)
            {
                currentVideoDetail.Stop();
            }
            if (type == "video")
            {
                videoDetail videoDetails = new videoDetail();
                videoDetails.content(filePath);
                videoDetails.NextButtonClicked += Details_NextButtonClicked;
                if (!checkCompletedID(id))
                {
                    videoDetails.VideoCompleted += DetailsCompleted;
                }else
                {
                    videoDetails.completed();
                }
                currentVideoDetail = videoDetails;
                viewDetailPn.Controls.Add(videoDetails);
            }
            else if (type == "reading")
            {
                readingDetails readingDetails = new readingDetails();
                readingDetails.content(filePath, lessonName);
                readingDetails.NextButtonClicked += Details_NextButtonClicked;
                if (!checkCompletedID(id))
                {
                    readingDetails.ReadingCompleted += DetailsCompleted;
                }
                else
                {
                    readingDetails.completed();
                }
                viewDetailPn.Controls.Add(readingDetails);
            }
            else
            {
                quizDetail quizDetail = new quizDetail();
                quizDetail.content(filePath, lessonName);
                quizDetail.NextButtonClicked += Details_NextButtonClicked;
                if (!checkCompletedID(id))
                {
                    quizDetail.QuizCompleted += DetailsCompleted;
                }
                else
                {
                    quizDetail.completed();
                }
                viewDetailPn.Controls.Add(quizDetail);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, e);
            if (currentVideoDetail != null)
            {
                currentVideoDetail.Stop();
            }
        }



    }
}

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
    public partial class quizDetail : UserControl
    {
        public event EventHandler NextButtonClicked;
        public event EventHandler QuizCompleted;
        string currentLesson = "";
        string currentFilePath = "";
        public quizDetail()
        {
            InitializeComponent();
            nextBtn.Visible = false;
            checkPic.Visible = false;
            checkLbl.Visible = false;
            scoreLbl.Visible = false;
            label2.Visible = false;
            retryBtn.Visible = false;
        }

        public void content(string filePath, string lessonName)
        {
            flowLayoutPanel1.Controls.Clear();
            quizLbl.Text = lessonName;
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split('*');
                if (parts.Length == 1)
                {
                    fillinanswer f = new fillinanswer();
                    f.content(parts[0]);
                    flowLayoutPanel1.Controls.Add(f);
                }else if (parts[parts.Length - 1] == "E")
                {
                    multipleselectchoice choice = new multipleselectchoice();
                    choice.content(parts);
                    flowLayoutPanel1.Controls.Add(choice);
                }
                else
                {
                    multiplechoice multiplechoice = new multiplechoice();
                    multiplechoice.content(parts);
                    flowLayoutPanel1.Controls.Add(multiplechoice);
                }
            }
            currentFilePath = filePath.Split('\\')[5];
            currentLesson = lessonName;
            string scoreFilePath = "D:\\university\\cs526\\data\\courses\\" + currentFilePath + "\\score\\" + currentLesson + ".txt";
            lines = File.ReadAllLines(scoreFilePath);
            if(lines.Length == 0)
            {
                return;
            }
            scoreLbl.Text = lines[0];
        }

        private void GradeQuiz()
        {
            int totalQuestions = 0;
            int answeredQuestions = 0;
            int correctAnswers = 0;
            foreach(Control control in flowLayoutPanel1.Controls)
            {
                if (control is fillinanswer)
                {
                    fillinanswer f = (fillinanswer)control;
                    if (f.isAnswered())
                    {
                        answeredQuestions++;
                        if (f.isCorrect())
                        {
                            correctAnswers++;
                        }
                    }
                    totalQuestions++;
                }
                else if (control is multipleselectchoice)
                {
                    multipleselectchoice msc = (multipleselectchoice)control;
                    if (msc.isAnswered())
                    {
                        answeredQuestions++;
                        if (msc.isCorrect())
                        {
                            correctAnswers++;
                        }
                    }
                    totalQuestions++;
                }
                else if (control is multiplechoice)
                {
                    multiplechoice mc = (multiplechoice)control;
                    if (mc.isAnswered())
                    {
                        answeredQuestions++;
                        if (mc.isCorrect())
                        {
                            correctAnswers++;
                        }
                    }
                    totalQuestions++;
                }
            }
            if (answeredQuestions < totalQuestions)
            {
                MessageBox.Show("Xin vui lòng trả lời hết tất cả các câu hỏi trước khi nộp bài!", "Bài kiểm tra chưa hoàn thành!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            nextBtn.Visible = true;
            checkPic.Visible = true;
            checkLbl.Visible = true;
            double score = (double)correctAnswers / totalQuestions * 100;
            string scoreString = Math.Round(score, 2).ToString("F2");
            string scoreFilePath = "D:\\university\\cs526\\data\\courses\\" + currentFilePath + "\\score\\" + currentLesson + ".txt";
            using (StreamWriter sw = new StreamWriter(scoreFilePath, false))
            {
                sw.WriteLine(scoreString);
            }
            if (score < 60)
            {
                retryBtn.Visible = true;
            }
            else
            {
                QuizCompleted?.Invoke(this, EventArgs.Empty);   
            }
            scoreLbl.Text = scoreString;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            scoreLbl.Visible = true;
            label2.Visible = true;
            GradeQuiz();
        }

        public void completed()
        {
            submitBtn.Visible = false;
            nextBtn.Visible = true;
            checkLbl.Visible = true;
            checkPic.Visible = true;
            retryBtn.Visible = true;
            label2.Visible=true;
            scoreLbl.Visible=true;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            NextButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void retryBtn_Click(object sender, EventArgs e)
        {
            retryBtn.Visible = false;
            submitBtn.Visible = true;
            nextBtn.Visible = false;
            checkLbl.Visible = false;
            checkPic.Visible = false;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is fillinanswer)
                {
                    fillinanswer f = (fillinanswer)control;
                    f.Reset();
                }
                else if (control is multipleselectchoice)
                {
                    multipleselectchoice msc = (multipleselectchoice)control;
                    msc.Reset();
                }
                else if (control is multiplechoice)
                {
                    multiplechoice mc = (multiplechoice)control;
                    mc.Reset();
                }
            }
        }
    }
}

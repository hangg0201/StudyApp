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
    public partial class readingDetails : UserControl
    {
        public event EventHandler NextButtonClicked;
        public event EventHandler ReadingCompleted;


        public readingDetails()
        {
            InitializeComponent();
            checkLbl.Visible = false;
            checkPic.Visible = false;
            nextBtn.Visible = false;
        }

        public void content(string filePath, string lessonName)
        {
            string fileContent = File.ReadAllText(filePath);
            readingTxt.Text = fileContent;
            readingLbl.Text = lessonName;
        }

        private void completedBtn_Click(object sender, EventArgs e)
        {
            checkLbl.Visible = true;
            checkPic.Visible = true;
            completedBtn.Visible = false;
            nextBtn.Visible = true;
            ReadingCompleted?.Invoke(this, EventArgs.Empty);
        }

        public void completed()
        {
            completedBtn.Visible = false;
            nextBtn.Visible= true;
            checkLbl.Visible = true;
            checkPic.Visible= true;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            NextButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

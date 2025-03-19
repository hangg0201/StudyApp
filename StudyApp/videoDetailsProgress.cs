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
    public partial class videoDetailsProgress : UserControl
    {
        public event EventHandler courseClicked;
        public videoDetailsProgress()
        {
            InitializeComponent();
            picType.BackgroundImage = Image.FromFile("D:\\university\\cs526\\data\\icon\\video.png");
            this.Click += courseClick;
        }

        public void content(string lessonName, string time, string type)
        {
            lessonLbl.Text = lessonName;
            timeLbl.Text = time;
            typeLbl.Text = char.ToUpper(type[0]) + type.Substring(1).ToLower(); ;
            if (type == "reading")
            {
                picType.BackgroundImage = Image.FromFile("D:\\university\\cs526\\data\\icon\\book.png");
            }
            else if (type == "video")
            {
                picType.BackgroundImage = Image.FromFile("D:\\university\\cs526\\data\\icon\\video.png");
            }
            else
            {
                picType.BackgroundImage = Image.FromFile("D:\\university\\cs526\\data\\icon\\quiz.png");
            }
        }

        private void courseClick(object sender, EventArgs e)
        {
            courseClicked?.Invoke(this, e);
        }

        public void changeCompleted()
        {
            picType.BackgroundImage = Image.FromFile("D:\\university\\cs526\\data\\icon\\greentick.png");
        }
    }
}

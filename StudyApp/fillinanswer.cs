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
    public partial class fillinanswer : UserControl
    {
        public fillinanswer()
        {
            InitializeComponent();
        }

        public void content(string question)
        {
            questionLbl.Text = question;
        }
        public bool isCorrect()
        {
            return !string.IsNullOrWhiteSpace(richTextBox1.Text);
        }

        public bool isAnswered()
        {
            return !string.IsNullOrWhiteSpace(richTextBox1.Text);
        }

        public void Reset()
        {
            richTextBox1.Text = "";
        }
    }
}

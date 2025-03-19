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
    public partial class multiplechoice : UserControl
    {
        private string correctAnswer;
        public multiplechoice()
        {
            InitializeComponent();
        }

        public void content(string[] parts)
        {
            string question = parts[0];
            label1.Text = question;
            int answer = int.Parse(parts[parts.Length - 1]);
            correctAnswer = parts[answer];
            radioButton1.Text = parts[1];
            radioButton2.Text = parts[2];
            if (parts.Length == 4)
            {
                radioButton3.Visible = false;
                radioButton4.Visible = false;
            }
            if (parts.Length  == 5)
            {
                radioButton3.Text = parts[3];
                radioButton4.Visible = false;
            }else if(parts.Length == 6)
            {
                radioButton3.Text = parts[3];
                radioButton4.Text = parts[4];
            }
        }

        public bool isCorrect()
        {
            if (radioButton1.Checked && radioButton1.Text == correctAnswer) return true;
            if (radioButton2.Checked && radioButton2.Text == correctAnswer) return true;
            if (radioButton3.Checked && radioButton3.Text == correctAnswer) return true;
            if (radioButton4.Checked && radioButton4.Text == correctAnswer) return true;
            return false;
        }

        public bool isAnswered()
        {
            return radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked;
        }

        public void Reset()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
    }
}

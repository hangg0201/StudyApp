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
    public partial class multipleselectchoice : UserControl
    {
        private List<string> correctAnswers = new List<string>();
        public multipleselectchoice()
        {
            InitializeComponent();
        }

        public void content(string[] parts)
        {
            string question = parts[0];
            label1.Text = question;
            string[] answer = parts[parts.Length - 2].Split('_');
            foreach (string ans in answer)
            {
                int indexAns = int.Parse(ans);
                string correct = parts[indexAns];
                correctAnswers.Add(correct);
            }
            for(int i = 1; i < parts.Length - 2; i++)
            {
                checkedListBox1.Items.Add(parts[i]);
            }
        }

        public bool isCorrect()
        {
            List<string> selectedItems = new List<string>();
            foreach (object item in checkedListBox1.CheckedItems)
            {
                selectedItems.Add(item.ToString());
            }
            if (selectedItems.Count != correctAnswers.Count)
                return false;

            foreach (string answer in correctAnswers)
            {
                if (!selectedItems.Contains(answer))
                    return false;
            }

            return true;
        }

        public bool isAnswered()
        {
            return checkedListBox1.CheckedItems.Count > 0;
        }

        public void Reset()
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }
    }
}

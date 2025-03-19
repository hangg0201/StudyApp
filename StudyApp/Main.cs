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
    public partial class Main : Form
    {
        string fileHomeCoursePath = "D:\\university\\cs526\\data\\courses\\homeCourse.txt";
        private DataTable courses = new DataTable();
        int currentID = 0;
        string currentUsr = "";

        public Main(string currentUserName)
        {
            InitializeComponent();
            currentUsr = currentUserName;
            homeBtn.BackColor = Color.WhiteSmoke;
            home homeControl = new home(currentUserName);
            mainPanel.Controls.Add(homeControl);
            string[] lines = File.ReadAllLines("D:\\university\\cs526\\data\\user\\info.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split('*');
                int id = int.Parse(parts[0]);
                string accountName =  parts[1];
                string email = parts[2];
                string password = parts[3];
                string userName = parts[4];
                string avaPath = parts[5];
                if (currentUserName == accountName)
                {
                    currentID = id;
                    name.Text = userName;
                    picAva.BackgroundImage = Image.FromFile(avaPath);
                }
            }
        }
        public Main()
        {
            InitializeComponent();
            homeBtn.BackColor = Color.WhiteSmoke;
            home homeControl = new home();
            mainPanel.Controls.Add(homeControl);
        }

        private void LoadHomeCourseFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

        }

        private void ResetButton()
        {
            homeBtn.BackColor = Color.White;
            progressBtn.BackColor = Color.White;
            doneBtn.BackColor = Color.White;
            profileBtn.BackColor = Color.White;
            logoutBtn.BackColor = Color.White;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ResetButton();
            homeBtn.BackColor = Color.WhiteSmoke;
            home homeControl = new home(currentUsr);
            mainPanel.Controls.Add(homeControl);
        }

        private void progressBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ResetButton();
            progressBtn.BackColor = Color.WhiteSmoke;
            progress progressControl = new progress(currentUsr);
            mainPanel.Controls.Add(progressControl);
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ResetButton();
            done doneControl = new done(currentUsr);
            mainPanel.Controls.Add(doneControl);
            doneBtn.BackColor= Color.WhiteSmoke;
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            profileDetail pd = new profileDetail(currentUsr);
            mainPanel.Controls.Add(pd);
            ResetButton();
            profileBtn.BackColor = Color.WhiteSmoke;
        }


        private void logoutBtn_Click(object sender, EventArgs e)
        {
            ResetButton();
            logoutBtn.BackColor = Color.WhiteSmoke;
            SignInForm formSignIn = new SignInForm();
            formSignIn.Show();
            this.Hide();
        }
    }
}

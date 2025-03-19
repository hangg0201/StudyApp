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
    public partial class homeCourse : UserControl
    {
        public event EventHandler courseClicked;
        public homeCourse()
        {
            InitializeComponent();
            this.Click += courseClick;
        }

        
        public void content(string courseName, string orgName, string coursePath, string orgPath, string userName)
        {
            nameCourse.Text = courseName;
            nameOrg.Text = orgName;
            picCourse.BackgroundImage = Image.FromFile(coursePath);
            picOrg.BackgroundImage = Image.FromFile(orgPath);
        }

        private void courseClick(object sender, EventArgs e)
        {
            courseClicked?.Invoke(this, e);
        }
    }
}

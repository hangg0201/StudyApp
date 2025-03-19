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
    public partial class profileAchievement : UserControl
    {
        public profileAchievement()
        {
            InitializeComponent();
        }

        public void content(string course)
        {
            label1.Text = course;
        }
    }
}

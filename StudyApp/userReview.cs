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
    public partial class userReview : UserControl
    {
        public userReview()
        {
            InitializeComponent();
        }

        public void content(string name, string star, string comment, string ava)
        {
            nameLbl.Text = name;
            starLbl.Text = star;
            contentLbl.Text = comment;
            avaPic.BackgroundImage = Image.FromFile(ava);
        }
    }
}

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
    public partial class reviewSmall : UserControl
    {
        public reviewSmall()
        {
            InitializeComponent();
        }

        public void content(string userName, string star, string content)
        {
            nameLbl.Text = userName;
            starLbl.Text = star;
            reviewLbl.Text = content;
        }
    }
}

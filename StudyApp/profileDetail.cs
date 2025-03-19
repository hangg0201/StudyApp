using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyApp
{
    public partial class profileDetail : Component
    {
        public profileDetail()
        {
            InitializeComponent();
        }

        public profileDetail(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}

using Microsoft.Reporting.WinForms;
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
    public partial class certificateForm : Form
    {
        string currentName = "";
        string currentMail = "";
        string currentCourse = "";
        public certificateForm()
        {
            InitializeComponent();
        }

        public certificateForm(string name, string email, string course)
        {
            InitializeComponent();
            currentName = name;
            currentMail = email;
            currentCourse = course;
        }

        private void certificateForm_Load(object sender, EventArgs e)
        {

            reportViewer2.ProcessingMode = ProcessingMode.Local;
            reportViewer2.SetDisplayMode(DisplayMode.Normal);
            reportViewer2.ZoomMode = ZoomMode.Percent;
            reportViewer2.ZoomPercent = 100;

            reportViewer2.LocalReport.ReportPath = "C:\\Users\\COMPUTER\\source\\repos\\StudyApp\\StudyApp\\cert.rdlc";
            ReportParameterCollection parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("nameLbl", currentName));
            parameters.Add(new ReportParameter("emailLbl", currentMail));
            parameters.Add(new ReportParameter("courseLbl", currentCourse));
            reportViewer2.LocalReport.SetParameters(parameters);
            this.reportViewer2.RefreshReport();
        }
    }
    public class CertificateData
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
    }
}

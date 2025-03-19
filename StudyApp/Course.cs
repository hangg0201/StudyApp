using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudyApp
{
    internal class Course
    {
        public static DataTable Courses { get; private set; } = new DataTable();

        static Course()
        {
            Courses.Columns.Add("ID", typeof(int));
            Courses.Columns.Add("courseName", typeof(string));
            Courses.Columns.Add("organization", typeof(string));
            Courses.Columns.Add("imgCourse", typeof(string));
            Courses.Columns.Add("imgOrg", typeof(string));
            string[] lines = File.ReadAllLines("D:\\university\\cs526\\data\\courses\\homeCourse.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split('*');
                int id = int.Parse(parts[0]);
                string courseName = parts[1];
                string orgName = parts[2];
                string imgCourse = parts[3];
                string imgOrg = parts[4];
                Courses.Rows.Add(id, courseName, orgName, imgCourse, imgOrg);
            }
        }
    }
}

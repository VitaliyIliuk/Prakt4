using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Student:Applicant
    {
        string group { get; set; }
        int course { get; set; }
        string faculty { get; set; }
        string college { get; set; }
        public void setgroup(string group) { this.group = group; }
        public void setfaculty(string faculty) { this.faculty = faculty; }
        public void setcollege(string college) { this.college = college; }
        public void setcourse(int course) { this.course = course; }
        public int getcourse() { return course; }
        public string getgroup() { return group; }
        public string getfaculty() { return faculty; }
        public string getcollege() { return college; }
        Student()
        {
            group = "";
            course = 0;
            faculty = "";
            college = "";
        }
        Student(string group, int course, string faculty, string college, int zno, int bso, string zaklad, string name, string sourName, string data)
            : base(zno, bso, zaklad, name, sourName, data)
        {
            this.group = group;
            this.course = course;
            this.faculty = faculty;
            this.college = college;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Course: {course}\nGroup: {group}\nFaculty: {faculty}\nCollege: {college}");
        }
    }
}

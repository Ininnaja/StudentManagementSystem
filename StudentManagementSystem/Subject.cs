using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class Subject
    {
        //field
        private string subjectName;
        private double grade;

        public string SubjectName { get => subjectName; set => subjectName = value; }
        public double Grade { get => grade; set => grade = value; }

        //constructor
        public Subject(string subjectName, double grade)
        {
            this.SubjectName = subjectName;
            this.Grade = grade;
        }

        
    }
}

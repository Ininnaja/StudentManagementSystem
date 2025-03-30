using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class Student
    {
        //feild ในนักเรียนเก็บข้อมูลดังนี้
        private string name;
        private int age;
        private List<Subject> subjects;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        internal List<Subject> Subjects { get => subjects; set => subjects = value; }

        //constructor รับข้อมูลมาเก็ยในตัวแปรที่สร้างไว้
        public Student(string name,int age)
        {
            this.Name = name;
            this.Age = age;
            Subjects = new List<Subject>();
            //showdata();
            //avgScoreSub();
            //Console.WriteLine();
        }

        //method 
        public void showdata()
        {
            Console.WriteLine("Student name : "+Name+" age : "+Age);       
        }
        public void showSubject()
        {
            Console.WriteLine("Subjects in the list:");
            foreach (var i in subjects)
            {
                Console.WriteLine("subject name : " + i.SubjectName + " Grade : " + i.Grade);
            }
        }

        //method คำนวณคะแนนเฉลี่ยของนักเรียนจากหลายวิชา
        public void avgScoreSub()
        {
            if (Subjects.Count != 0)
            {
                double avgScore = Subjects.Average(x => x.Grade);
                Console.WriteLine("Your average scores = " + avgScore);
            }
            else
            {
                Console.WriteLine("Nor found Information");
            }
            Console.WriteLine();
        }
    }
}

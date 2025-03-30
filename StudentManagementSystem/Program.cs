// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using StudentManagementSystem;

//รายชื่อนักเรียนที่มี
List<Student> students = new List<Student>()
        {
            new Student("Inthira", 21),
            new Student("Mark", 25),
            new Student("Preeda",16)
        };

// เพิ่มข้อมูลแบบกำหนดเอง
students[1].Subjects.Add(new Subject("Math", 85));
students[1].Subjects.Add(new Subject("Music", 76));
students[1].Subjects.Add(new Subject("English", 95));


//menu
do
{
    int menu;
    Console.WriteLine("------------ Student Information ------------");
    Console.WriteLine("Press 1 to view student information");
    Console.WriteLine("Press 2 to fill in student information");
    Console.WriteLine("Press 3 to add a students subject");
    Console.Write("Plaese choose Menu : ");
    int.TryParse(Console.ReadLine(), out menu);

    if (menu == 1)
    {
        foreach (var i in students)
        {
            i.showdata();
            i.showSubject();
            i.avgScoreSub();
        }
    }
    else if (menu == 2)
    {
        int Age;
        Console.Write("Enter New Student name : ");
        string Name = Console.ReadLine();
        Console.Write("Enter New Student age : ");
        int.TryParse(Console.ReadLine(),out Age);

        if (Age <= 0)
        {
            Console.WriteLine("Incorrect age please try again");
        }
        else
        {
            students.Add(new Student(Name, Age));
            Console.WriteLine("Successfully added students");
        }
        
    }
    else if (menu == 3)
    {
        //รับค่าชื่อมา
        Console.Write("Enter Student name : ");
        string Namefind = Console.ReadLine();

        var findstudent = students.Find(x => x.Name == Namefind);
        if (findstudent == null)
        {
            Console.WriteLine("Not found student name is : "+Namefind);
        }
        else
        {
            Console.WriteLine("Edit student name is "+Namefind);
            //เก็บคะแนน
            double Grade;
            int s;
            do
            {
                Console.Write("Enter Subject name (or finish please enter (exit) : ");
                string SubjectName = Console.ReadLine();
                if (SubjectName == "exit")
                {
                    break;
                }

                Console.Write("Enter Score of subject : ");
                double.TryParse(Console.ReadLine(), out Grade);
                if (Grade < 0 || Grade > 100)
                {
                    Console.WriteLine("have mistake because grade between 0 - 100");
                    continue;
                }

                findstudent.Subjects.Add(new Subject(SubjectName, Grade));
                

            } while (true);
            findstudent.showSubject();
            findstudent.avgScoreSub();
        }

    }
    else
    {
        Console.WriteLine("Please try again");
    }
} while(true);



Console.ReadKey();
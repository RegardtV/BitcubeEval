using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //tester code
            Lecturer lect001 = new Lecturer();
            lect001.Forenames = "Paul Johan";
            lect001.Surname = "Cilliers";
            lect001.EmailAddress = "pcill@sun.ac.za";
            lect001.DateOfBirth = new DateTime(1971, 10, 18);
            Console.WriteLine($"Lecturer 001 full name: {lect001.Fullname}, email: {lect001.EmailAddress}, date of birth: {lect001.DateOfBirth.Date.ToString("d")}");

            Degree BPhil = new Degree();
            BPhil.Name = "Bacholor of Philosophy";
            BPhil.Duration = 3;
            BPhil.LecturerAssigned = lect001;
            Console.WriteLine($"Degree name: {BPhil.Name}, Degree duration: {BPhil.Duration} years, Assigned Lectuer: {BPhil.LecturerAssigned.Fullname}");
        

            Student stud001 = new Student();
            stud001.Forenames = "Regardt Hugo";
            stud001.Surname = "Visagie";
            stud001.EmailAddress = "regardtvisagie@gmail.com";
            stud001.DateOfBirth = new DateTime(1984, 05, 29);
            stud001.DegreeEnrolled = BPhil;
            Console.WriteLine($"Student 001 first name: {stud001.Firstname}");

            Course phil101 = new Course();
            phil101.Name = "Introduction to Philosophy";
            phil101.Duration = 4;
            phil101.DegreeAssigned = BPhil;
            Console.WriteLine($"Course name: {phil101.Name}, Course duration: {phil101.Duration} Months");

            Student stud002 = new Student("Desmond Moagimang", "Serape", "dmserape@yahoo.com", new DateTime(2002,01,14), BPhil);
            Student stud003 = new Student("John Mattison", "Cloete", "johntheguy@hotmail.com", new DateTime(2000, 03, 19), BPhil);

            phil101.addStudent(stud002);
            phil101.addStudent(stud002);
            phil101.addStudent(stud003);

            Course phil103 = new Course("Ancient Greek Philsophy", 6, BPhil);
            phil103.StudentList = phil101.StudentList;
            phil103.removeStudent(stud002);

            Course polSci101 = new Course();
            polSci101.Name = "Introduction to Political Science";
            polSci101.Duration = 4;

            Course polSci201 = new Course();
            polSci201.Name = "20th Century Communism";
            polSci201.Duration = 4;

            List<Course> polSciCourses = new List<Course> { polSci101, polSci201 };

            Degree BPolSci = new Degree("Bachelor of Political Science", 2, lect001, polSciCourses);

            lect001.addDegree(BPhil);
            lect001.addDegree(BPolSci);

            BPhil.addCourse(phil101);
            BPhil.addCourse(phil103);
        }
    }
}

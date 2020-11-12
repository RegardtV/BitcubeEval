using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    abstract class Person
    {
        //properties
        public string Forenames { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Firstname
        {
            get { return Forenames.Substring(0, Forenames.IndexOf(" ")); }
        }
        public string Fullname
        {
            get { return $"{Forenames} {Surname}"; }
        }
        //default constructor
        protected Person() { }
        //paramaterized constructor
        protected Person(string forenames, string surname, string email, DateTime dateofbirth)
        {
            Forenames = forenames;
            Surname = surname;
            EmailAddress = email;
            DateOfBirth = dateofbirth;
        }
    }

    class Student: Person
    {
        //property
        public Degree DegreeEnrolled { get; set; }
        //default constructor
        public Student() { }
        //paramaterized constructor
        public Student(string forenames, string surname, string email, DateTime dateofbirth, Degree degreeenrolled) : base(forenames, surname, email, dateofbirth)
        {
            DegreeEnrolled = degreeenrolled;
        }
        

    }
    
    class Lecturer: Person
    {
        //property
        public List<Degree> DegreeList { get; set; }
        //method for adding a degree to DegreeList  
        public void addDegree(Degree degree)
        {
            DegreeList.Add(degree);
        }
        //method for removing a degree from DegreeList
        public void removeDegree(Degree degree)
        {
            DegreeList.Remove(degree);
        }
        //default constructor
        public Lecturer()
        {
            DegreeList = new List<Degree>();
        }
        //paramaterized constructor
        public Lecturer(string forenames, string surname, string email, DateTime dateofbirth, List<Degree> degreelist) : base(forenames, surname, email, dateofbirth)
        {
            DegreeList = degreelist;
        }

    }
}

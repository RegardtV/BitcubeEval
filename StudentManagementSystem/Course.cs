using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Course
    {
        //properties
        public string Name { get; set; }
        public int Duration { get; set; }
        public Degree DegreeAssigned { get; set; }
        public List<Student> StudentList { get; set; }
        //method for adding a student to StudentList
        public void addStudent(Student student)
        {
            StudentList.Add(student);
        }
        //method for removing a student from StudentList
        public void removeStudent(Student student)
        {
            StudentList.Remove(student);
        }
        //default constructor
        public Course()
        {
            StudentList = new List<Student>();
        }
        //paramaterized constructor
        public Course(string name, int duration, Degree degreeassigned)
        {
            Name = name;
            Duration = duration;
            DegreeAssigned = degreeassigned;
        }
    }
}

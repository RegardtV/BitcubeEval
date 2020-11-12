using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Degree
    {
        //properties
        public string Name { get; set; }
        public int Duration { get; set; }
        public Lecturer LecturerAssigned { get; set; }
        public List<Course> CourseList { get; set; }
        //method for adding a course to CourseList
        public void addCourse(Course course)
        {
            CourseList.Add(course);
        }
        //method for removing a course from CourseList
        public void removeCourse(Course course)
        {
            CourseList.Remove(course);
        }
        //default constructor
        public Degree()
        {
            CourseList = new List<Course>();
        }
        //paramaterized constructor
        public Degree(string name, int duration, Lecturer lecturer, List<Course> courselist)
        {
            Name = name;
            Duration = duration;
            LecturerAssigned = lecturer;
            CourseList = courselist;
        }
    }
}

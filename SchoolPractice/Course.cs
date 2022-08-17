using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public Student[] Students { get; set; }
        public Course(string name, Teacher teacher, Student[] students)
        {
            Name = name;
            Teacher = teacher;
            Students = students;
        }
    }
}

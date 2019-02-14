////////////////////////////////////////////////////////////////////////////////
/// Change History
/// Developer   Date    Description
/// Laurie      2/3     Added getters and setters for objects displayed on homepage.
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingAsperations.Models
{   //  Here is where the class will identify what objects are on a page.
    //  Once objects have been found, they can be pulled and set.
    public class Course
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int TestId { get; set; }
        public string TestName { get; set; }
        public string TestLink { get; set; }
        public int DueDate { get; set; }
        public int Id { get; internal set; }
    }
}

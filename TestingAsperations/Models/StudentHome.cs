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
    public class StudentHome
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseLink { get; set; }
    }
}

////////////////////////////////////////////////////////////////////////////////
/// Change History
/// Developer   Date    Description
/// Laurie      2/3     Added getters and setters for objects displayed on homepage.
///

/// ************    Interface and mockdata still need to be created.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingAsperations.Models
{   //  Here is where the class will identify what objects are on a page.
    //  Once objects have been found, they can be pulled and set.
    public class Test
    {

        public int TestId { get; set; }
        public int CoursId { get; set; }
        public int Grade { get; set; }
        // If teacher, display a create test click option.
        public bool CreateTestLink { get; set; }   
        // If student, displays take new test click option, if new test exists.
        public bool TakeTestLink { get; set; }
    }
}

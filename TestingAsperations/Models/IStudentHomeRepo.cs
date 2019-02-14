////////////////////////////////////////////////////////////////////////////////
/// Change History
/// Developer   Date    Description
/// Laurie      2/10    Added method calls for courses to load on the homepage.
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingAsperations.Models
{
    public interface IStudentHomeRepo
    {
        //  Call to method for getting the tests
        IEnumerable<StudentHome> GetAllCourses();
        //  Another option for calling a course, may or may not be needed.
        StudentHome GetCourseByID(int CourseId);
    }
}

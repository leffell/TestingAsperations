////////////////////////////////////////////////////////////////////////////////
/// Change History
/// Developer   Date    Description
/// Laurie      2/3     Added method calls for tests to load on the course page.
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingAsperations.Models
{
    public interface ICourseRepo
    {   //  Call to method for getting the tests
        IEnumerable<Course> GetAllTests();
        //  Another option for calling a course, may or may not be needed.
        Course GetTestByID(int TestId);
    }
}

////////////////////////////////////////////////////////////////////////////////
/// Change History
/// Developer   Date    Description
/// Laurie      2/3     Implemented interface methods.
/// Laurie      2/3     Added a method to check for test information.
/// Laurie      2/3     Added method to upload mock test information if there isn't any course information found.
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingAsperations.Models
{
    public class MockCourseRepo : ICourseRepo
    {   //   This is a private list from courses assigned the name _courses
        private List<Course> _tests;

        //  This method checks to see if there is Test data
        //  If there isn't, it uses the mockdata created in the InitializeTest method found below
        public MockCourseRepo()
        {
            if(_tests == null)
            {
                InitializeTest();
            }
        }

        private void InitializeTest()
        {   //  Add MockDataHere
            _tests = new List<Course>
            {
                new Course{Id = 1/*Fill me in*/},
                new Course{/*Fill me in*/},
                new Course{/*Fill me in*/}

            };
        }

        //  This is the method getting all the tests taken and new.
        //  This is probably where the loop should be to check if new test has been created.
        public IEnumerable<Course> GetAllTests()
        {
            return _tests;
        }

        //  This is a method for getting a course by id if the id isn't found or doesn't exist.
        //  Maybe change this, we will see.
        public Course GetTestByID(int TestId)
        {
            return _tests.FirstOrDefault(t => t.Id == TestId);
        }
    }
}

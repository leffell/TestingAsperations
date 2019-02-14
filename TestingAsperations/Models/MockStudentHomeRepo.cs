////////////////////////////////////////////////////////////////////////////////
/// Change History
/// Developer   Date    Description
/// Laurie      2/10    Implemented interface methods.
/// Laurie      2/10    Added a method to check for course information.
/// Laurie      2/10    Added method to upload mock course information if there isn't any course information found.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingAsperations.Models
{
    public class MockStudentHomeRepo : IStudentHomeRepo
    {    //   This is a private list from studenthome assigned the name _courses
        private List<StudentHome> _courses;

        //  This method checks to see if there is course data
        //  If there isn't, it uses the mockdata created in the InitializeCourse method found below
        public MockStudentHomeRepo()
        {
            if (_courses == null)
            {
                InitializeCourse();
            }
        }

        private void InitializeCourse()
        {   //  Add MockDataHere
            _courses = new List<StudentHome>
            {
                new StudentHome{StudentId = 1/*Fill me in*/},
                new StudentHome{/*Fill me in*/},
                new StudentHome{/*Fill me in*/}

            };
        }

        //  This is the method getting all the courses taken.
        //  This is probably where the loop should be to check if new course has been created.
        public IEnumerable<StudentHome> GetAllCourses()
        {
            return _courses;
        }

        //  This is a method for getting a course by id if the id isn't found or doesn't exist.
        //  Maybe change this, we will see.
        public StudentHome GetCourseByID(int CourseId)
        {
            //  If this needs to be changed, refer to pluralsight.
            throw new NotImplementedException();
        }
    }
}

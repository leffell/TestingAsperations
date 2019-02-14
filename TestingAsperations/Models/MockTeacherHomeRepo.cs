////////////////////////////////////////////////////////////////////////////////
/// Change History
/// Developer   Date    Description
/// Laurie      2/10    Implemented interface methods.
/// Laurie      2/10    Added a method to check for course information.
/// Laurie      2/10    Added method to upload mock course information if there isn't any course information found.
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingAsperations.Models
{
    public class MockTeacherHomeRepo : ITeacherHomeRepo
    {
        //   This is a private list from studenthome assigned the name _courses
        private List<TeacherHome> _courses;

        //  This method checks to see if there is course data
        //  If there isn't, it uses the mockdata created in the InitializeCourse method found below
        public MockTeacherHomeRepo()
        {
            if (_courses == null)
            {
                InitializeCourse();
            }
        }

        private void InitializeCourse()
        {   //  Add MockDataHere
            _courses = new List<TeacherHome>
            {
                new TeacherHome{TeacherId = 1, TeacherName = "Sarah", CourseId = 200, CourseName = "Introduction to C#", CourseLink = "A call to the course page."},
                new TeacherHome{TeacherId = 2, TeacherName = "Jessica", CourseId = 300, CourseName = "Introduction to Web Design", CourseLink = "A call to the course page."},
                new TeacherHome{TeacherId = 3, TeacherName = "Zane", CourseId = 220, CourseName = "Introduction to the User Interface", CourseLink = "A call to the course page."}

            };
        }
        //  This is the method getting all the courses taken.
        //  This is probably where the loop should be to check if new course has been created.
        public IEnumerable<TeacherHome> GetAllCourses()
        {
            return _courses;
        }
        //  This is a method for getting a course by id if the id isn't found or doesn't exist.
        //  Maybe change this, we will see.
        public TeacherHome GetCourseByID(int TeacherId)
        {
            //  At this time it just throws an exception error.
            throw new NotImplementedException();
        }
    }
}

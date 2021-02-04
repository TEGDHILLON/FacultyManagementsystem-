using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeginderpalD_301093892.Models
{
    public static class Repository
    {
        private static List<Faculty> addition = new List<Faculty>();

        public static IEnumerable<Faculty> Addition
        {
            get
            {
                return addition;
            }
        }

        public static void AddFaculty(Faculty faculty)
        {
            addition.Add(faculty);
        }

        private static List<Course> enrolled = new List<Course>();

        public static IEnumerable<Course> Enrolled
        {
            get
            {
                return enrolled;
            }
        }

        public static void AddCourse(Course course)
        {
            enrolled.Add(course);
        }
    }
}


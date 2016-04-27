using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Students_by_Group
{
    using System.Collections;
    using System.Text.RegularExpressions;

    using Functional_Programing_Homework;

    public static class StudentsMenager
    {
        public static object[] GetExelentStudents(IList<Student> allStudents)
        {
            var exelentStudents =
                allStudents.Where(s => s.Marks.Contains(6))
                    .Select(s => new { FullName = s.FirstName + " " + s.LastName, Marks = s.Marks })
                    .ToArray();
            Console.WriteLine(string.Join("\n",(object[])exelentStudents));

            return exelentStudents;
        }

        public static object[] GetWeakStudents(IList<Student> allStudents)
        {

            var weakStudents =
                allStudents.Where(s =>Regex.Matches(string.Join("",s.Marks),"2").Count==2)
                    .Select(s => new { FullName = s.FirstName + " " + s.LastName, Marks = s.Marks })
                    .ToArray();
            Console.WriteLine(string.Join("\n", (object[])weakStudents));
            return weakStudents;
        }

        public static void StudentsEnrolled(IList<Student> allStudents)
        {

            Console.WriteLine(string.Join("/n",allStudents.Where(s=>s.FacultyNumber.ToString().Substring(4,2)=="14")));
        }

        

        public static void GetStudentsByAge(IList<Student> allStudents)
        {
            Console.WriteLine(
                string.Join(
                    ", ",
                    allStudents.Where(s => s.Age >= 18 && s.Age <= 24)
                        .Select(s => string.Format("{0} {1} {2} ", s.FirstName, s.LastName, s.Age))));
        }

        public static class FilterStudentsByEmail
        {
            public static void GetStudents(IList<Student> allStudents)
            {
                Console.WriteLine(string.Join(", ", allStudents.Where(s => s.Email.Contains("@abv.bg"))));
            }
        }

        public static class FilterStudentsByPhone
        {
            public static void Filter(IList<Student> allStudents)
            {
                Regex regex = new Regex("(02)?(3592)?(359 2)?");

                Console.WriteLine(
                    string.Join(", ", allStudents.Where(s => regex.Match(s.PhoneNumber).Success)));
            }
        }

        public static void SortStudents(IList<Student> allStudents)
        {
            Console.WriteLine(
                string.Join(", ", allStudents.OrderByDescending(s => s.FirstName)
                .ThenByDescending(s => s.LastName)));
        }

        public static class StudentsByFirstAndLastName
        {
            public static void PrintStudents(IList<Student> allStudents)
            {
                Console.WriteLine(string.Join(", ", allStudents.Where(s => s.FirstName.CompareTo(s.LastName) < 0)));
            }
        }

        public static IList<Student> StudentsByGroup(int groupNumber, IList<Student> allStudents)
        {
            IList<Student> result = new List<Student>();
            result = allStudents.Where(student => student.GroupNumber == groupNumber).OrderBy(s=>s.FirstName). ToList();
            return result;
        }
    }
}

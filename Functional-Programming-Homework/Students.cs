using System;

namespace Students
{

    public class Student
    {
        public Student(
            string firstName = null,
            string lastName = null,
            int fNumber = null,
            int age = null,
            string phoneNumber = null,
            string eMail = null,
            Ilist<int> marks = null,
            int groupNumber = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = fNumber;
            this.Age = age;
            this.PhoneNumber = phoneNumber;
            this.Email = eMail;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int FacultyNumber { get; set; }

        public int Age { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public IList<int> Marks { get; set; }

        public int GroupNumber { get; set; }
    }
}

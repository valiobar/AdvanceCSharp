


namespace Functional_Programing_Homework
{
    using System.Collections.Generic;
    using System.Text;

    public class Student
    {
        public Student(
            string firstName = null,
            string lastName = null,
            int fNumber = 0,
            int age = 0,
            string phoneNumber = null,
            string eMail = null,
            IList<int> marks = null,
            int groupNumber = 0)
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

        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();
            sb.Append(string.Format("{0},{1},{2},{3},{4},{5},{6}"));
            if (this.GroupNumber!=0)
            {
                sb.Append(", " + GroupNumber);
            }
            sb.Append(new string('=', 50));
            return sb.ToString();
        }
    }
}

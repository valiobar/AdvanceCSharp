
namespace Problem_2.Students_by_Group
{
    using System;
    using System.Collections.Generic;

    using Functional_Programing_Homework;

    class Execute
    {
         static void Main()
         {
             List<Student> allStudents=new List<Student>();
            allStudents.Add(new Student("Ivan","Ivanov",000014,20,"02 13123123","adasdas@abv.bg",new List<int>() {2,2,3,3,4,5},2));
            allStudents.Add(new Student("dragan", "Ivanov", 000114, 20, "+35923123123", "adasdas@abv.bg", new List<int>() { 2, 2, 3, 3, 4, 5 }));
            allStudents.Add(new Student("dragan", "draganov", 000115, 30, "+359 2 3123123", "adasdas@fdsfs.bg", new List<int>() { 6, 3, 3, 4, 5 }));
            allStudents.Add(new Student("petko", "draganov", 001115, 30, "+ 3123123", "adasdas@fdsfs.bg", new List<int>() { 6, 3, 3, 4, 5 },2));
            allStudents.Add(new Student("ivo", "draganov", 002115, 30, "+359 2 3123123", "adasdas@fdsfs.bg", new List<int>() { 3, 3, 3, 4, 5 }));
            allStudents.Add(new Student("ce", "Ivanov", 000112, 80, "+35923123123", "adasdas@abv.bg", new List<int>() { 2, 2, 3, 3, 4, 5 }));
            allStudents.Add(new Student("gan", "draganov", 000116, 23, "+359463123123", "adasdas@fdsfs.bg", new List<int>() { 6, 3, 3, 4, 5 }));
            allStudents.Add(new Student("pe", "draganov", 011115, 18, "+ 3123123", "adasdas@abv.bg", new List<int>() { 2, 2, 3, 3, 4, 5 }));
            allStudents.Add(new Student("an", "draganov", 000115, 30, "+359 2 3123123", "adasdas@fdsfs.bg", new List<int>() { 6, 3, 3, 4, 5 },2));
             Console.WriteLine(string.Join(" ", StudentsMenager.StudentsByGroup(2, allStudents)));

        }
    }
}

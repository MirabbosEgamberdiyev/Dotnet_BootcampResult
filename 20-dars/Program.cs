using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQ_operations
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> studentList = new()
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 13,
                    Subjects = new  List<string>()
                    {
                        "Math",
                        "Phsics",
                    }
                } ,
                new Student() { StudentID = 1, StudentName = "John", Age = 17,
                    Subjects = new  List<string>()
                    {
                        "Math",
                        "Phsics",
                    }
                } ,
                new Student() { StudentID = 2, StudentName = "Moin", Age = 21 ,
                    Subjects = new  List<string>()
                    {
                        "Programming",
                        "History"
                    }} ,
                new Student() { StudentID = 3, StudentName = "Bill", Age = 18 ,
                    Subjects = new  List<string>()
                    {
                        "Math",
                        "Programming",
                        "History"
                    }} ,
                new Student() { StudentID = 3, StudentName = "Bill", Age = 25 ,
                    Subjects = new  List<string>()
                    {
                        "Math",
                        "Programming",
                        "History"
                    }} ,
                new Student() { StudentID = 4, StudentName = "Ram", Age = 20,
                    Subjects = new  List<string>()
                    {
                        "Math",
                        "History"
                    } } ,
                new Student() { StudentID = 5, StudentName = "Ron", Age = 15,
                    Subjects = new  List<string>()
                    {
                        "Math",
                        "Phsics",
                        "Programming"
                    } }
            };

            /*
            // Ma’lumotlar manbayi (massiv)
            string[] names = { "Bill", "Steve", "James", "Mohan" };

            // LINQ so’rovi 
            //query syntax
            var myLinqQuery1 = from name in names
                              where name.Contains('a')
                              select name;

            //method syntax
            var myLinqQuery2 = names.Where(name => name.Contains('a'));

            // So’rovni ishlatish
            foreach (var name in myLinqQuery2)
                Console.WriteLine(name + " ");

            Console.ReadKey();

            */

            #region - Average
            int[] numbers = { 1, 2, 3, 8, 9, 10, 11, 12, 4, 5, 6, 7, 13 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++),
            //{
            //    sum += numbers[i];
            //}

            //int average = sum / numbers.Length;
            var average = numbers.Average();
            //Console.WriteLine(average);
            //var avgAge = studentList.Average(s => s.Age);
            //Console.WriteLine("Average Age of Student: {0}", avgAge);
            #endregion

            #region - select va selectmany
            var queryResult = from s in studentList
                              select s.StudentName;

            var methodResult = studentList.Select(student => student.Age);

            //foreach (var s in queryResult)
            //{
            //    Console.WriteLine(s);
            //}
            //foreach (var age in methodResult)
            //{
            //    Console.WriteLine(age);
            //}

            //var inputs = Console.ReadLine()
            //                      .Split()
            //                      .Select(son => int.Parse(son))
            //                      .ToList();
            //var names = string.Join("", studentList.SelectMany(s => s.StudentName));
            //Console.WriteLine(names);

            //2D list - select
            var subjects = studentList.Select(s => s.Subjects);
            foreach (var studentsubjects in subjects)
            {
                foreach (var subject in studentsubjects)
                {
                    //Console.WriteLine(subject);
                }

                //Console.WriteLine();
            }

            //select many - 1D list
            var subjectList = studentList.SelectMany(s => s.Subjects);
            foreach (var subject in subjectList)
            {
                ///Console.WriteLine(subject);
            }
            #endregion

            #region - Where
            var adults = studentList.Where(s => s.Age > 18)
                                    .Select(i => $"{i.StudentName}: {i.Age}");

            foreach (var adult in adults)
            {
                //Console.WriteLine(adult);
            }
            #endregion

            #region - Saralash
            //o'sish tartibida
            var orderedStudents = studentList.OrderBy(s => s.StudentName);
            foreach (var student in orderedStudents)
            {
                //Console.WriteLine(student.StudentName);
            }
            Console.WriteLine();
            //kamayish tartibida
            var orderedStudentsDesc = studentList.OrderByDescending(s => s.Age);
            foreach (var student in orderedStudentsDesc)
            {
                //Console.WriteLine(student.StudentName + ": " + student.Age);
            }

            //thenby va thenbyDecending
            var order = studentList.OrderBy(s => s.StudentName)
                                   .ThenByDescending(i => i.Age);

            foreach (var student in order)
            {
                Console.WriteLine($"{student.StudentName}: {student.Age}");
            }
            #endregion
        }
    }


    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

        public List<string> Subjects = new();
    }
}
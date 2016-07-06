using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralExtentionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            var student = person.DisplayName<Student, Person>();
            Console.WriteLine(student.Name);
            Console.WriteLine(person.DisplayName<Person>());
        }
    }

    public class Person
    {
        public string Name { get; set; }
    }

    public class Student
    {
        public Student()
        {
            this.Name = "default";
        }
        public string Name { get; set; }
    }

    public static class Extension
    {
        public static R DisplayName<R, T>(this T persion)
        {
            return (R)Activator.CreateInstance(typeof(R));
        }

        public static string DisplayName<T>(this T persion)
        {
            return "This is an extention method";
        }
    }
}

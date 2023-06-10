using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    static  class gfg //Class Name is case Sensitive and Method Name as well
    {
     //   private static short value = 1;
        public static void Another1()
        {
           // short Test = 1;
            //short test = 1;  //All are case sensitive;

            string str = "sridhar";

            // str.Reverse ===   Array.Reverse(str.ToCharArray()) after that we can use 
            IEnumerable<char> ch = str.Reverse();
            var r = string.Join("", ch);
            Console.WriteLine(r);
        }
        public static void Another()
        {
            Another1();
             
                
        }
    }

    class Gfg
    {
        public static void Another1()
        {
            gfg.Another();

        }
    }
    public sealed class Base
    {
        public Base()
        {

        }
    }
    public class Child
    {
        public void test()
        {
            var vl = new Base();
        }
    }
    public class Student
    {
        public Student(string name)
        {
            Name = name;
            Next = null;
        }

        public string Name { get; set; }
        public Student Next { get; set; }
    }

    public class ConstructorChaining
    {
        private string name;
        private int age;
        private int salary;

        public ConstructorChaining() : this("Sri")
        {
            Console.WriteLine("First Constructor");

            Console.WriteLine($"{this.name},{this.age},{this.salary}");


        }
        public ConstructorChaining(string name) : this(name, 10, 12000)
        {
            this.name = name;
            Console.WriteLine("Second Constructor");
            Console.WriteLine($"{this.name},{this.age},{this.salary}");
        }

        public ConstructorChaining(string name, int age, int salary)
        {
            this.age = age;
            this.salary = salary;
            Console.WriteLine("Third Constructor");
            Console.WriteLine($"{this.name},{this.age},{this.salary}");
        }

    }

    public class ConstructorChild : ConstructorChaining
    {
        public ConstructorChild()
        {
            Console.WriteLine("ChildConstructor - 1");
        }

        public ConstructorChild(string name) : base(name)
        {
            Console.WriteLine("ChildConstructor - 2");
        }

        public ConstructorChild(string name, int age, int salary) : base(name, age, salary)
        {
            Console.WriteLine("ChildConstructor - 3");
        }
    }

    struct Coordinate
    {
        public int x;
        public int y;

        public Coordinate(int x1, int y1)
        {
            x = x1;
            y = y1;
        }

    }

    public class Test
    {
        private Student Head;
        private Student Tail;

        public Test(string value)
        {
            this.Head = new Student(value);
            this.Tail = this.Head;
        }

        public void Insert()
        {

            var newStudent = new Student("Hari");
            var newStudent1 = new Student("New Hari");
            var change = this.Head; // since we are using this as pointer then reference of head is always maintained
            change.Next = newStudent;
            change = change.Next; /// 
            change.Next = newStudent1;
            Console.ReadKey();
        }

    }
}

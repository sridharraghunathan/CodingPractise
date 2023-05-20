using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{ 
    public abstract class Sa
    {
        static Sa() { }
        protected virtual void Sa1() { }
        public static int me() { Console.WriteLine("Parent Method");  return 1; }
        public  static void me1(int x) { }
        public   void me2(int x) { }
         
    }

    public class ChildC: Sa
    {
        public static new int me() { Console.WriteLine("child Method");  return 2; }
    }
    public abstract class University
    {

        static University() {
            pi = 4;
        }

        University(string name) { }
        public virtual void getColleges()
        {
            Sa.me1(1);
         //   new Sa().me2(1);
         
        }

        public University()
        {
            this.getCollegeFees();
            pi = 5;
        }

        public University(int te)
        {
            teS = te;
        }

        private static int pi = 3;
        private static int teS = 1;
        private const int pi2 = 2;
         public virtual int v() { return pi; }
         //private virtual int v1() { return pi; }
       // private abstract int v4();
    

        public virtual void test()
        {
            object str = "hello";
            char[] values = { 'h', 'e', 'l', 'l', 'o' };
            object str2 = new string(values);
            Console.WriteLine("Using Equality operator: {0}", str == str2);
            Console.WriteLine("Using equals() method: {0}", str.Equals(str2));
            Console.ReadKey();

        }

        public virtual int getCollegeFees() {
            pi = 6;


            return 1; }

        public class Nested
        {
            public Nested()
            {
                int a = University.teS;
                a++;
                Console.WriteLine(a);
            }
            public int b = 1;


        }

    }

    public class AnnaUniversity : University
    {
        public override int getCollegeFees()
        {
            int pi = 10;
            Console.WriteLine(pi);
            return pi;
        }
    }



}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{

    public partial class Class1
    {
        public Class1() { Console.WriteLine("TESTING"); }
    }

    public partial class Class1
    {
         
    }


    public class testingRefOut 
    {

        static testingRefOut ()
        {
            Console.WriteLine("this is static constructor");
        }


       public   testingRefOut()
        {
            Console.WriteLine("this is non static constructor");
        }

        public void ValueType(out double salary , double salary1)
        {
            salary = 100;
            salary1 = salary1 + 100;
            salary = 100+ salary;
        }
    }

    public class Test : testingRefOut { }

    public   sealed class SingletonClass
    {
 
        private   readonly  int counter = 0;
        private static SingletonClass instance = null;
        private static object obj = new Object();
        public static SingletonClass  getInstance { 
            get {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new SingletonClass();
                    }
                }
                return instance;
            }
        }
        private  SingletonClass() {
             counter++;
            Console.WriteLine($"Constructor is called {counter}");
        }


        public void printDetails() {  Console.WriteLine("Printing the User details "); }
    }
}

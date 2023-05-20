using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{


    interface IIn
    {

    }

    struct MyNewStruct : IIn
    {
        //paramter constructor with public should access modifier for struct
        public MyNewStruct()
        { 
        }
        //Constructor Overloading
          MyNewStruct(int v)
        {

        }
        //Static Constructor
        static MyNewStruct() { }
    }

    class MyNewClass
    {
        private MyNewClass() { }
        static MyNewClass() { }

        public MyNewClass(int a) { }
        public void Method()
        {
            var t = new MyNewStruct();

        }
    }

    class MyException : ApplicationException
    {
        public MyException(string Msg)
        {
            var s = new MyNewClass(1);
        }
    }

    public class Test
    {
        public static int i = 1;
        public readonly int i1 = 1;
        public static readonly int i2 = 1;
        private string _band;
        public string Band
        {
            get
            {

                return _band;
            }

        }
        static Test()
        {
            i = i + 1;
            i2 = i2 + 1;
            Console.WriteLine('S');
        }

        public Test(string band)
        {
            i = i + 1;
            i1 = i1 + 1;
            Console.WriteLine($"Main constructor {i}");
            _band = band;

        }

        internal void testing()
        {
            i = i + 1;
          

            Console.WriteLine($"Main testing {i}");
        }

        
    }

    public class Test1 : Test
    {
        internal Test1(string band) : base(band)
        {
            new Test(band);
            Console.WriteLine("Child constructor");
        }
    }
}

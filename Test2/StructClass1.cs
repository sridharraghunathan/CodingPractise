using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing;

namespace Test2
{
    public interface t
    { }
        public interface    It {
        void newtesting();
       
            }

    public class sample : It
    {
        private static       int a = 1;
        //static sample() { a++; }

        public sample() { a++; }

        public sample(int x) { a++; }



        public static void test() { }

        public void Newone()
        {
            
        }

        public void newtesting()
        {
            a++;
        }
    }


    public abstract class s: t { }
   public struct newStruct :t  { }
    public struct TestingStruct  :t
    {
        public int X { get; set; } = 1;
        public int Y { get; set; } = 1;
        public TestingStruct() { }
        public TestingStruct(int x, int y)   { 
            X = x;
            Y = y;
        }
    }

    public struct Rectangle  
    {
        private static int a = 1;
        private int length = 1;
        private int width = 1;
        // A constructor with all default parameters.
        static Rectangle() { a++; }
        public Rectangle() { a++; }
        public Rectangle(int l , int w  ) : this()
        {
            length = l;
            width = w;
        }
        public int Perimeter()
        {
            return 2 * length + 2 * width;
        }

        public static void t()
        {
            

        }
    }
    public struct StructClass1
    {
        private int _myProperty;
        public int MyProperty { get { return _myProperty; } set { _myProperty = value; } }

        private int _myProperty1;
        public int MyProperty1 { get { return _myProperty1; } set { _myProperty1 = value; } }
         
       
        public StructClass1(int myProperty, int myProperty1)
            {
                _myProperty = myProperty;
                _myProperty1 = myProperty1;
            } 
    }
}


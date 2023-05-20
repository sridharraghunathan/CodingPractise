using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6
{

    public abstract class print
    {
        public   void PrintHeader() { }
        public void PrintFooter() { }
        public abstract void PrintBody();
         public void  PrintMethod()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
    }




    public sealed class Singleton
    {

        private Singleton()
        {

        }


        private static  Singleton _instance = null;
        private static  Object obj = new Object();

        public static  Singleton instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (obj)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }

                }
                return _instance;

            }

        }

    }

    public class ModernPrinter : print
    {
        public override void PrintBody()
        {
            Console.WriteLine("I am body changed");
        }
    }

    internal class StatergicPattern
    {
    }
}


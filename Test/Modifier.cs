using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingD
{


    public interface ISample
    {
       public void Super()
        {
            Console.WriteLine("Super");
        }
      
    }
    public class Modifier: ISample
    {
       public Modifier() { }
        internal Modifier(string name) { }
        public Modifier(string name, string description) {
        }

        private int a = 1;
        protected int b = 2;
        private protected int c = 3;
        protected internal int d = 4;
        internal int e = 5;
        public int f = 6;

        public virtual void testm()
        {
            Console.WriteLine(a);
        }

       
    }


    public class UpdatedModifier : Modifier
    {
        public void Method() {

            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
        }
     }

}

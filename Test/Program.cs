using Test.Code1;
using TestingD;

namespace Test
{

    abstract class Parent
    {
        public static int GetBonus()
        {
            return 0;
        }
    }

      class Child :Parent
    {
        
    }
    abstract class DoSomething
    {
        public Action DoWhateverItIsThatIDo { get; set; }

        protected DoSomething() { DoWhateverItIsThatIDo = DoSomething.DoIt; }

        protected DoSomething(Action whatAction)
        {
            DoWhateverItIsThatIDo = whatAction;
        }

        protected static void DoIt()
        {
            Console.WriteLine("You asked the abstract class to work. Too bad.");
        }
    }

    class InspireMe : DoSomething
    {
        public InspireMe() : base(InspireMe.DoIt) { }

        public static new void DoIt()
        {
            Console.WriteLine("You are amazing.");
        }
    }

    class InsultMe : DoSomething
    {
        public InsultMe() : base(InsultMe.DoIt) { }

        public new static void DoIt()
        {
            Console.WriteLine("You aren't worth it.");
        }
    }

    class DoWhatBaseClassDoes : DoSomething
    {
        public DoWhatBaseClassDoes() : base() { }
    }


    public interface IInterface
    {

    }

    public    abstract class Abstraction    {

    }

    public abstract class Abstraction1
    {

    }

    public class Employee : Abstraction  ,IInterface
    {
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get;  }
        public string Name { get;  }
        public  static int GetBonus()
        {
            return 110;
        }

        public   virtual int GetSalary()
        {
                var message = Id switch
            {
                <= 0 => " This is less than or equal to 0",
                > 0 and <= 10 => "This is Greater than 0 and Less or equal to 10",
                _ => "Default"
            };
            return 1100;
        }
    }


    public class ChildEmployee : Employee
    {
        public ChildEmployee(int id, string name,bool isChild) : base(id, name)
        {
           this.isChild= isChild;
        }

        public bool isChild {get;set;}
 
        public override int GetSalary()
        {
            return 1200;
        }
  



        public void Show(params  int[] items) // Params Paramater  
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }


    }



  
    internal class Program
    {

         
        private static  void Main(string[] args)
        {

              ChildC.me();
            Parent.GetBonus();
            DoSomething worker = new InsultMe();
            worker.DoWhateverItIsThatIDo();
            InsultMe.DoIt();

            worker = new InspireMe();
            worker.DoWhateverItIsThatIDo();

            // In this case base class method is invoked
            worker = new DoWhatBaseClassDoes();
            worker.DoWhateverItIsThatIDo();
         var ch=    ChildEmployee.GetBonus();

            /*
                       ChildEmployee emp = new ChildEmployee(1, "Sridhar",true);


                       Employee emp1 = new Employee(2, "Sridhar1");
                       List <Employee> list = new List<Employee>();
                       list.Add(emp1);
                       int[] a = new int [] { 1 };
                       emp.Show(1,23);
                       emp.Name.ShortenString(3);


                       CalculatorDelegate calc = Calculator.Add;
                       calc += Calculator.Multiply;
                       calc(20, 20);

                       CalculatorDelegate calc1 = delegate (int a, int b)
                       {
                           Console.WriteLine(a + b);
                       };
                       CalculatorDelegate calc2 = (int a,int b) => Console.WriteLine(a * b);
                       Action<int,int> calc3 = (int a, int b) => Console.WriteLine(a * b);
                       calc3(12, 12);

                       Func<int, int, int> fndel = (int a, int b) => a + b;
                       fndel(10, 11);



                       calc(10, 11);
                       calc2(10, 11);
                       Console.WriteLine(emp.Name.ShortenString(3));
                       // Console.WriteLine(emp.GetBonus());
                       // Console.WriteLine(emp.GetSalary());

                       float best = new float();
                       Console.Write("Local variable a:- " + best + "\n");
                       Console.ReadLine();

                       ISample m = new Modifier();

                       //UpdatedModifier n = new UpdatedModifier();

                       //Console.WriteLine(n.b);
                       // Console.WriteLine(n.c);
                       //  Console.WriteLine(n.d);
                       //Console.WriteLine(n.e);
                       // Console.WriteLine(n.f);


           */

            /*

                        new Test1("super main").testing();
                        var t = new Test1("super");
                        Console.WriteLine(t.Band);

                     University an = new AnnaUniversity();
                        an.test();

                        */
        }

        public void Main() {
            Console.WriteLine("This is another");
        }
    }

   


}


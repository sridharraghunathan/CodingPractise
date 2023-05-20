using Test;
using Test.Code1;
using Test2;
using TestingD;

namespace Testing
{
    public abstract class Module { }
    public  class IntroModule: Module { }
    public class DemoModule : Module { }
    public abstract class Course
    {
        protected List<string> mod = new List<string>();
        public Course() { this.CreateCourses(); }
        public abstract void CreateCourses();
        public List<string> getModules() { return mod; }
    
    }
     
    public class Hld : Course
    {
        public override void CreateCourses()
        {
            mod.Add("HLDIntroModule");
            mod.Add("HLDDemoModule");
            mod.Add("HLDStaticticsModule");
        }
    }

    public class Lld : Course
    {
        public override void CreateCourses()
        {
            mod.Add("LLDIntroModule");
            mod.Add("LLDDemoModule");
            mod.Add("LLDStaticticsModule");
        }
    }

    public enum Courses
    {
        HLD,
        LLD
    }

    public class CourseFactory
    {
        public static Course getCourses(Courses Course)
        {
            switch (Course)
            {
                 case Courses.HLD:
                    return new Hld();
                    case Courses.LLD:
                    return new Lld();
                default:
                    return new Lld();
            }

        }
    }


    internal class Program : Modifier
    {
        static void Main(string[] args)
        {

            //Parallel.Invoke(() => Parallel0(), () => Parallel1());


            LinqPractise.testing();
            var t  = new testingRefOut();
            var t1 = new testingRefOut();
            Console.ReadLine();
        }

        private static void Parallel0()
        {
            SingletonClass singleton = SingletonClass.getInstance;
            singleton.printDetails();
    
        }

        private static void Parallel1()
        {
            SingletonClass singleton1 = SingletonClass.getInstance;
            singleton1.printDetails();
        }

        public void test()
        {

            StructClass1 s = new StructClass1();
            s.MyProperty = 1;



            var chd = new Child1(1, "sridhar", "Testing", "Benjamin", "Never Better", 100, "super man");
            chd.SubAuthor = "1";
            chd.GetPrice();

            Rectangle rectangle = new Rectangle();
            Console.WriteLine("{0}", rectangle.Perimeter());

            var r = new Rectangle(1, 2);
            var r1 = new StructClass1() { MyProperty = 1, MyProperty1 = 2 };
            r1.MyProperty1 = 3;
            new TestingStruct();


            var collection = CourseFactory.getCourses(Courses.HLD);
            foreach (var item in collection.getModules())
            {
                Console.WriteLine(item);
            }
            //  var n = new NewTest(); 
            //n.method();

            // Console.WriteLine(Sample.AreEqual<int>(1, 1));
            //Console.WriteLine(Sample.AreEqual<string>("hello", "Hello"));
        }
        public void method()
        {
            Console.WriteLine(b);
            Console.WriteLine(d); // Protected Internal
            Console.WriteLine(f); // Public

        }
    }

    public    class Newone{
    private Newone() { }
    }

    public class NewTwo { }

    public class NewTest : Modifier
    { 
        public void method() {

            var d = new Sample();
            Console.WriteLine(d.SampleRTN());

            var m = new Modifier();
            Console.WriteLine(m.f);

            var test = new NewTest();
            Console.WriteLine(test.b);
            Console.WriteLine(test.d); // Protected Internal
            Console.WriteLine(test.f); // Public
            Console.WriteLine(b);
            Console.WriteLine(d); // Protected Internal
            Console.WriteLine(f); // Public

        }
    }
}
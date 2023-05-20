namespace Test6
{
    using ChainOfResponsibility;
    using Decorator;


    // C# program to illustrate the
    // concept of Shallow Copy
    using System;
    using System.Text;
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int lastZeroPos = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    (nums[lastZeroPos], nums[i]) = (nums[i], nums[lastZeroPos]);
                    lastZeroPos++;
                }
            }
        }
        public int MaxSubArray(int[] nums)
        {
            int max = nums[0];
            int tmp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                tmp += nums[i];
                if (tmp > max)
                {
                    max = tmp;
                }
                if (tmp < 0)
                {
                    tmp = 0;
                }
            }
            return max;
        }

        static void Main()
        {


            new Solution().MoveZeroes(new int[] {0,1,0,3 });

        }

    }
    public abstract class VirtualClass
    {
        public virtual void Test() { }
    }

    class A
    {
        public virtual int testc { get; set; } = 2;
        public virtual void Show()
        {
            Console.WriteLine("A.Show()");
        }
    }
    class B : A
    {
        public override void Show()
        {
            Console.WriteLine("B.Show()");
        }
    }
    class C : B
    {
        public new int testc { get; set; } = 1;
        public override void Show()
        {
            Console.WriteLine("C.Show()");
        }
    }

    class A1
    {
        int i;
        public A1(int j)
        {
            i = j;
            Console.WriteLine("Base");
        }
    }
    class B1 : A1
    {
        public B1(int j) : base(j)
        {
            Console.WriteLine("Derived");
        }
    }
    class Example
    {

        // Main Method
        static void Main2(string[] args)
        {

            Company c1 = new Company(548, "GeeksforGeeks",
                                        "Sandeep Jain");

            // Performing Shallow copy					
            Company c2 = (Company)c1.Shallowcopy();

            Console.WriteLine("Before Changing: ");

            // Before changing the value of
            // c2 GBRank and CompanyName
            Console.WriteLine(c1.GBRank);
            Console.WriteLine(c2.GBRank);
            Console.WriteLine(c2.desc.CompanyName);
            Console.WriteLine(c1.desc.CompanyName);

            // changing the value of c2 GBRank
            // and CompanyName
            c2.GBRank = 59;
            c2.desc.CompanyName = "GFG";

            Console.WriteLine("\nAfter Changing: ");

            // After changing the value of
            // c2 GBRank and CompanyName
            Console.WriteLine(c1.GBRank);
            Console.WriteLine(c2.GBRank);
            Console.WriteLine(c2.desc.CompanyName);
            Console.WriteLine(c1.desc.CompanyName);
        }
    }
    class Company
    {

        public int GBRank;
        public CompanyDescription desc;

        public Company(int gbRank, string c,
                                string o)
        {
            this.GBRank = gbRank;
            desc = new CompanyDescription(c, o);
        }

        // method for cloning object
        public object Shallowcopy()
        {
            return this.MemberwiseClone();
        }

        // method for cloning object
        public Company DeepCopy()
        {
            Company deepcopyCompany = new Company(this.GBRank,
                                desc.CompanyName, desc.Owner);
            return deepcopyCompany;
        }
    }

    class CompanyDescription
    {

        public string CompanyName;
        public string Owner;
        public CompanyDescription(string c, string o)
        {
            this.CompanyName = c;
            this.Owner = o;
        }
    }
    public class main
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Order Order { get; set; }

        public Object Shallowcopy()
        {
            var cp = this.MemberwiseClone();
            return cp;
        }
    }
    public class Order
    {
        public int OrderId { get; set; }
        public string DishName { get; set; }
    }

    public class Sample
    {
        public int getTotal = 0;
        public Sample next;
        public Sample()
        {

        }
        public Sample(int value)
        {
            getTotal = value;
        }
        public Sample SetValue(int value, Sample sam)
        {
            this.getTotal = this.getTotal + value;
            this.next = sam;
            return next;
        }
    }
    internal class Program
    {

        static void Main3()
        {
            Sample sm = new Sample(1);
            sm.SetValue(1, new Sample()).SetValue(2, new Sample()).SetValue(3, new Sample());
            var total = sm.getTotal;

        }
        static void Main5()
        {

            var product = Program.GetSelectedProductDetail();

            var handler = new VoucherPaymentHandler();

            handler.SetNext(new WalletPaymentHandler())
                .SetNext(new DebitCardPaymentHandler())
                .SetNext(new CreditCardPaymentHandler());

            handler.Handle(product);
            Console.WriteLine(product.HandledBy);
        }

        static void Main6()
        {
            var t = new readtest();
            t.readtest1(1);
            var a = "A";
            var b = "a";
            Console.WriteLine(a == b);
            Console.WriteLine(a.Equals(b));
        }

        static void Main11()
        {



            C c = new C();
            A a = new A();
            a = c;
            a.Show();
            Console.WriteLine(a.testc);
            Console.WriteLine(c.testc);
            c.Show();
            Console.ReadLine();
        }


        public static string GetNextName(ref int id, out int id1)
        {
            id1 = 1;
            string returnText = "Next-" + id.ToString() + id1.ToString();
            id += 1;
            return returnText;
        }

        public record Member(string FirstName)
        {
            public int Id { get; init; }
            public string LastName { get; init; }
            public string Address { get; init; }


        }


        public class readtest
        {
            public readonly int a = 1;
            public static int b = 1;
            public static readonly int c = 1;

            public readtest()
            {
                a = 2;
                b = 2;
                //  c = 1;
            }

            static readtest()
            {
                //a = 4;
                b = 3;
                c = 2;


            }



            public int readtest1(int y)
            {
                b = 2;
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                return a;
            }

        }


        private static Product GetSelectedProductDetail()
        {
            Product product = new Product()
            {
                Name = "Iphone",
                Cost = 50000
            };
            return product;
        }


        static void Main12()
        {


            new Solution().MaxSubArray(new int[] { -2, -1, -3, 4, -1, 2, 1, -5, 4 });
            {

                string s = new string("hello".ToCharArray());
                string s1 = new string("hello".ToCharArray());
                //   object s= "hello";
                Console.WriteLine(s.GetType());
                Console.WriteLine(s);
                Console.WriteLine(s1);
                //     object s1 = "hello";
                Console.WriteLine(s1.GetType());
                string s2 = "test".Substring(0, 4);

                object str = "hello";
                char[] values = { 'h', 'e', 'l', 'l', 'o' };
                object str2 = new string(values);
                Console.WriteLine("Using Equality operator: {0}", str == str2);
                Console.WriteLine("Using equals() method: {0}", str.Equals(str2));

                Console.WriteLine(s == s1);
                Console.WriteLine(s.Equals(s1));
            }
            static void Main7()
            {





                var newaccount1 = new AccountManager("Sridhar-account");
                var newaccount_1 = new AccountManager("Sridhar-account1");

                var newLawyer = new Lawyer("Sridhar-lawyer");
                var newLawyer_1 = new Lawyer("Sridhar-lawyer1");
                var singleton = Singleton.instance;

                TeamChatRoom tcr = new TeamChatRoom();
                tcr.Register(newaccount1);
                tcr.Register(newaccount_1);
                tcr.Register(newLawyer);
                tcr.Register(newLawyer_1);


                newaccount1.Send("Hi All");
                newaccount1.SendTo<Lawyer>("Good Morning");


                //ShoppingCart _shoppingCart = new ShoppingCart("IN");
                //var data = _shoppingCart.GetShoppingCartDetail();
            }
            /*
            static void Main1(string[] args)
            {
                var customer = new Customer()
                {
                    Id = 1,
                    Name = "Test",
                    Order = new Order()
                    {
                        OrderId = 2,
                        DishName = "Best Dish"
                    }
                };

                var customer1 = (Customer)customer.Shallowcopy();
                customer1.Id = 2;
                customer1.Name = "Best";
                customer1.Order.OrderId = 3;
                customer1.Order.DishName = "Super Dish";

                Console.WriteLine($"{customer.Id}{customer.Name}{customer.Order.OrderId}{customer.Order.DishName}");
                Console.WriteLine($"{customer1.Id}{customer1.Name}{customer1.Order.OrderId}{customer1.Order.DishName}");

                var customer2 = new Customer();
                customer2.Id = customer1.Id;
                customer2.Name = "guest";
                customer2.Id = 4;
                Console.WriteLine($"{customer2.Id}{customer2.Name}");
                Console.WriteLine($"{customer1.Id}{customer1.Name}{customer1.Order.OrderId}{customer1.Order.DishName}");

            } */
        }
    }
}
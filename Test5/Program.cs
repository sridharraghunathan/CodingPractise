namespace Test5
{
    internal class Program
    {


        class A 
        {

            public int value { get; set; } = 1;

             internal void show() { Console.WriteLine($"show {value}"); }

           
        }
        class B 
        {
            public int value { get; set; } = 2;
            internal void show() { Console.WriteLine($"show {value}"); }
        }
        class C 
        {
            public int value { get; set; } = 3;
            internal void show() { Console.WriteLine($"show {value}"); }

        }

        interface Icommon
        {
            public int value { get; set; }
            void show();
        }
        static void Main(string[] args)
        {

            var c = new Program();
            c.getDaysCount( "mon");

 

        }



        void getDaysCount( string day)
        {
            string[] days = { "mon", "tue", "wed", "thu", "fri", "sat", "sun" };
           var currentYear = new DateTime().Year;
            var month = new DateTime().Month;
            var numofDays = DateTime.DaysInMonth(currentYear, month);
             var count = new int[7];
            //setting all the values to 4
            for (int i = 0; i < count.Length; i++)
            {
                count[i] = 4;
            }

            var increment = numofDays - 28;
            var index = 0;
            for (int i = 0; i < days.Length; i++)
            {
                if (day == days[i]) {
                    index = i;
                    break;
                }
            }
            // increment = 0,1,2,3
            for (int i = index; i < increment + index ; i++)
            {
                if (index > 7) { count[index % 7] = 5; } else { count[i] = 5; }
            }

            for (int i = 0; i < count.Length; i++)
            {
                Console.WriteLine($"Day is {days[i]} and no of days is {count[i]}");
            }




        }

    }
}
namespace Test.Code1
{

    delegate void CalculatorDelegate(int a, int b);

    public static class Calculator
    {
        public static void Add(int a, int b) { Console.WriteLine(a+b); }
        public static void Multiply(int a, int b) { Console.WriteLine(a * b); }
        public static void Substract(int a, int b) { Console.WriteLine(a - b); }

    }
     
    public class Sample
    { 
        public static bool AreEqual<T>(T a, T b)
        {
           return  a.Equals(b);
        }
        public Sample() { }
 
        public int SampleRTN() {
            int i = 1;
            if (i == 1)
            {

            }
            else if (i == 2) { }

            var val = i == 1 ? 1 : i == 2 ? 2 : 3;

            switch (i)
            {
                case 1:
                    i = i + 1;
                    break;
                default:
                    break;
            }


            return 1; }
    }

    public static class StringExtenstion
    {
        public static string ShortenString(this string name, int position)
        {
            return $"{name.Substring(0, position)}...";
        }
    }



   
}

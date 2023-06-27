namespace Day_5_Basic_core_programs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //declare and initialize character variable

            int a = 12, b = 2;
            int q, r;

            //find the quotient

            q = a / b;

            //find the remainder

            r = a % b;

            // display result

            Console.WriteLine("When " + a + " is divided by " + b + ", quotient is " + q + " and remainder is " + r + ".");

            // wait for user to press any key

            Console.ReadKey();
        }
    }
    

}
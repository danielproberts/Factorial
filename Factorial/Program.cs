using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            for (int i = num; i > 0; i--)
            {
                factorial *= i;
            }

            Console.WriteLine();
            Console.WriteLine("{0}! = {1}", num, factorial);

            Console.WriteLine("Press any key to close window...");
            Console.ReadKey();
        }
    }
}

using System;
namespace ConsoleApplication1
{
    delegate void Factorial(int a);
    class Program
    {
        static void Main(string[] args)
        {
            Factorial delgateObj = delegate (int n)
            {
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }
                Console.WriteLine("Factorial of {0} is =: {1}", n, fact);
            };
            Console.WriteLine("Enter the number to find the factorial");
            int no = Convert.ToInt32(Console.ReadLine());
            delgateObj(no);
            Console.ReadLine();
        }
    }
}
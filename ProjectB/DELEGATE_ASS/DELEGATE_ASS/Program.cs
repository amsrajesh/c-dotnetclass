using System;
namespace ConsoleApplication1
{
    delegate void Factorial(int a);
    delegate void Factorial5(int b);
    delegate void Factorial10(int c);
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

            int j, x;

            Console.Write("Input the number : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (j = 1; j <= 10; j++)
            {
                Console.Write(" {2} \n", x, j, x * j);
                Console.ReadLine();
            }
        }
    }
}
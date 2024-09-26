using System;
namespace ConsoleApplication1
{
    delegate void singleargdel(int a);

    class Program
    {
        static void factorial(int n)
        {

            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of {0} is =: {1}", n, fact);

        }
        static void roundTo5(int m)
        {
            // 13
            // 15
            int remainder = m % 5;
            int ans = m + (5 - remainder);
            Console.WriteLine("Round to  5 for  {0}  is  {1}", m, ans);
        }

        static void roundTo10(int m)
        {
            // 13
            // 15
            int remainder = m % 10;
            int ans = m + (10 - remainder);
            Console.WriteLine("Round to  10 for  {0}  is  {1}", m, ans);
        }
        static void Main(string[] args)
        {
            int code = -1; int x;
            singleargdel delobj;
            do
            {
                Console.WriteLine("Enter the code ");
                code = Convert.ToInt16(Console.ReadLine());
                if (code < 0 || code > 3)
                {
                    Console.WriteLine("Invalid code:");
                    break;
                }

                Console.Write("Input the number : ");
                x = Convert.ToInt32(Console.ReadLine());
                if (code == 1)
                {
                    delobj = factorial;
                }
                else if (code == 2)
                {
                    delobj = roundTo5;

                }
                else
                {
                    delobj = roundTo10;
                }
                delobj(x);
            } while (code > 0);











        }
    }
}
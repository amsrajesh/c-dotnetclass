using System;

public class Program
{
    public static void Main()
    {
        int i = 10, j = 10, k = 10, n = 10;

        if (i > j)
        {
            Console.WriteLine("i is greater than j");
        }
        if (j > i)
        {
            Console.WriteLine("j is greater than i");
        }
        if (j > k)
        {
            Console.WriteLine("i is greater than j");
        }

        if (k > n)
        {
            Console.WriteLine("i is greater than j");
        }
        else
        {
            Console.WriteLine("all are equal");
        }
    }
}
using System;


public class Program
{
    static Func<int, int> operation;


    public static int Sum(int x, int y)
    {
        return x + y;
    }

    public static void Main()
    {
        Func<int, int> add;

        int result = Sum (10, 10);

        Console.WriteLine(result);
        Console.ReadLine();
    }
}
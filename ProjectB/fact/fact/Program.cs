using System;
public delegate void MyDelegate(int N, int a, int b, int c);
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the number: ");
        int a = int.Parse(Console.ReadLine());
        int fact = 1;
        for (int x = 1; x <= 10; x++)
        {
            fact *= x;
        }
        Console.WriteLine(fact);
        Console.ReadLine();
    }
}
public class factorial
{
    public static void fact(int N)
    {

        Console.WriteLine("{0}  ", N);
        Console.ReadLine();
    }

}
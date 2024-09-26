using System;
public delegate void MyDelegate(int a, int b);
public class Program
{
    public static void Main()
    {
        MyDelegate del;

        del = Calculator.Add;
        del(7, 3);

        del = Calculator.Mul;
        del(7, 3);

        del = Compare.Greater;
        del(7, 3);

        del = (int n1, int n2) => {
            float div = n1 / n2;
            Console.WriteLine("{0} / {1} = {2} ", n1, n2, div);
        };

        del(15, 3);


    }
}
public class Calculator
{
    public static void Add(int n, int m)
    {
        int c = m + n;
        Console.WriteLine("{0} + {1} = {2} ", m, n, c);
    }

    public static void Mul(int n, int m)
    {
        int c = m * n;
        Console.WriteLine("{0} * {1} = {2} ", m, n, c);
    }
}
public class Compare
{
    public static void Greater(int x, int y)
    {
        if (x > y)
        {
            Console.WriteLine("{0} is greater than {1} ", x, y);
        }
        else
        {
            Console.WriteLine("{0} is greater than {1} ", y, x);
            Console.ReadLine();
        }

    }
}

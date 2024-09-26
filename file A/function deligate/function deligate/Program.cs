using System;
public class Program
{
    public static void Main()
    {
        string result;
        Func<int, int, string> del;

        del = Calculator.Add;
        result = del(7, 3);
        Console.WriteLine(result);
        del = Calculator.Mul;
        result = del(7, 3);
        Console.WriteLine(result);
        del = Compare.Greater;
        result = del(7, 3);
        Console.WriteLine(result);
        del = (int n1, int n2) => {
            float div = n1 / n2;
            return string.Format("{0} / {1} = {2} ", n1, n2, div);
        };

        result = del(15, 3);
        Console.WriteLine(result);
        Console.ReadLine();

    }
}
public class Calculator
{
    public static string Add(int n, int m)
    {
        int c = m + n;
        return string.Format("{0} + {1} = {2} ", m, n, c);
    }

    public static string Mul(int n, int m)
    {
        int c = m * n;
        return string.Format("{0} * {1} = {2} ", m, n, c);
    }
}
public class Compare
{
    public static string Greater(int x, int y)
    {
        if (x > y)
        {
            return string.Format("{0} is greater than {1} ", x, y);
        }
        else
        {
            return string.Format("{0} is greater than {1}", x, y);
        }
    }
}
using System;

public class Program
{
    private static int y;

    static void ChangeValue(int x)
    {
        x = 200;
        y = 800;

        Console.WriteLine(x);
        Console.WriteLine(y);
    }

    public static void Main()
    {
        int i = 100;
        int j = 40;

        Console.WriteLine(i);
        Console.WriteLine(j);

        ChangeValue(i);
        ChangeValue(j);


        Console.WriteLine(i);
        Console.ReadLine();
    }
}
using System;

public class Program
{
    public static void Main()
    {
        Nullable<int> i = null;

        if (i.HasValue)
            Console.WriteLine(i.Value); // or Console.WriteLine(i)
        else
            Console.WriteLine("Null");
        Console.ReadLine();
    }
}
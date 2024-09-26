using System;

public class Program
{
    public static void Main()
    {
        Action<int> printAction1 = ConsolePrint;
        Action printAction2 = ConsolePrintTime;



        printAction1(10);
        printAction2();
        printAction1(12);
        printAction1 = ConsolePrintPlus;
        printAction1(15);
        printAction2();

    }

    public static void ConsolePrintTime()
    {
        Console.WriteLine(DateTime.Now.ToString());
        Console.ReadLine();
    }
    public static void ConsolePrint(int i)
    {
        Console.WriteLine(i);
        Console.ReadLine();
    }
    public static void ConsolePrintPlus(int i)
    {
        Console.WriteLine(i + 5);
        Console.ReadLine();
    }
}

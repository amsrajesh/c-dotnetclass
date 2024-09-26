using System;

public class Program
{
    public static void Main()
    {
        dynamic MyDynamicVar = false;
        Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

        MyDynamicVar = "good evening";
        Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

        MyDynamicVar = 100;
        Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

        MyDynamicVar = DateTime.Now;
        Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());
        Console.ReadLine();
    }

}
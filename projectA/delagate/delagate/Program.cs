using System;

public delegate void MyDelegate(int value);

public class Program
{
    public static void Main()
    {
        MyDelegate del = ClassA.MethodA;
        del(10);

        del = ClassB.MethodB;
        del(20);


    }
}

public class ClassA
{
    public static void MethodA(int value)
    {
        Console.WriteLine("Called ClassA.MethodA() with parameter: " + value);
    }
}

public class ClassB
{
    public static void MethodB(int value)
    {
        Console.WriteLine("Called ClassB.MethodB() with parameter: " + value);
        Console.ReadLine();
    }
}

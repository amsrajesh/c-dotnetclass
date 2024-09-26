using System;
public delegate void MyDelegate(string msg);
public class Program
{
    public static void Main()
    {
        int B = 5;
        int k = 10;
        int Y = B - k;
        Y += 12;

        Console.WriteLine("check c value, Y = {0} ", Y);
        MyDelegate del1 = ClassA.MethodA;
        MyDelegate del2 = ClassB.MethodB;

        MyDelegate del = del1 + del2;
        Console.WriteLine("After del1 + del2");
        del("Hi ANDHRAPRADESH");

        MyDelegate del3 = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
        del += del3; // del = del + del3
        Console.WriteLine("After del1 + del2 + del3");
        del("Hi ANDHRAPRADESH");

        del = del - del2; //  // del = del - del2
        Console.WriteLine("After del - del2");
        del("Hi ANDHRAPRADESH");

        del -= del1; // del = del - del1
        Console.WriteLine("After del1 - del1");
        del("Hello ANDHRA");
    }
}
public class ClassA
{
    public static void MethodA(string message)
    {
        Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
    }
}
public class ClassB
{
    public static void MethodB(string message)
    {
        Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        Console.ReadLine();
    }
}

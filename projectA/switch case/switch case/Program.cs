using System;

public class Program
{
    public static void Main()
    {
        int weekdays ;
       

        switch (weekdays=1)
        {
            case 1:
                Console.WriteLine("Monday");
                Console.ReadLine();
                break;
            case 2:
                Console.WriteLine("Tuesday");
                Console.ReadLine();
                break;
            case 3:
                Console.WriteLine("wendsday");
                Console.ReadLine();
                break;
            case 4:
                Console.WriteLine("Thurday");
                Console.ReadLine();
                break;
            case 5:
                Console.WriteLine("friday");
                Console.ReadLine();
                break;
            case 6:
                Console.WriteLine("saturday");
                Console.ReadLine();
                break;
            case 7:
                Console.WriteLine("sunday");
                Console.ReadLine();
                break;
            default:
                Console.WriteLine("Unknown value");
                Console.ReadLine();
                break;
        }
    }
}
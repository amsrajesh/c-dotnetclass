using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

class Program
{
    private static object weekdays;

    static void Main(string[] args)
    {
        Weekdays newWeekdays = null;

        try
        {
            int Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
             Saturday;
           int Sunday;
            ValidateWeekdays(newWeekdays);
        }
        catch (InvalidWeekdaysException ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
        }
    }

    private static void ValidateWeekdays(Weekdays wee)
    {
        System.Text.RegularExpressions.Regex regex = new Regex("^[a-zA-Z]+$");

        if (!regex.IsMatch(wee.Monday))
        {
            throw new InvalidWeekdaysException(wee.sunday);
        }

        Console.ReadLine();

    }
}

[Serializable]
internal class InvalidWeekdaysException : Exception
{
    public InvalidWeekdaysException()
    {
    }

    public InvalidWeekdaysException(string message) : base(message)
    {
    }

    public InvalidWeekdaysException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected InvalidWeekdaysException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
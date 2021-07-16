using System;

public class Program
{
    public static void Main()
    {
        StringDataStore strStore = new StringDataStore();

        strStore[0] = "One";
        strStore[1] = "Two";
        strStore[2] = "Three";
        strStore[3] = "Four";

        for (int i = 0; i < 10; i++)
            Console.WriteLine(strStore[i]);
        Console.ReadLine();
    }
}

class StringDataStore
{
    private string[] strArr = new string[10]; // internal data storage
    public string this[int index]
    {
        get => strArr[index];
        set => strArr[index] = value;
    }
}
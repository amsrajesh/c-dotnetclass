using System;



public class Student
{

    public string StudentName { get; set; }

}

public class Program
{
    public static void ChangeReferenceType(Student std2)
    {
        std2.StudentName = "ali";
    }
    public static void ChangeRefernceType(Student std3)
    {
        std3.StudentName = "arjun";
    }

    public static void Main()
    {
        Student std1 = new Student();
        Student std3 = new Student();

        std1.StudentName = "Balu";
        std3.StudentName = "suji";

        ChangeReferenceType(std1);

        Console.WriteLine(std1.StudentName);
        Console.WriteLine(std3.StudentName);
        Console.ReadLine();

    }
}

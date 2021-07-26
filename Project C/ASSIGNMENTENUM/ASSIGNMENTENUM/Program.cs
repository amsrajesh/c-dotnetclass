using System;
enum Sex
{
    Male,
    Female
}
enum Department
{
    Electronics,
    Computerscience,
    Mechanical
}
enum Year
{
    First,
    Second,
    Third
}
public class Program
{
    public static String Name { get; private set; }
    public static int Roll { get; private set; }
}
public class Student
{
    int Roll;
    String Name;
    Sex Sex;
    Department Dep;
    Year Year;
   
        public static void Main()
        {
        Student s1 = new Student();   
        s1.Roll = 101;
        s1.Name = "ARJUN";
        Console.WriteLine(s1.Roll);
        Console.WriteLine(s1.Name);
        
            Sex s2 = Sex.Male;
            Sex s3 = Sex.Female;
            Console.WriteLine("Sex: {0}", Enum.Format(typeof(Sex), s2, "d"));
            Console.WriteLine("sex: {0}", Enum.Format(typeof(Sex), s3, "d"));
            Console.WriteLine(" {0}", Enum.GetName(typeof(Department), 0));
            Console.WriteLine(" {0}", Enum.GetName(typeof(Department), 1));
            Console.WriteLine(" {0}", Enum.GetName(typeof(Department), 2));
            Console.WriteLine(" {0}", Enum.GetName(typeof(Year), 0));
            Console.WriteLine(" {0}", Enum.GetName(typeof(Year), 1));
            Console.WriteLine(" {0}", Enum.GetName(typeof(Year), 2));



            Console.ReadLine();
        }
    }


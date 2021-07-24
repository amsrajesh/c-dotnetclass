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
public class Student
{
    int Roll;
    String Name;
    Sex Sex;
    Department Dep;
    Year Year;
    public class Program
    {
        public static String Name { get; private set; }
        public static int Roll { get; private set; }
        public static void Main()
        {
            Console.WriteLine("Enter your Roll:");
            int Roll = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Name:");
            Console.WriteLine("Your Name is:" + Name);
            Console.ReadLine();
            Student s1 = new Student();
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
}

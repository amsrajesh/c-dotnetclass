using System;
public enum Sex
{
    Male,
    Female
}
public enum Department
{
    Electronics,
    Computerscience,
    Mechanical
}
public enum Year
{
    First,
    Second,
    Third
}

public class Student
{
    //we are declaring data are private so that it can't be access outside
    private int Roll;
    private String Name;
    private Sex Sex;
    private Department Dep;
    private Year Year;
    //we are declaring functions as public,the function only can be accesed outside, we can access the data only through the function
    public void ReadStudent()
    {
        Console.WriteLine("enter roll number:");
        Roll = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your Name:");
        Name = Console.ReadLine();
        Console.WriteLine("enter sex");
        Sex  = (Sex)Enum.Parse(typeof(Sex),Console.ReadLine());  // Animal.Dog
        Dep=(Department)Enum.Parse(typeof(Department),Console.ReadLine());
        Year=(Year)Enum.Parse(typeof(Department),Console.ReadLine());


    }
    public void AssignStudent(int Roll,string Name,Sex Sex, Department Dept, Year Year)
    {
       this.Roll = Roll;//becasue both class data variable  and function argument are same name we want add 'this'
       this.Name = Name;
       this.Sex = Sex;
        Dep = Dept;//because both class data variable and function argument are not same we no need  use add 'this'
       this.Year = Year;
        
        

    }
    public void Display()
    {
        Console.WriteLine("Roll:{0}", Roll);
        Console.WriteLine("Name:{0}",Name);
        Console.WriteLine("Sex:{0}", Sex);
        Console.WriteLine("Department:{0}", Dep);
        Console.WriteLine("Year:{0}", Year);

    }
    


}
    public class Program
    {
        public static String Name { get; private set; }
        public static int Roll { get; private set; }

        public static void Main()
        {


            
        


           
        }
    }



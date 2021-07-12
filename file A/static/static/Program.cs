using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace StaticConstructorsDemo
{
    class Student
    {
          
        public string StudentName;
        public string Course;
        public void SetStudentDetails(string StuName, string Cou)
        {
            StudentName = StuName;
            Course = Cou;
        }
       

        public void DisplayStudentDetails()
        {
            Console.WriteLine(StudentName + " - " + Course);
            Console.ReadLine();

        }

        
        public static string CollegeName = "ABC College of Technology";
        public static string CollegeAddress = "Hyderabad";

        //static methods  
        public static void DisplayCollegeDetails()
        {
            Console.WriteLine(CollegeName);
            Console.WriteLine(CollegeAddress);
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //access static members  
            Student.DisplayCollegeDetails();

            //acess non-static members  
            Console.WriteLine();
            Student s1 = new Student();
            Student s2 = new Student();
            s1.SetStudentDetails("Sarath", "MCA");
            s2.SetStudentDetails("Syam", "MBA");
            s1.DisplayStudentDetails();
            s2.DisplayStudentDetails();
            Console.Read();
        }
    }
}
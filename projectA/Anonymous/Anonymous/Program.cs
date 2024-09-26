//example by TutorialsTeacher
using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        IList<employee> employeeList = new List<employee>() {
                        new employee() { employeeID = 1,employeeName = "srikar",employeesalary = 18000,employeestatus="married" } ,
                        new employee() { employeeID = 2,employeeName = "ARJUN", employeesalary = 21000,employeestatus="unmarried" } ,
                        new employee() { employeeID = 3,employeeName = "Pabha", employeesalary = 49000,employeestatus="married" } ,
                        new employee() { employeeID = 4,employeeName = "Ram" ,employeesalary=60000,employeestatus=" unmarried",employeeage = 20  } ,
                        new employee() {}
                                       };

        var employee = from e in employeeList
                       select new { Id = e.employeeID, Name = e.employeeName };

        foreach (var e in employee)
            Console.WriteLine(e.Id + "-" + e.Name);
        Console.ReadLine();
    }
}
public class employee
{
    internal int employeeID;
    internal string employeeName;
    internal int employeeage;
    internal int employeesalary;
    internal string employeestatus;

    public int ID { get; set; }
    public string Name { get; set; }
    public int age { get; set; }
}

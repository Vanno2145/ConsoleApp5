using System;
using System.Linq;
using System.Collections.Generic;

public class Firm
{
    public string Name { get; set; }
    public DateTime FoundationDate { get; set; }
    public string BusinessProfile { get; set; }
    public string DirectorName { get; set; }
    public int EmployeesCount { get; set; }
    public string Address { get; set; }
    public List<Employee> Employees { get; set; }
}

public class Employee
{
    public string FullName { get; set; }
    public string Position { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public decimal Salary { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<Firm> firms = new List<Firm>
        {
            new Firm
            {
                Name = "FoodWorld",
                FoundationDate = DateTime.Now.AddYears(-3),
                BusinessProfile = "Marketing",
                DirectorName = "John White",
                EmployeesCount = 150,
                Address = "London",
                Employees = new List<Employee>
                {
                    new Employee { FullName = "Alice Johnson", Position = "Manager", PhoneNumber = "2312345678", Email = "alice@foodworld.com", Salary = 50000 },
                    new Employee { FullName = "Bob Smith", Position = "Analyst", PhoneNumber = "2345678901", Email = "bob@foodworld.com", Salary = 45000 }
                }
            },
            new Firm
            {
                Name = "Tech IT",
                FoundationDate = DateTime.Now.AddYears(-5),
                BusinessProfile = "IT",
                DirectorName = "Michael Black",
                EmployeesCount = 500,
                Address = "New York",
                Employees = new List<Employee>
                {
                    new Employee { FullName = "Charlie Brown", Position = "Developer", PhoneNumber = "2311112222", Email = "charlie@techit.com", Salary = 60000 },
                    new Employee { FullName = "David Wilson", Position = "Manager", PhoneNumber = "2319876543", Email = "david@techit.com", Salary = 75000 }
                }
            },
            new Firm
            {
                Name = "Marketing Pro",
                FoundationDate = DateTime.Now.AddYears(-1),
                BusinessProfile = "Marketing",
                DirectorName = "Sarah White",
                EmployeesCount = 80,
                Address = "London",
                Employees = new List<Employee>
                {
                    new Employee { FullName = "Eve Davis", Position = "Manager", PhoneNumber = "2300123456", Email = "eve@marketingpro.com", Salary = 55000 },
                    new Employee { FullName = "Frank Moore", Position = "Consultant", PhoneNumber = "2340011223", Email = "frank@marketingpro.com", Salary = 48000 }
                }
            },
            new Firm
            {
                Name = "WhiteFood",
                FoundationDate = DateTime.Now.AddYears(-4),
                BusinessProfile = "Food",
                DirectorName = "Alex Black",
                EmployeesCount = 200,
                Address = "London",
                Employees = new List<Employee>
                {
                    new Employee { FullName = "Grace Thomas", Position = "Manager", PhoneNumber = "2315551234", Email = "grace@whitefood.com", Salary = 53000 },
                    new Employee { FullName = "Hank Martinez", Position = "Chef", PhoneNumber = "2345556789", Email = "hank@whitefood.com", Salary = 47000 }
                }
            },
        };

        IEnumerable<Employee> employeesOfSpecificFirm = firms.First(f => f.Name == "FoodWorld").Employees;

        IEnumerable<Employee> highSalaryEmployees = firms.First(f => f.Name == "FoodWorld").Employees.Where(e => e.Salary > 50000);

        IEnumerable<Employee> managersFromAllFirms = firms.SelectMany(f => f.Employees).Where(e => e.Position == "Manager");

        IEnumerable<Employee> employeesWithPhoneStarting23 = firms.SelectMany(f => f.Employees).Where(e => e.PhoneNumber.StartsWith("23"));

        IEnumerable<Employee> employeesWithEmailStartingDi = firms.SelectMany(f => f.Employees).Where(e => e.Email.StartsWith("di"));

        IEnumerable<Employee> employeesNamedLione = firms.SelectMany(f => f.Employees).Where(e => e.FullName.Contains("Lione"));

        Console.WriteLine("Employees of FoodWorld:");
        foreach (Employee employee in employeesOfSpecificFirm) Console.WriteLine(employee.FullName);

        Console.WriteLine("\nEmployees of FoodWorld with High Salaries:");
        foreach (Employee employee in highSalaryEmployees) Console.WriteLine(employee.FullName);

        Console.WriteLine("\nManagers from All Firms:");
        foreach (Employee employee in managersFromAllFirms) Console.WriteLine(employee.FullName);

        Console.WriteLine("\nEmployees with Phone Starting with 23:");
        foreach (Employee employee in employeesWithPhoneStarting23) Console.WriteLine(employee.FullName);

        Console.WriteLine("\nEmployees with Email Starting with 'di':");
        foreach (Employee employee in employeesWithEmailStartingDi) Console.WriteLine(employee.FullName);

        Console.WriteLine("\nEmployees Named 'Lione':");
        foreach (Employee employee in employeesNamedLione) Console.WriteLine(employee.FullName);
    }
}

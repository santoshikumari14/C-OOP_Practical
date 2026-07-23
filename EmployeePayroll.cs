using System;

// Interface
interface IPayroll
{
    void CalculateSalary();
}

// Base class
class Employee
{
    protected int employeeId;
    protected string employeeName;

    public Employee(int id, string name)
    {
        employeeId = id;
        employeeName = name;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine("\n--- Employee Payroll Details ---");
        Console.WriteLine("Employee ID   : " + employeeId);
        Console.WriteLine("Employee Name : " + employeeName);
    }
}

// Derived class
class FullTimeEmployee : Employee, IPayroll
{
    private double monthlySalary;

    public FullTimeEmployee(int id, string name, double salary)
        : base(id, name)
    {
        monthlySalary = salary;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Employee Type : Full Time");
        Console.WriteLine("Monthly Salary: " + monthlySalary);
    }

    public void CalculateSalary()
    {
        Console.WriteLine("Final Salary  : " + monthlySalary);
    }
}

class Program
{
    static void Main()
    {
        // Creating an object
        Employee employee1 = new FullTimeEmployee(23, "Santoshi Kumari", 30000);

        // Polymorphism
        employee1.DisplayDetails();

        // Interface implementation
        IPayroll payroll = new FullTimeEmployee(23, "Santoshi Kumari", 30000);
        payroll.CalculateSalary();

        Console.ReadLine();
    }
}
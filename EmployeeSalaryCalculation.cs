
using System;

class Employee
{
    public int EmployeeId;
    public string Name;
    public virtual double CalculateSalary()
    {
        return 0;
    }
}
class FullTimeEmployee : Employee
{
    public double MonthlySalary;
    public double HRA;
    public override double CalculateSalary()
    {
        HRA = MonthlySalary * 0.20;
        return MonthlySalary + HRA;
    }
}
class PartTimeEmployee : Employee
{
    public double HourlyRate;
    public int WorkingHours;

    public override double CalculateSalary()
    {
        return HourlyRate * WorkingHours;
    }
}
class ContractEmployee : Employee
{
    public double ProjectAmount;
    public double TaxPercentage;

    public override double CalculateSalary()
    {
        double tax = ProjectAmount * (TaxPercentage / 100);
        return ProjectAmount - tax;
    }
}
class EmployeeSalaryCalculation
{
    static void Main(string[] args)
    {
        FullTimeEmployee f = new FullTimeEmployee();
        f.EmployeeId = 101;
        f.Name = "John";
        f.MonthlySalary = 30000;
        if (f.MonthlySalary < 0)
        {
            Console.WriteLine("Salary cannot be negative");
        }
        else
        {
            double salary = f.CalculateSalary();
            Console.WriteLine("Full Time Employee");
            Console.WriteLine("Monthly Salary: " + f.MonthlySalary);
            Console.WriteLine("HRA: " + f.HRA);
            Console.WriteLine("Final Salary: " + salary);
        }
        PartTimeEmployee p = new PartTimeEmployee();
        p.EmployeeId = 102;
        p.Name = "Alice";
        p.WorkingHours = 100;
        p.HourlyRate = 200;
        if (p.WorkingHours < 0 || p.HourlyRate < 0)
        {
            Console.WriteLine("Values cannot be negative");
        }
        else
        {
            double salary = p.CalculateSalary();

            Console.WriteLine("\nPart Time Employee");
            Console.WriteLine("Working Hours: " + p.WorkingHours);
            Console.WriteLine("Hourly Rate: " + p.HourlyRate);
            Console.WriteLine("Final Salary: " + salary);
        }
        ContractEmployee c = new ContractEmployee();
        c.EmployeeId = 103;
        c.Name = "Mira";
        c.ProjectAmount = 50000;
        c.TaxPercentage = 10;
        if (c.ProjectAmount < 0 || c.TaxPercentage < 0 || c.TaxPercentage > 100)
        {
            Console.WriteLine("Invalid values");
        }
        else
        {
            double salary = c.CalculateSalary();
            double tax = c.ProjectAmount * (c.TaxPercentage / 100);

            Console.WriteLine("\nContract Employee");
            Console.WriteLine("Project Amount: " + c.ProjectAmount);
            Console.WriteLine("Tax: " + tax);
            Console.WriteLine("Final Salary: " + salary);
        }
    }
}

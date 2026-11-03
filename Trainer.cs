using System;
sealed class Employee
{
    public void ShowDetails()
    {
        Console.WriteLine("Employee Details: ");
    }
}
class Trainer : Employee
{
    public static void Main(String[] args)
    {
        Employee t = new Employee();
        t.ShowDetails();
    }
}

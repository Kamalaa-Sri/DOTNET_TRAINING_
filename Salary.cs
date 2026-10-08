class Salary
{
    public static void Calculate()
    {
        Console.Write("Enter your salary: ");
        int salary = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of days you were on leave: ");
        int leave = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your experience in years: ");
        int exp = Convert.ToInt32(Console.ReadLine());

        double salaryPerDay = salary / 26.0;
        int workingDays = 26 - leave;
        double newSalary = salaryPerDay * workingDays;

        if (exp > 5)
        {
            newSalary = (newSalary * 0.10) + newSalary;
            Console.WriteLine("Your Salary This Month is: " + newSalary);
        }
        else
        {
            Console.WriteLine("Your Salary This Month is: " + newSalary);
        }
    }
}

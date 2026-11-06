using System;
class Attendance
{
    private string studentName;
    private int totalWorkingDays;
    private int presentDays;
    public void SetStudentDetails(string name, int totalDays, int present)
    {
        studentName = name;
        totalWorkingDays = totalDays;
        if (present >= 0 && present <= totalWorkingDays)
        {
            presentDays = present;
        }
        else
        {
            Console.WriteLine("Invalid Present Days!");
        }
    }
    public void MarkAttendance()
    {
        if (presentDays < totalWorkingDays)
        {
            presentDays++;
        }
        else
        {
            Console.WriteLine("Working days limit reached!");
        }
    }
    public double CalculateAttendance()
    {
        if (totalWorkingDays == 0)
            return 0;

        return (double)presentDays / totalWorkingDays * 100;
    }
    public void CheckEligibility()
    {
        if (CalculateAttendance() >= 75)
            Console.WriteLine("Exam Eligibility: Eligible");
        else
            Console.WriteLine("Exam Eligibility: Not Eligible");
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Student: " + studentName);
        Console.WriteLine("Total Working Days: " + totalWorkingDays);
        Console.WriteLine("Present Days: " + presentDays);
        Console.WriteLine("Absent Days: " + (totalWorkingDays - presentDays));
        Console.WriteLine("Attendance Percentage: " + CalculateAttendance() + "%");
        CheckEligibility();
    }
}
class StudentAttendance
{
    static void Main(string[] args)
    {
        Attendance obj = new Attendance();

        obj.SetStudentDetails("Priya", 100, 85);

        obj.DisplayDetails();
    }
}

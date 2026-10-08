class Grade
{
    public static void Evaluate()
    {
        Console.Write("To calculate your grade, enter your mark: ");
        int mark = Convert.ToInt32(Console.ReadLine());
        char grade = 'O';

        if (mark >= 90)
        {
            grade = 'A';
        }
        else if (mark >= 80 && mark < 90)
        {
            grade = 'B';
        }
        else if (mark >= 70 && mark < 80)
        {
            grade = 'C';
        }
        else if (mark >= 60 && mark < 70)
        {
            grade = 'D';
        }
        else
        {
            grade = 'E';
        }

        Console.WriteLine("Your grade is: " + grade);
    }
}
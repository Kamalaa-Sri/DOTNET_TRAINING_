class Fee
{
    public static void Calculate()
    {
        Console.Write("Enter Your grade 12 percentage: ");
        int mark = Convert.ToInt32(Console.ReadLine());
        double academicFee = 100000;

        if (mark > 90)
        {
            academicFee *= 0.50;
            Console.WriteLine(academicFee);
        }
        else
        {
            Console.WriteLine(academicFee);
        }
    }
}
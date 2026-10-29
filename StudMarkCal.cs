
class StudMarkCal {
    public static void Main(string args[]) {
        try {
            int total = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter marks for subject " + i + ": ");
                int marks = Convert.ToInt32(Console.ReadLine());
                if (marks < 0 || marks > 100) {
                    throw new Exception("Marks must be between 0 and 100.");
                }
                total = total + marks;
            }
            double average = total / 5.0;
            Console.WriteLine("Total Marks = " + total);
            Console.WriteLine("Average = " + average);
            if (average >= 50) {
                Console.WriteLine("Result: PASS");
            }
            else{
                Console.WriteLine("Result: FAIL");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter numeric marks only.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        finally
        {
            Console.WriteLine("The calculation process has ended.");
        }
    }
}

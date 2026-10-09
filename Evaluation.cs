class Evaluation
{
    public static void Main(String[] args)
    {
        Console.Write("Hi, Enter your full name:");
        string name = Console.ReadLine();
        Console.WriteLine("Welcome to the evaluation process of your recent experience with your assesment, "+ name + "!");
        Console.Write("Please enter the marks that you have obtained in the APTITUDE test: ");
        int marks = Convert.ToInt32(Console.ReadLine());
        if (marks > 70)
        {
            Console.WriteLine("Congratulations! You have passed the APTITUDE test. Now enter the marks that you have obtained in the TECHNICAL test: ");
            int technicalMarks = Convert.ToInt32(Console.ReadLine());
            if (technicalMarks > 80)
            {
                Console.WriteLine("Congratulations! You have passed the TECHNICAL test as well. Now enter the marks that you have obtained in the INTERVIEW: ");
                int interviewMarks = Convert.ToInt32(Console.ReadLine());
                if (interviewMarks > 80)
                {
                    Console.WriteLine("Congratulations! You have passed the INTERVIEW as well. You are selected for the job.");
                }
                else
                {
                    Console.WriteLine("Unfortunately, you have not passed the INTERVIEW.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Unfortunately, you have not passed the TECHNICAL test.");
                break;
            }
        }
        else
        {
            Console.WriteLine("Unfortunately, you have not passed the APTITUDE test.");
            break;
        }
        
    }
}

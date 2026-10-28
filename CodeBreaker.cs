class CodeBreaker {
    public static void Main() {
        Random r = new Random();
        string play = "yes";
        for (; play == "yes"; ) {
            int secret = r.Next(1000, 10000);
            int guess = 0;
            int score = 0;
            int correct = 0;
            Console.WriteLine("Crack the 4-digit secret code!");
            Console.WriteLine("You have 15 attempts.");
            for (int i = 1; i <= 15; i++) {
                Console.Write("Enter your 4-digit guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                int s1 = secret / 1000;
                int s2 = (secret / 100) % 10;
                int s3 = (secret / 10) % 10;
                int s4 = secret % 10;
                int g1 = guess / 1000;
                int g2 = (guess / 100) % 10;
                int g3 = (guess / 10) % 10;
                int g4 = guess % 10;
                correct = 0;
                if (g1 == s1) {
                    correct++;
                }
                if (g2 == s2){
                    correct++;
                }
                if (g3 == s3){
                    correct++;
                }
                if (g4 == s4){
                    correct++;
                }
                Console.WriteLine("Correct digits in correct positions: " + correct);
                Console.WriteLine("Attempts remaining: " + (15 - i));
                if (guess == secret){
                    Console.WriteLine("Congratulations! Code cracked!");
                    score = (11 - i) * 10;
                    Console.WriteLine("Your score: " + score);
                    break;
                }
                if (i == 10) {
                    Console.WriteLine("Game over!");
                    Console.WriteLine("Secret code: " + secret);
                    Console.WriteLine("Your score: 0");
                }
            }
            Console.Write("Try a new code? (yes/no): ");
            play = Console.ReadLine().ToLower();
        }
        Console.WriteLine("Thanks for playing!");
    }
}

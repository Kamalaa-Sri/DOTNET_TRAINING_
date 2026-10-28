class NumGuessGame {
    public static void Main() {
        Random r = new Random();
        string play = "yes";
        for (; play == "yes"; ) {
            int num = r.Next(1, 101);
            int guess = 0;
            int score = 0;
            Console.WriteLine("Guess a number between 1 and 100");
            for (int i = 1; i <= 7 && guess != num; i++) {
                Console.Write("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess > num) {
                    Console.WriteLine("Too high!");
                }
                else if (guess < num) {
                    Console.WriteLine("Too low!");
                }
                else {
                    Console.WriteLine("Correct guess!");

                    score = (8 - i) * 10;

                    Console.WriteLine("Your score: " + score);
                }
            }
            if (guess != num) {
                Console.WriteLine("Game over!");
                Console.WriteLine("The number was: " + num);
                Console.WriteLine("Your score: 0");
            }
            Console.Write("Play again? yes/no: ");
            play = Console.ReadLine().ToLower();
        }
        Console.WriteLine("Thanks for playing!");
    }
}

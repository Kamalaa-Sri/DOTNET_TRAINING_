class LoginSystem{
    public static void Main(string[] args)
    {
        string username = "kamalaasri";
        string pass = "1234@!Abcd";
        Console.WriteLine("      Login      ");
        try {
            for (int i = 1; i <= 3; i++) {
                Console.Write("Username: ");
                string username1 = Console.ReadLine();
                Console.Write("Password: ");
                string pass1 = Console.ReadLine();
                if (username1 != username || pass1 != pass){
                    throw new Exception("Username or password doesn't match!");
                    Console.WriteLine("Try again! you have " +(3-i)+ " attempts");
                }
                else {
                    Console.WriteLine("Login successful!");
                    break;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Process Complete");
        }
    }
}
class BankAccount
{
    private double balance;
    public BankAccount(double initialBalance) {
        balance = initialBalance;
    }
    public void Deposit(double amount) {
        if (amount <= 0) {
            throw new ArgumentException(
                "Deposit amount must be greater than zero.");
        }
        balance += amount;
        Console.WriteLine("Deposit successful.");
    }
    public void Withdraw(double amount) {
        if (amount <= 0) {
            throw new ArgumentException(
                "Withdrawal amount must be greater than zero.");
        }
        if (amount > balance) {
            throw new InvalidOperationException(
                "Insufficient balance.");
        }
        balance -= amount;
        Console.WriteLine("Withdrawal successful.");
    }
    public void CheckBalance() {
        Console.WriteLine("Current Balance = " + balance);
    }
    public static void Main(string[] args) {
        BankAccount account = new BankAccount(1000);
        try {
            Console.Write("Enter your choice: ");
            Console.WriteLine("Enter 1 for Deposit, 2 for Withdraw, and 3 for Checking balance");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) {
                case 1:
                    Console.Write("Enter deposit amount: ");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
                    account.Deposit(depositAmount);
                    break;
                case 2:
                    Console.Write("Enter withdrawal amount: ");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                    account.Withdraw(withdrawAmount);
                    break;
                case 3:
                    account.CheckBalance();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
        catch (FormatException) {
            Console.WriteLine(
                "Invalid input! Please enter numeric values.");
        }
        catch (ArgumentException e) {
            Console.WriteLine("Transaction failed: " + e.Message);
        }
        catch (InvalidOperationException e) {
            Console.WriteLine("Transaction failed: " + e.Message);
        }
        finally{
            Console.WriteLine("Transaction process completed.");
            account.CheckBalance();
        }
    }
}


class BankOperation {
    private int balance = 10000;
    private int amount;
    public void SetAmount(int amount) {
        if (amount > 0) {
            this.amount = amount;
        }
        else {
            throw new Exception("Invalid Amount!");
        }
    }
    public void Deposit() {
        balance += amount;
        Console.WriteLine("Amount Deposited Successfully!");
    }
    public void Withdraw() {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Amount Withdrawn Successfully!");
        }
        else if (amount <= 0)
        {
            throw new Exception("Invalid Withdrawal Amount!");
        }
        else
        {
            throw new Exception("Insufficient Balance!");
        }
    }
    public int GetBalance() {
        return balance;
    }
}
class BankEncapswithLog {
    public static void Main(string[] args) {
        BankOperation b = new BankOperation();

        string filePath = "C:\\Users\\kamalaa\\OneDrive\\Documents\\Desktop\\Csharp\\BankLog.txt";
        string operation = "no_operation";
        string status = "Failure";
        try {
            Console.Write("Enter 1 for deposit and 2 for withdraw: ");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op) {
                case 1:
                    operation = "Deposit";
                    Console.Write("Enter Deposit Amount: ");
                    int deposit = Convert.ToInt32(Console.ReadLine());
                    b.SetAmount(deposit);
                    b.Deposit();
                    status = "Success";
                    break;
                case 2:
                    operation = "Withdraw";
                    Console.Write("Enter Withdrawal Amount: ");
                    int withdraw = Convert.ToInt32(Console.ReadLine());
                    b.SetAmount(withdraw);
                    b.Withdraw();
                    status = "Success";
                    break;
                default:
                    operation = "Invalid Operation";
                    throw new Exception("Invalid operation selected!");
            }
            Console.WriteLine("Final Balance: " + b.GetBalance());
        }
        catch (FormatException e) {
            Console.WriteLine("Please enter numeric values!");
            bankTransaction(filePath, operation, status,"Invalid input: " + e.Message);
        }
        catch (Exception e) {
            Console.WriteLine("Error: " + e.Message);
            bankTransaction(filePath, operation, status, e.Message);
        }
        finally {
            Console.WriteLine("Transaction Completed!");
        }
        if (status == "Success") {
            bankTransaction(filePath, operation, status, "No error");
        }
    }
    static void bankTransaction(string filePath, string operation, string status, string message) {
        string content = "Date and Time: " + DateTime.Now + " Operation: " + operation +" Status: " + status + " Message: " + message;
        File.AppendAllText(filePath, content);
    }
}

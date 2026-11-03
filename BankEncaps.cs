using System;
class BankOperation {
    private int balance=10000;
    private int amount;
    public void setAmount(int amount)
    {
        if (amount > 0)
        {
            this.amount=amount;
        }
        else
        {
            throw new Exception("Invalid Deposit Amount!");
        }
    }
    public void Deposit() {
     
            balance += amount;
            Console.WriteLine("Amount Deposited Successfully!");
    }
    public void Withdraw()
    {
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
    public int GetBalance()
    {
        return balance;
    }
}
class BankEncaps {
    static void Main()
    {
        BankAccount b = new BankAccount();
        try
        {
            Console.Write("Enter 1 for deposit and 2 for withdraw: ");
            int op = Convert.ToInt32(Console.ReadLine());
            switch(op){
                case 1:
                    Console.Write("Enter Deposit Amount: ");
                    int deposit = Convert.ToInt32(Console.ReadLine());
                    b.setAmount(deposit);
                    b.Deposit();
                    break;
                case 2:
                    Console.Write("Enter Withdrawal Amount: ");
                    int withdraw = Convert.ToInt32(Console.ReadLine());
                    b.setAmount(withdraw);
                    b.Withdraw();
                    break;
                default:
                    Console.WriteLine("Invalid!");
                    break;
            }
            Console.WriteLine("Final Balance: " + b.GetBalance());
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter numeric values!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Transaction Completed!");
        }
    }
}
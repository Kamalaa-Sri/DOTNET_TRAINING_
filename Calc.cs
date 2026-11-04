using System;    
using System.Threading;
class Calculator
{
    public static void Add(int a, int b)
    {
        Console.WriteLine("Addition of two numbers is: " + (a + b));
        Thread.Sleep(5000);
        Console.WriteLine(Thread.CurrentThread.Name);
        Console.WriteLine("Addition has completed its task");
    }
    public static void Subtract(int a, int b)
    {
        Console.WriteLine("Subtraction of two numbers is: " + (a - b));
        Thread.Sleep(3000);
        Console.WriteLine(Thread.CurrentThread.Name);
        Console.WriteLine("Subtraction has completed its task");

    }
    public void Multiply(int a, int b)
    {
        Console.WriteLine("Multiplication of two numbers is: " + (a * b));
        Thread.Sleep(2000);
        Console.WriteLine(Thread.CurrentThread.Name);
        Console.WriteLine("Multiplication has completed its task");
    }
    public void Divide(int a, int b)
    {
        Console.WriteLine("Division of two numbers is: " + (a / b));
        Thread.Sleep(1000);
        Console.WriteLine(Thread.CurrentThread.Name);
        Console.WriteLine("Division has completed its task");
    }

}
public class Calc
{
    static void Main(string[] args)
    {
        Calculator c = new Calculator();
        Thread t1 = new Thread(() => Calculator.Add(10, 5));
        Thread t2 = new Thread(() => Calculator.Subtract(10, 5));
        Thread t3 = new Thread(() => c.Multiply(10, 5));
        Thread t4 = new Thread(() => c.Divide(10, 5));
        t1.Name = "Addition Thread";
        t2.Name = "Subtraction Thread";
        t3.Name = "Multiplication Thread";
        t4.Name = "Division Thread";
        t1.Start();
        t2.Start();
        t3.Start();
        t4.Start();
        Console.WriteLine("Threads are completed");
    }
}
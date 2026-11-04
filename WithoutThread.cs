using System;
using System.Threading;
class WithoutThread
{
    static void Display()
    {
        Console.WriteLine("Thread is running");
        Thread.Sleep(5000);
        Console.WriteLine("Thread has completed its task");     
    }
    static void Show()
    {
        Console.WriteLine("Thread2 is running");
        Thread.Sleep(2000);
        Console.WriteLine("Thread2 has completed its task");
    }

    static void Main()
    {
        Thread t1 = new Thread(Display);
        Thread t2 = new Thread(Show);
        t1.Start();
        t2.Start();
        Console.WriteLine("Threads are completed");
    }
}

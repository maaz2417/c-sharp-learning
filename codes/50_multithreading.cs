using System;
using System.Threading;

// Create two threads, each with its own method to run
Thread thread1 = new Thread(CountUp);
Thread thread2 = new Thread(CountDown);

// Start both threads
thread1.Start();
thread2.Start();

Console.WriteLine("Both worker threads have started.");

// Wait for both threads to finish
thread1.Join();
thread2.Join();

Console.WriteLine("All counting finished!");

static void CountUp()
{
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine($"Counting up: {i}");
        Thread.Sleep(500);
    }
}

static void CountDown()
{
    for (int i = 5; i >= 1; i--)
    {
        Console.WriteLine($"Counting down: {i}");
        Thread.Sleep(500);
    }
}
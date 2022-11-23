// See https://aka.ms/new-console-template for more information
using MultiThreadingDemo;

Console.WriteLine("Hello, World!");

Multithreading obj = new Multithreading();
//obj.Method2();
//obj.Method3();
//obj.Method1();


Console.WriteLine("Main Thread Started");
//Creating Threads
Thread t1 = new Thread(obj.Method1)
{
    Name = "Thread1"
};

         Thread t2 = new Thread(obj.Method2)
        {
            Name = "Thread2"
        };
        Thread t3 = new Thread(obj.Method3)
        {
            Name = "Thread3"
        };
        //Executing the methods
        t1.Start();
        t2.Start();
        t3.Start();
        Console.WriteLine("Main Thread Ended");
        Console.Read();
    
   

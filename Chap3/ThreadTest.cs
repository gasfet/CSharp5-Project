using System;
using System.Threading;

public class Worker
{
    private volatile bool Stop;
    public void DoWork()
    {
        while (!Stop)
        {
            Console.WriteLine("사용자 스레드 실행");
        }
        Console.WriteLine("사용자 스레드 다이...");
    }
    public void RequestStop()
    {
        Stop = true;
    }
}

public class ThreadTest
{
    static void Main()
    {
        Worker wObj = new Worker();
        Thread MyThread = new Thread(wObj.DoWork);

        MyThread.Start();
        Console.WriteLine("기본 스레드 실행");

        while (!MyThread.IsAlive) ;

        Thread.Sleep(1);

        wObj.RequestStop();

        MyThread.Join();
        Console.WriteLine("마무리...");
    }
}
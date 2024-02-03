using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Spinner
{
    private readonly Thread spinnerThread;
    private bool isSpinning;

    public Spinner()
    {
        spinnerThread = new Thread(Spin);
        isSpinning = false;
    }

    public void Start()
    {
        if (!isSpinning)
        {
            isSpinning = true;
            spinnerThread.Start();
        }
    }

    public void Stop()
    {
        isSpinning = false;
        spinnerThread.Join();
    }

    private void Spin()
    {
        while (isSpinning)
        {
            Console.Write("/");
            Thread.Sleep(100);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(100);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(100);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(100);
            Console.Write("\b");
        }
    }
}

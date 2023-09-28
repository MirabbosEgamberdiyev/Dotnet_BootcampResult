using System.Threading;
using System;

namespace _17_dars._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(SomeTask);
            thread.Name = "Custom Thread";
            thread.IsBackground = true;
            thread.Start();
            //thread.Join();
            //thread.Abort();
            thread.Suspend();
            Console.WriteLine(thread.Name);
            Console.WriteLine(thread.ThreadState);
            Console.WriteLine(thread.IsAlive);
            //Console.WriteLine(thread.IsBackground);
            Console.WriteLine(thread.ManagedThreadId);
            Console.WriteLine();
            thread.Resume();
            Console.WriteLine(thread.ThreadState);
            Console.WriteLine(thread.IsAlive);
            //Console.WriteLine(thread.IsBackground);
            Console.WriteLine(thread.ManagedThreadId);
            //var res = SomeAsync();
            Console.WriteLine();
            Console.WriteLine("Current thread");
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "main";
            Console.WriteLine(mainThread.Name);
            Console.WriteLine(mainThread.ManagedThreadId);
            Console.WriteLine(mainThread.ThreadState);
            Console.WriteLine(mainThread.IsAlive);
            Console.WriteLine(mainThread.IsBackground);
            Console.WriteLine("\nNext command");
            string s = Console.ReadLine();
            Console.WriteLine(s);


            void SomeTask()
            {
                //while(true)
                //{
                //    Console.WriteLine(DateTime.Now);
                //    Thread.Sleep(1000);
                //}
                Thread.Sleep(2000);
            }
        }
    }
}

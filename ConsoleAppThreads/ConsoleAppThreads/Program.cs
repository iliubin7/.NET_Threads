using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppThreads
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            int n = 10;
            Thread[] threads = new Thread[n];
            for (int i = 0; i < n; i++)
            {
                threads[i] = new Thread(Hello);
                threads[i].Name = String.Format("Thread: {0}", i);
            }
            foreach (Thread x in threads)
            {
                x.Start();
                if (x == threads[7])
                {
                    Thread.Sleep(1000);
                }
            }
            Console.WriteLine("Before thread or after?");
            Console.Read();
        }
        static void Hello()
         {
          Console.WriteLine("Hello " + Thread.CurrentThread.Name + " !");
         }
        
    }
}

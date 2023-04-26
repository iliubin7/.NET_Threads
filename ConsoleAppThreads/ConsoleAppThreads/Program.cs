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
            Thread thread = new Thread(Hello);
            thread.Start();
            Console.Read();
        }
        static void Hello()
         {
          Console.WriteLine("Hello");
         }
        
    }
}

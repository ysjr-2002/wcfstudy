using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.CaseClient client = new ServiceReference1.CaseClient();
            client.AddCase();
            Console.WriteLine("call over");


            var sw = Stopwatch.StartNew();
            var buffer = client.GetBuffer();
            sw.Stop();
            Console.WriteLine("buffer length:" + buffer.Length + " " + sw.ElapsedMilliseconds);


            Console.WriteLine(client.State);

            Console.Read();
        }
    }
}

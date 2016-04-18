using HzDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;

namespace ConsoleWsDualHttpHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple();
            ServiceHost host = new ServiceHost(apple);
            try
            {
                Console.WriteLine("service starting...");
                host.Open();
                foreach (Uri uri in host.BaseAddresses)
                {
                    Console.WriteLine("基地址：" + uri.ToString());
                }
                Console.WriteLine("service started");

                string s = "";
                while ((s = Console.ReadLine()) !="e")
                {
                    if (s == "s")
                    {
                        apple.CallClient();
                    }
                    else
                        Console.WriteLine(s);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}

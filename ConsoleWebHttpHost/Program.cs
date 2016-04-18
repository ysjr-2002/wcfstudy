﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace ConsoleWsHttpHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ResutService.ServiceType));
            try
            {
                Console.WriteLine("service starting...");
                host.Open();
                foreach (Uri uri in host.BaseAddresses)
                {
                    Console.WriteLine("基地址：" + uri.ToString());
                }
                Console.WriteLine("service started");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}

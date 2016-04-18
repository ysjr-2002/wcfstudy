using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace ConsoleNettcpHost
{
    class Program
    {
        static void Main(string[] args)
        {
            StartNetTcp();
            StartNetTcpProgramer();
            StartBaseHttp();

            Console.Read();
        }

        static void StartNetTcp()
        {
            ServiceHost host = new ServiceHost(typeof(HzDataService.CaseService));
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
        }

        static void StartNetTcpProgramer()
        {
            ServiceHost host = new ServiceHost(typeof(HzDataService.ProgramerService));
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
        }

        static void StartBaseHttp()
        {
            ServiceHost host = new ServiceHost(typeof(HzDataService.DeparmentService));
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
        }
    }
}

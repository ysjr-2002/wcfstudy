using ConsoleNettcpTest.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ConsoleNettcpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ICaseCall();
            //IUserCall();
            //ICameraCall();

            //IDeptCall();

            //IProgramerCall();

            Console.Read();
        }

        static void ICaseCall()
        {
            ServiceReference1.CaseClient client = new ServiceReference1.CaseClient();
            client.AddCase();
            Console.WriteLine("call over");

            client.AddCase();
            Console.WriteLine("call over");

            client.AddCase();
            Console.WriteLine("call over");

            //var sw = Stopwatch.StartNew();
            //var buffer = client.GetBuffer();
            //sw.Stop();
            //Console.WriteLine("buffer length:" + buffer.Count + " " + sw.ElapsedMilliseconds);

            Console.WriteLine(client.State);
        }

        static void IUserCall()
        {
            ServiceReference1.UserClient client = new ServiceReference1.UserClient("IUserEndPoint");

            UserInfo user = new UserInfo { Name = "client", Age = 89 };

            var list = client.GetUsers();
            Console.WriteLine("WCF返回数据集合=" + list.Count);
            foreach (var item in list)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
            client.Add(user);
        }

        static void ICameraCall()
        {
            ServiceReference1.CameraClient client = new CameraClient();

            client.AddCamera();
        }

        static void IDeptCall()
        {
            ServiceReference2.DeptClient client = new ServiceReference2.DeptClient();
            client.Add();
        }

        static void IProgramerCall()
        {
            ServiceReference3.ProgramerClient client = new ServiceReference3.ProgramerClient();
            client.WriteCode();
        }
    }
}

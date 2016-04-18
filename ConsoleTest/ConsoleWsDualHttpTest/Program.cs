using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace ConsoleWsDualHttpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Heart bit = new Heart();
            InstanceContext context = new InstanceContext(bit);
            ServiceReference1.PhoneClient client = new ServiceReference1.PhoneClient(context);
            client.Call();
            Console.WriteLine("client call over");
            Console.Read();
        }
    }

    class Heart : ServiceReference1.IPhoneCallback
    {
        public void HeartBit(int number)
        {
            Console.WriteLine("server call back:" + number);
        }
    }
}

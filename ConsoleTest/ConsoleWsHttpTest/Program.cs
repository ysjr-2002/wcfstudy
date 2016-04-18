using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.ServiceModel.Channels;
using System.Diagnostics;
using HzDataService;
namespace ConsoleWsHttpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //ServiceReference1.CaseClient client = new ServiceReference1.CaseClient();
            //client.AddCase();
            //Console.WriteLine("call over");

            //var sw = Stopwatch.StartNew();
            //var buffer = client.GetBuffer();
            //sw.Stop();
            //Console.WriteLine("buffer length:" + buffer.Length + " " + sw.ElapsedMilliseconds);

            //Console.WriteLine(client.State);

            ServiceClient client = new ServiceClient();
            client.AddCase();

            client.GetBuffer();

            Console.Read();
        }
    }

    class ServiceClient : ClientBase<ICase>, ICase
    {
        static WSHttpBinding ws = new WSHttpBinding
        {
            Security = new WSHttpSecurity() { Mode = SecurityMode.None },
            MaxReceivedMessageSize = 2147483647
        };
        static EndpointAddress address = new EndpointAddress("http://localhost:5566/myway");

        public ServiceClient()
            : base(ws, address)
        {
        }

        public void AddCase()
        {
            Channel.AddCase();
        }

        public int[] GetBuffer()
        {
            return Channel.GetBuffer();
        }
    }

}

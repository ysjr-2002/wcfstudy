using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading;
using System.ServiceModel.Channels;
namespace HzDataService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Apple : IPhone, IDisposable
    {
        public static List<OperationContext> staticlist = new List<OperationContext>();
        List<OperationContext> clientlist = new List<OperationContext>();
        Dictionary<string, OperationContext> dict = new Dictionary<string, OperationContext>();
        public void Call()
        {
            OperationContext context = null;
            if (context == null)
            {
                context = OperationContext.Current;
                MessageProperties properties = context.IncomingMessageProperties;
                RemoteEndpointMessageProperty endpoint = properties[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
                Console.WriteLine("address:{0} port:{1}", endpoint.Address, endpoint.Port);
                clientlist.Add(context);
                staticlist.Add(context);
            }
            else
            {
                if (context == OperationContext.Current)
                {
                    Console.WriteLine("同一个实例");
                }
                else
                {
                    clientlist.Add(OperationContext.Current);
                }
            }
            Console.WriteLine("session Id:" + OperationContext.Current.SessionId);
            Console.WriteLine("apple call");
        }


        public void CallX()
        {
            foreach (OperationContext item in clientlist)
            {
                var x = item.GetCallbackChannel<IHeart>();
                x.HeartBit(new Random().Next(1, 100));
                Console.WriteLine("applie call over");
            }
        }

        public static void CallStaticX()
        {
            foreach (OperationContext item in staticlist)
            {
                var x = item.GetCallbackChannel<IHeart>();
                x.HeartBit(new Random().Next(1, 100));
                Console.WriteLine("static applie call over");
            }
        }

        public void Dispose()
        {
            Console.WriteLine("dispose");
        }
    }
}

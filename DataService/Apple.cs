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
        List<OperationContext> clientlist = new List<OperationContext>();
        public void Call()
        {
            OperationContext context = null;
            context = OperationContext.Current;
            MessageProperties properties = context.IncomingMessageProperties;
            RemoteEndpointMessageProperty endpoint = properties[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
            Console.WriteLine("address:{0} port:{1}", endpoint.Address, endpoint.Port);
            clientlist.Add(context);

            Console.WriteLine("session Id:" + OperationContext.Current.SessionId);
            Console.WriteLine("apple call");
        }


        public void CallClient()
        {
            foreach (OperationContext item in clientlist)
            {
                var x = item.GetCallbackChannel<IHeart>();
                x.HeartBit(new Random().Next(1, 100));
                Console.WriteLine("applie call over");
            }
        }


        public void Dispose()
        {
            Console.WriteLine("dispose");
        }
    }
}

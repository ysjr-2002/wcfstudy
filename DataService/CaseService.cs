using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Model;
using System.ServiceModel;
namespace HzDataService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class CaseService : ICase, IUser, ICamera, IDisposable
    {
        private int count = 0;
        public CaseService()
        {
            Console.WriteLine("new instance");
        }
        public void AddCase()
        {
            Console.WriteLine("add case" + OperationContext.Current.SessionId);
            count++;
            Console.WriteLine(count);
        }

        public void Dispose()
        {
            Console.WriteLine("dispose");
        }

        public int[] GetBuffer()
        {
            int[] buffer = Enumerable.Range(1, 999998).ToArray();
            return buffer;
        }

        public IList<UserInfo> GetUsers()
        {
            List<UserInfo> list = new List<UserInfo>
            {
                new UserInfo{ Name="ysj",Age=35},
                new UserInfo{ Name="dgl",Age=36},
                new UserInfo{ Name="ylz",Age=5}
            };

            return list;
        }

        public void Add(UserInfo user)
        {
            Console.WriteLine(user.Name + " " + user.Age);
        }

        public void AddCamera()
        {
            Console.WriteLine("add camera");
        }
    }
}

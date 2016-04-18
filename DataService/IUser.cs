using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace HzDataService
{
   [ServiceContract]
    public interface IUser
    {
       [OperationContract]
       IList<UserInfo> GetUsers();
       [OperationContract]
       void Add(UserInfo user);
    }
}

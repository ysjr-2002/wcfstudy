using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace HzDataService
{

    [ServiceContract(CallbackContract = typeof(IHeart), SessionMode = SessionMode.Allowed)]
    public interface IPhone
    {
        [OperationContract]
        void Call();

        void CallX();
    }

    public interface IHeart
    {
        [OperationContract(IsOneWay = true)]
        void HeartBit(int number);
    }
}

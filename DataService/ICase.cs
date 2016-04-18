using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace HzDataService
{
    [ServiceContract(SessionMode = SessionMode.Allowed)]
    public interface ICase
    {
        [OperationContract]
        void AddCase();

        [OperationContract]
        int[] GetBuffer();
    }
}

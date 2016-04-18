using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ResutService
{
    [ServiceContract(SessionMode = SessionMode.NotAllowed)]
    public interface IContractName
    {
        [WebGet(UriTemplate = "date/{year}/{month}/{day}", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        string GetDate(string day, string month, string year);

        [WebGet(UriTemplate = "Sub?x={x}&y={y}", ResponseFormat = WebMessageFormat.Xml)]
        [OperationContract]
        long Subtract(string x, string y);
    }
}

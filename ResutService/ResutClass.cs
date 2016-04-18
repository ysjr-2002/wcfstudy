using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResutService
{
    public class ServiceType : IContractName
    {
        public string GetDate(string day, string month, string year)
        {
            return new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)).ToString("yyyy-MM-dd HH:mm:ss");
        }


        public long Subtract(string x, string y)
        {
            var ix = Convert.ToInt32(x);
            var iy = Convert.ToInt32(y);

            return ix + iy;
        }
    }
}

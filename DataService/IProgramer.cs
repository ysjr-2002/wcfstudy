﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace HzDataService
{
    [ServiceContract]
    public interface IProgramer
    {
        [OperationContract]
        void WriteCode();
    }
}

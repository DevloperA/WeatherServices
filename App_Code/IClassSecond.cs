using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

[ServiceContract]
public interface IClassSecond
{
    [OperationContract]
    int Mul();
}
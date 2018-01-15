using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

[ServiceContract]
public interface IClassFirst
{
    [OperationContract]
    int Sum();
    [OperationContract]
    int Sub();
}
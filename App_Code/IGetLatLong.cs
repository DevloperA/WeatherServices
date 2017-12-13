using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Summary description for ITempService
/// </summary>
[ServiceContract]
public interface IGetLatLong
{
    [OperationContract]
    LatLong getlatlong(string StateOrCity);
}

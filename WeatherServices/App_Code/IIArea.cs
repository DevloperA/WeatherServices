using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Summary description for iAreaSquare
/// </summary>

[ServiceContract]
public interface IIArea
{
    [OperationContract]
    double AreaofSquare(double sides);

    [OperationContract]
    double AreaofRectangle(double length, double breadth);

    [OperationContract]
    double GetSpeed(double distance, double time);

    [OperationContract]
    double GetDistance(double speed, double time);
}
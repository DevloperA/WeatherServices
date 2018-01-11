using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWeatherService" in both code and config file together.
[ServiceContract]
public interface IWeatherService
{
    [OperationContract]
    WeatherReports getWeatherData(string city_name, string state_name);

    [OperationContract]
    double AreaSquare(double sides);

    [OperationContract]
    double AreaRectangle(double length, double breadth);

    [OperationContract]
    double GetSpeed(double distance, double time);

    [OperationContract]
    double GetDistance(double speed, double time);

    [OperationContract]
    double GetTime(double distance, double speed);

    [OperationContract]
    string Concat(string firtname, string lastname);

    [OperationContract]
    int Add(int value1, int value2);

    [OperationContract]
    int Multiply(int value1, int value2);

    [OperationContract]
    int Divide(int value1, int value2);

    [OperationContract]
    int Modulus(int value1, int value2);

    [OperationContract]
    int sum(int value);
    [OperationContract]
    int sum2(int value, int value2);
    [OperationContract]
    int sum3(int balance);
    [OperationContract]
    int sum4(int balance);
    [OperationContract]
    int sum5(int balance);
    [OperationContract]
    int sum6(int value);
    [OperationContract]
    int Sum7(int value, int value2);
    [OperationContract]
    int sum8(int balance);
    [OperationContract]
    int sum9(int balance);
    [OperationContract]
    int sum10(int balance);
}

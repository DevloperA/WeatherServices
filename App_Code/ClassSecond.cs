using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Activation;
using System.Web;

[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WeatherService" in code, svc and config file together.

public class ClassSecond :IClassSecond
{
   public int Mul()
    {
        int a = 20 * 2;
        return a;
    }
    public int Div()
    {
        int a = 20 / 2;
        return a;
    }

    public string Concat()
    {
        string s = "Firstname" + " " + "Lastname";
        return s;
    }
}
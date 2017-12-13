using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Activation;
using Newtonsoft.Json;

/// <summary>
/// Summary description for CityService
/// </summary>
public class GetLatLong : IGetLatLong
{
    public LatLong getlatlong(string stateOrCity)
    {
        string output;
        LatLong lst = new LatLong();
        using (WebClient client = new WebClient())
        {
            string input = "http://autocomplete.wunderground.com/aq?query=" + stateOrCity;
            output = client.DownloadString(input);
            lst = JsonConvert.DeserializeObject<LatLong>(output);
            return lst;
        }

    }
}
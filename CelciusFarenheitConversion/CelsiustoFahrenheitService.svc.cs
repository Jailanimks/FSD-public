using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CelciusFarenheitConversion
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CelsiustoFahrenheitService : ICelsiustoFahrenheit
    {
       public Double CelciusToFarenheit(double temp)
        {
            double farenheit;
            farenheit = temp * 9 / 5 + 32;
            return farenheit;
        }

        
        public Double FarenheitToCelcius(double temp)
        {
            double celcius;
            celcius = (temp - 32) * 5 / 9;
            return celcius;
        }

    }
}

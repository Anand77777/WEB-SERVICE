using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace REST2
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public string FahrenheitToCelsius(string Fahrenheit)
        {
            object fahr = null;
            fahr = Fahrenheit.Replace(",", ".").Trim(' ');
            if (fahr == "string")
            {
                return "Error";
            }
            int returnVal = ((((Convert.ToInt32(fahr)) - 32) / 9) * 5);
            return returnVal.ToString();
        }

        [WebMethod]
        public string CelsiusToFahrenheit(string Celsius)
        {
            object cel = null;
            cel = Celsius.Replace(",", ".").Trim(' ');
            if (cel == "string")
            {
                return "Error";
            }
            int returnVal = ((((Convert.ToInt32(cel)) * 9) / 5) + 32);
            return returnVal.ToString();
        }
    }
}
       
 

using Microsoft.AspNetCore.Mvc;
using System;
using ASPCoreWebCars.Models;  //Format [yourProjectName]/Models
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;
using System.Web.

namespace ASPCoreWebCars.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // POST: Car/Get
        [HttpPost]

        //This is called by the view, it will send the numberplate as a parameter
        public string GetCarData(string numberPlate)
        {
            //Returns MOTData called by the JS in the MOTview.cshtml page 

            //Target URL - number plate is last argument
            //https://uk1.ukvehicledata.co.uk/api/datapackage/VehicleData?v=2&api_nullitems=1&auth_apikey=632f5ba5-4a48-43ef-9458-ef6ca3dc74eb&user_tag=&key_VRM=py64auj

            //Complete URL
            string url = string.Format("https://uk1.ukvehicledata.co.uk/api/datapackage/VehicleData?v=2&api_nullitems=1&auth_apikey=632f5ba5-4a48-43ef-9458-ef6ca3dc74eb&user_tag=&key_VRM=" + numberPlate);


            using (System.Net.WebClient client = new WebClient())
            {
                try
                {

                    string json = client.DownloadString(url);  //Actually downloads the data in json format.
                                                               //Only usable in an ASPWebApp environment!  Not avaliable in regular MVC

                    //Remove null values
                    var settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        MissingMemberHandling = MissingMemberHandling.Ignore
                    };


                    //Read in the raw data, parse it and organise it and store it in an object called organisedData
                    var oranisedData = JsonConvert.DeserializeObject<RawCarData.Rootobject>(json, settings);

                    
                   

                    //Converting OBJECT to JSON String   
                    var jsonstring = new JavaScriptSerializer().Serialize(rslt);

                    //Return JSON string.  
                    return jsonstring;
                }
                catch (HttpRequestException) // Non success
                {
                    return ("An error occurred.");
                }
                catch (NotSupportedException) // When content type is not valid
                {
                    return ("The content type is not supported.");
                }
                catch (JsonException) // Invalid JSON
                {
                    return ("Invalid JSON.");
                }
            }

        }

    }
}

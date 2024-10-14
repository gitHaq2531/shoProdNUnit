using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoProd.GenericUtility
{
    internal class jsonUtility
    {
        public string GetDataFromJsonFile(string key)
        {
            // to read all the data from json files.... there provide path of json file
            string json = File.ReadAllText("path");

            // to convert string data in json format...
            JToken token = JToken.Parse(json);

          
                //to get data from key...
                string data = token.SelectToken(key).Value<string>();
           
            return data;
            
        }
    }
}

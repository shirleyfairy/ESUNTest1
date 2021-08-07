using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net;
using System.Text;
using ESUNTest1.Models;
using Newtonsoft.Json;

namespace ESUNTest1.Controllers
{
    public class APIUtil
    {
         public JsonData GetEsunModel()
        {
            JsonData data = JsonConvert.DeserializeObject<JsonData>(CreateAPIString());
            return data;
        }

        public String GetGEsunStrData()
        {
            return CreateAPIString();
        }
        private String CreateAPIString()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://od.moi.gov.tw/api/v1/rest/datastore/301000000A-001661-005");
            request.Method = WebRequestMethods.Http.Get;
            request.ContentType = "application/json";
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (var stream = response.GetResponseStream())
                    using (var reader = new StreamReader(stream))
                    {
                        var temp = reader.ReadToEnd();
                        Console.WriteLine(temp);
                        return temp;
                        //NewCart cart = JsonConvert.DeserializeObject<NewCart>(temp);
                        //return cart;
                    }
                }
                else
                {
                    return null;
                }
            }
        }
        
    }
}
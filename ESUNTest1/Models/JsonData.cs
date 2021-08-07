using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace ESUNTest1.Models
{
    public class JsonData
    {
        [JsonProperty(PropertyName = "success")]
        public String Success { get; set; }

        [JsonProperty(PropertyName = "result")]
        public ResultData Result { get; set; }
    }
}
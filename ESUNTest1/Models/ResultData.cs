using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESUNTest1.Models
{
    public class ResultData
    {
        [JsonProperty(PropertyName = "resource_id")]
        public String Success { get; set; }

        [JsonProperty(PropertyName = "limit")]
        public int Limit { get; set; }

        [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }

        [JsonProperty(PropertyName = "records")]
        public RecordsData[] Records { get; set; }

    }
}
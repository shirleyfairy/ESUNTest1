using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESUNTest1.Models
{
    public class RecordsData
    {
        [JsonProperty(PropertyName = "statistic_yyy")]
        public String Year { get; set; }

        [JsonProperty(PropertyName = "according")]
        public String According { get; set; }

        [JsonProperty(PropertyName = "site_id")]
        public String Site { get; set; }

        [JsonProperty(PropertyName = "marriage_type")]
        public String MarriageTp { get; set; }

        [JsonProperty(PropertyName = "female_age_or_spouse1")]
        public String Female { get; set; }

        [JsonProperty(PropertyName = "male_age_or_spouse2")]
        public String Male { get; set; }

        [JsonProperty(PropertyName = "marry_pair")]
        public String MarryPair { get; set; }

        public override string ToString()
        {
            return Year + "-" + According + "-" + Site + "-" + MarriageTp + "-" + Female
                + "-" + Male + "-" + MarryPair;
        }

    }
}
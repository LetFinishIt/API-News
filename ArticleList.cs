using System;
using Newtonsoft.Json;   
namespace CallApi
{
    public class ArticleList
    {
        [JsonProperty("status")]  // no need for further extension in newsoft package 
        public string status { get; set; }

       [JsonProperty("userTier")]
        public string userTier { get; set; }


        [JsonProperty("total")]
        public int total { get; set; }

        [JsonProperty("startIndex")]
        public int startIndex { get; set; }

        [JsonProperty("pageSize")]
        public int pageSize { get; set; }

        [JsonProperty("currentPage")]
        public int currentPage { get; set; }

        [JsonProperty("pages")]
        public int page { get; set; }

        [JsonProperty("orderBy")]
        public string orderBy { get; set; }

        [JsonProperty("results")]
        public ArticleRecord[] Results { get; set; }
    }
}

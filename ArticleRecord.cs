using System;
using Newtonsoft.Json;
namespace CallApi 
{
    public class ArticleRecord
    {
   
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("sectionId")]
        public string sectionId { get; set; }

        [JsonProperty("sectionName")]
        public string sectionName { get; set; }

        [JsonProperty("webPublicationDate")]
        public DateTime date { get; set; }

        [JsonProperty("webUrl")]
        public string webUrl { get; set; }

        [JsonProperty("apiUrl")]
        public string apiUrl { get; set; }

    }
}

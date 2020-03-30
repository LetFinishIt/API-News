using System;
using Newtonsoft.Json;

namespace CallApi
{
    public class Article
    {
        [JsonProperty("response")]
        public ArticleList response { get; set; }
    }
}
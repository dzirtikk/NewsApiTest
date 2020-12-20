using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;


namespace NewsApiTest.Models
{
    class ArticleRoot
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("articles")]
        public NewsInfo[] Article { get; set; }
    }
}

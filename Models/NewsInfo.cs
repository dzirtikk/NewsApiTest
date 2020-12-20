using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace NewsApiTest.Models
{
    class NewsInfo
    {
        [JsonProperty("source")]
        public Source Source { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("publishedAt")]
        public DateTime PublishedAt { get; set; }

    }
}

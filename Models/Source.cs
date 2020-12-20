using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace NewsApiTest.Models
{
    class Source
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

    }

}

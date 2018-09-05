using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalCapstone.Models
{
    public class Car
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("make")]
        public string Make { get; set; }
        [JsonProperty("model")]
        public string Model { get; set; }
        [JsonProperty("year")]
        public int Year { get; set; }
        [JsonProperty("color")]
        public string Color { get; set; }
    }
}
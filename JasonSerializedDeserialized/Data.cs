using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonSerializedDeserialized
{
   public class Data
    {

        [JsonProperty("price")]
        public string[] Price { get; set; }
        [JsonProperty("offerprice")]
        public string[] OfferPrice { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("title_en")]
        public string TitleEn { get; set; }
        [JsonProperty("color")]
        public string[] Color { get; set; }
        [JsonProperty("color_hex")]
        public string[] ColorHex { get; set; }
        [JsonProperty("img")]
        public string Img { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("availability")]
        public string Availability { get; set; }

        [JsonIgnore]
        public Dictionary<string, Tuple<int, int>> PriceAndOfferpriceByColor { get; set; } = new Dictionary<string, Tuple<int, int>>();



    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonSerializedDeserialized
{
    class Product
    {

        [JsonProperty("_status")]
        public string Status { get; set; }
        [JsonProperty("agentId")]
        public string AgentId { get; set; }
        [JsonProperty("data")]
        public string Data { get; set; }
        [JsonProperty("fetchStrategyId")]
        public int FetchStrategyId { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("queuedAt")]
        public DateTime QueuedAt { get; set; }
        [JsonProperty("snapshotStrategyId")]
        public int SnapshotStrategyId { get; set; }
        [JsonProperty("stat")]
        public string Stat { get; set; }
        [JsonProperty("status")]
        public string StatusJson { get; set; }
        [JsonProperty("targetId")]
        public int TargetId { get; set; }
        [JsonProperty("taskId")]
        public string TaskId { get; set; }
        [JsonProperty("timeStamp")]
        public DateTime TimeStamp { get; set; }
        [JsonProperty("updateAt")]
        public DateTime UpdateAt { get; set; }


				[JsonIgnore]
		public int? MinPrice
		{
			get
			{
				if (string.IsNullOrEmpty(this.Data)) return null;
				try {
					var dataObject = JsonConvert.DeserializeObject<Data>(this.Data);
					return dataObject?.Price?.Select(p => int.TryParse(p, out int val) ? val : 0).Min();
				} catch { return null; }
			}
		}
}


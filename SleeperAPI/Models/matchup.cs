using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleeperAPI.Models
{
    internal class scorecard
    {

        [JsonProperty("starters")]
        public List <string> starters { get; set; }

        [JsonProperty("roster_id")]
        public int roster_id { get; set; }

        [JsonProperty("players")]
        public List <string> roster { get; set; }

        [JsonProperty("matchup_id")]
        public int matchup_id { get; set; }

        [JsonProperty("points")]
        public string points { get; set; }

    }
}

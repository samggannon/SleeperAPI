using Newtonsoft.Json;
using RestSharp;
using SleeperAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleeperAPI
{
    internal class controller
    {
        public List<matchup> GetMatchUp(string weekNumber)
        {
            var client = new RestClient("https://api.sleeper.app/v1/league");
            var resquest = new RestRequest($"/786245221641273344/matchups/{weekNumber}");
            var response = client.ExecuteAsync(resquest);

            List<matchup> matchups = new();
            scoreboard scoreboard = new scoreboard();
           
            if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Result.Content;
                var serialize = JsonConvert.DeserializeObject<List<matchup>>(rawResponse);

                matchups = serialize;
                //scoreboard.match_id = matchups(0);

                TableVisualization.ShowTable(matchups, $"Week {weekNumber} Match-Ups");
                return matchups;
            }

            return matchups;
        }

    }
}

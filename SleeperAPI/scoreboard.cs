using SleeperAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleeperAPI
{
    internal class scoreboard
    {
        public int match_id { get; set; }
        public string HomeTeam { get; set; }
        public double HomeTeamPoints { get; set; }
        public string AwayTeam { get; set; }
        public double AwayTeamPoints { get; set; }


        public void ShowScoreboard(List<matchup> matchups, string weekNumber)
        {
            List<scoreboard> scoreboard = new();
            for (int i = 0; i < matchups.Count; i++)
            { 
                for (int j = 0; j < matchups.Count; j++)
                {
                    foreach (var matchup in matchups)
                    {
                        if (matchups[i].matchup_id == matchups[j].matchup_id)
                        {
                            // do something
                            

                        }
                    }

                }
            
                
            }
            

            TableVisualization.ShowTable(scoreboard, $"Week {weekNumber} Match-Ups");
        }
    }

    
}

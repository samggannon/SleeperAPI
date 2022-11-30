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
        public int HomeTeam { get; set; }
        public string HomeTeamPoints { get; set; }
        public int AwayTeam { get; set; }
        public string AwayTeamPoints { get; set; }


        public void ShowScoreboard(List<matchup> matchups, string weekNumber)
        {
            List<scoreboard> scoreboard = new();
            for (int i = 0; i < matchups.Count; i++)
            { 

                for (int j = 0; j < matchups.Count; j++)
                {
                    foreach (var matchup in matchups)
                    {
                        if (matchups[i].matchup_id == matchups[j].matchup_id && matchups[i].roster_id != matchups[j].roster_id)
                        {
                            
                            match_id = matchups[i].matchup_id;
                            HomeTeam = matchups[i].roster_id;
                            HomeTeamPoints = matchups[i].points;
                            AwayTeam = matchups[j].roster_id;
                            AwayTeamPoints = matchups[j].points;
                        }
                    }

                }
            
                
            }
            

            TableVisualization.ShowTable(scoreboard, $"Week {weekNumber} Match-Ups");
        }
    }

    
}

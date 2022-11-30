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


        public void ShowScoreboard(List<scorecard> matchups, string weekNumber)
        {
            List<scoreboard> scoreboard = new();
            for (int i = 0; i < matchups.Count - 1; i++)
            { 

                for (int j = 0; j < matchups.Count - 1; j++)
                {
                    foreach (var matchup in matchups)
                    {
                        if (matchups[i].matchup_id == matchups[j].matchup_id && matchups[i].roster_id != matchups[j].roster_id)
                        {
                            scoreboard H2H = new();
                            H2H.match_id = matchups[i].matchup_id;
                            H2H.HomeTeam = matchups[i].roster_id;
                            H2H.HomeTeamPoints = matchups[i].points;
                            H2H.AwayTeam = matchups[j].roster_id;
                            H2H.AwayTeamPoints = matchups[j].points;

                            scoreboard.Add(H2H);
                            i++;
                        }
                        
                    }
                    
                }
            
                
            }
            

            TableVisualization.ShowTable(scoreboard, $"Week {weekNumber} Match-Ups");
        }
    }

    
}

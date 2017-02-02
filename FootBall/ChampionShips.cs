using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall
{
    public class ChampionShips
    {
        public static Dictionary< string, int> Teams { get; set; }

        //constructor
        public ChampionShips()
        {
            if (Teams == null || Teams.Count == 0)
            {
                InitializeTeams();
            } 
        }

        //InitializeTeams
        private void InitializeTeams()
        {
            Teams = new Dictionary<string, int>()
            {
                {"China"  ,33 },
                { "USA",25 },
                { "Paris",3 },
                { "North Korea",8 },
                { "Autralia",61 },
                { "India",70 } 
            };
        }

        //GetTeams
        public List<string> GetTeams()
        {
            return Teams.OrderBy(t => t.Value).Select(t => t.Key).ToList();
        }

        //GetTeamCount
        public int GetTeamCount()
        {
            return Teams.Count();
        }
        
        
        // Team Rest
        public void TeamsRest()
        {
            try
            {
                InitializeTeams();
            }
            catch (Exception)
            {
                throw new Exception("something went wrong");
            }
        }

        //RemoveTeam
        public bool RomoveTeam(string teamName)
        {
            try
            {
                return Teams.Remove(Teams.Where(t => t.Key.Equals(teamName))?.First().Key);
            }
            catch (Exception)
            {
                return false;
            }
        }


        //Add Team
        public bool AddTeam(string team, int position)
        {
            try
            {
                Teams.Add(team, position);
                return true;
            }catch(Exception){
                return false;
            }
        }

        public string GetBestTeam()
        {
            return Teams.OrderBy(t => t.Value)?.Last().Key;
        }


        public string GetLastTeam()
        {
            return Teams.OrderBy(t => t.Value)?.First().Key;
        }
    }
}

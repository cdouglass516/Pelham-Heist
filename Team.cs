using System;
using System.Collections.Generic;

namespace Heist {
    public class Team {
        public Dictionary<string, Member> TeamList = new Dictionary<string, Member> ();

        public void AddMember (Member teammate) {
            TeamList.Add (teammate.memberName, teammate);
        }
        public void DisplayTeammates () {
            DisplayCount ();
            foreach (KeyValuePair<string, Member> teamMember in TeamList) {
                Console.WriteLine($"Name: {teamMember.Key}");
                Console.WriteLine($"Skill: {teamMember.Value.skillLevel}");
                Console.WriteLine($"Courage Factor: {teamMember.Value.courageFactor}");
                 Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
        }
            public void DisplayCount () {
                Console.WriteLine($"Total Team Count: {TeamList.Count}");
            }
            public int AddTeamSkils ()
            {
                int TotalSkills = 0;
                foreach (KeyValuePair<string, Member> teammate in TeamList){
                    TotalSkills += teammate.Value.skillLevel;
                }
                return TotalSkills;
            }
        }
    }

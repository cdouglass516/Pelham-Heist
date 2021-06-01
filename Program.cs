using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Plan your Heist");
            Console.WriteLine("----------------");
            Team newTeam = startTeam();
            // newTeam.DisplayTeammates();
            Bank newBank = new Bank(100);
            compareSkill(newBank, newTeam);
        }
        public static Team startTeam()

        {
            Team ATeam = new Team();
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("Enter a team member's name: ");
                string memberName = Console.ReadLine();

                if (
                    memberName.Length == 0
                )
                {
                    return ATeam;
                }
                int skillLevel;
                do
                {
                    skillLevel = enterSkillLevel(memberName);
                }
                while (skillLevel < 1 || skillLevel > 10);

                double courageFactor;
                do
                {
                    courageFactor = enterCourageFactor(memberName);
                }
                while (courageFactor < 0.0 || courageFactor > 2.0);
                ATeam.AddMember(new Member(memberName, skillLevel, courageFactor));
            }
            ATeam.DisplayTeammates();
            return ATeam;
        }
        public static int enterSkillLevel(string memberName)
        {
            string memberSkillLevel;
            int skillLevel;
            do
            {
                Console.WriteLine($"Enter {memberName}'s skill level between 1 and 10: ");
                memberSkillLevel = Console.ReadLine();
            }
            while (!(int.TryParse(memberSkillLevel, out skillLevel)));
            return skillLevel;
        }
        public static double enterCourageFactor(string memberName)
        {
            string memberCourageFactor;
            double courageFactor;
            do
            {
                Console.WriteLine($"Enter {memberName}'s courage factor between 0.0 and 2.0: ");
                memberCourageFactor = Console.ReadLine();
            }
            while (!(double.TryParse(memberCourageFactor, out courageFactor)));
            return courageFactor;
        }
        public static void compareSkill(Bank newBank, Team newTeam)
        {
            if (newTeam.AddTeamSkils() > newBank.Difficulty)
            {
                Console.WriteLine("Congrats! your team beat the Bank");
            }
            else
            {
                Console.WriteLine("The Bank has foreclosed on you");
            }

        }
    }
}

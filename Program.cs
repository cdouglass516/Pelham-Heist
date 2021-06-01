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
            Bank newBank = new Bank(0);
            newBank.GetBankLevel();
            int startVal = newBank.Difficulty;
            int loops = BankAttempts();
            int wins = 0;
            int losses = 0;
            for (int i = 0; i < loops; i++)
            {
                newBank.Difficulty = startVal;
                newBank.Difficulty = newBank.HeistLuck();
                if (compareSkill(newBank, newTeam))
                {
                    wins++;
                }
                else
                {
                    losses++;
                }
            }
            Console.WriteLine($"Total runs: {loops} The team has become rich {wins}  The bank has sent you down the river: {losses} times");
            

        }

        // public static void(int wins, int losses){

        // }
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
        public static bool compareSkill(Bank newBank, Team newTeam)
        {
            Console.WriteLine($"Yor team's total skill level was {newTeam.AddTeamSkils()}");
            Console.WriteLine($"The Bank's total skill was {newBank.Difficulty}");
            if (newTeam.AddTeamSkils() >= newBank.Difficulty)
            {
                Console.WriteLine("Congrats! your team beat the Bank");
                return true;
            }
            else
            {
                Console.WriteLine("The Bank has foreclosed on you");
                return false;
            }

        }

        public static int BankAttempts()
        {
            string difficultyLevel = "";
            int intDifficultyLevel;
            do
            {
                Console.WriteLine($"Enter the number of runs: ");
                difficultyLevel = Console.ReadLine();
            } while (!(int.TryParse(difficultyLevel, out intDifficultyLevel)));
            return intDifficultyLevel;
        }

        //         public static int GetBank()
        // {
        //     string difficultyLevel = "";
        //     int intDifficultyLevel;
        //     do
        //     {
        //         Console.WriteLine($"Enter the number of runs: ");
        //         difficultyLevel = Console.ReadLine();
        //     } while (!(int.TryParse(difficultyLevel, out intDifficultyLevel)));
        //     return intDifficultyLevel;
        // }
    }
}

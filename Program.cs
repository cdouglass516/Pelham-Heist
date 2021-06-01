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
            newTeam.DisplayTeammates();
            int TeamSkills = newTeam.AddTeamSkils();
            int difficultyLevel = getDifficultyLevel();
            Bank newBank = new Bank(difficultyLevel);
            int Difficulty = newBank.Difficulty;
            int attempts = BankAttempts();
            int startVal = newBank.Difficulty;
            int count = 0;
            int success = 0;
            int failed = 0;
                do
            {
                string attempt = compareSkill(TeamSkills, Difficulty);
                if (attempt == "success")
                {
                    success++;
                }
                else
                {
                    failed++;
                }
                count++;
            } while (count < attempts);
            Console.WriteLine($"Total runs: {count} The team has become rich {success} times. The bank has sent you down the river: {failed} times");
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
        public static string compareSkill(int TeamSkills, int Difficulty)
        {
            int luckvalue = new Random().Next(-10, 10);
            int BankSkill = luckvalue + Difficulty;
            Console.WriteLine($"Bank value {BankSkill}");
            Console.WriteLine($"Team combined skill = {TeamSkills}");

            if (TeamSkills > BankSkill)
            {
                Console.WriteLine("Congrats! your team beat the Bank");
                return "success";
            }
            else
            {
                Console.WriteLine("The Bank has foreclosed on you");
                return "failed";
            }
        }
        public static int BankAttempts()
        {
            int result = 0;
            string response;
            do
            {
                Console.WriteLine("Enter the number of runs:");
                response = Console.ReadLine();

            } while (Int32.TryParse(response, out result) == false);
            return result;
        }

        public static int getDifficultyLevel()
        {
            string response;
            int result = 0;
            do
            {
                Console.WriteLine("Choose a level of difficulty (E) (M) (H): ");
                response = Console.ReadLine().ToLower();

            }
            while (response != "e" && response != "m" && response != "h");
            if (response == "e")
            {
                result = new Random().Next(0, 30);

            }
            else if (response == "m")
            {
                result = new Random().Next(10, 65);
            }
            else if (response == "h")
            {
                result = new Random().Next(20, 100);
            }
            return result;
        }
    }
}

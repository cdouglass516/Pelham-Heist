using System;
using System.Threading;
using System.Collections.Generic;
namespace Heist
{
    class Program
    {
     //here
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Plan your Heist");
            Console.WriteLine("----------------");
            Bank regions = new Bank(){
                AlarmScore = 33
            };
            Hacker mrPink = new Hacker(){
                Name = "Mr. Pink",
                SkillLevel = 49,
                PercentageCut = 100
            };
            mrPink.PerformSkill(regions);
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
                    skillLevel = enterSkillLevel();
                }
                while (skillLevel < 5 || skillLevel > 10);

                double courageFactor;
                do
                {
                    courageFactor = enterCourageFactor();
                }
                while (courageFactor < 0.0 || courageFactor > 2.0);
                ATeam.AddMember(new Member(memberName, skillLevel, courageFactor));
            }
            ATeam.DisplayTeammates();
            return ATeam;
        }
        public static int enterSkillLevel()
        {
            // string memberSkillLevel;
            int skillLevel;
            // do
            // {
            //     Console.WriteLine($"Enter {memberName}'s skill level between 1 and 10: ");
            //     memberSkillLevel = Console.ReadLine();
            // }
            // while (!(int.TryParse(memberSkillLevel, out skillLevel)));
            skillLevel = new Random().Next(5, 10);
            return skillLevel;
        }
        public static double enterCourageFactor()
        {
            // string memberCourageFactor;
            // double courageFactor;
            // do
            // {
            //     Console.WriteLine($"Enter {memberName}'s courage factor between 0.0 and 2.0: ");
            //     memberCourageFactor = Console.ReadLine();
            // }
            // while (!(double.TryParse(memberCourageFactor, out courageFactor)));
            // return courageFactor;

            double courageToBeConverted = new Random().Next(0, 2);
            double courageFactor = 0;
            if (courageToBeConverted == 2)
            {
                courageFactor = courageToBeConverted;
            }
            else
            {
                courageFactor = (new Random().Next(0, 9) * .1);

            }
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
public static Team getRobbers(int nbrOfRobbers){
            Team newTeam = new Team(); 
            List<string>names = new List<string>(){"Johnathon Ayers", "Ignacy Lopez", "Bea Lancaster", "Eesa Lim", "Regina Matthams", "Connor Ortiz", "Rachael Duncan", "Olli Guevara", "Montague Hough", "Ellen Sierra", "Maddie Downs", "Leyton Valencia", "Macauly O'Quinn", "Lula Griffith", "Taya Cain", "Opal Schaefer", "Leila Monaghan", "Isadora Silva", "Amari Rodrigues", "Malaikah Paterson", "Elleanor Knight", "Xanthe Coulson", "Preston Goddard", "Melina Chase", "Anis Lucero", "Terrell Sparrow", "Cherie Childs", "Aras Kidd","Keziah Mcdowell", "Avani Henry", "Harvir Page", "Tonya Rivera", "Anisha Wood", "Syed Casey", "Jordanna Key", "Darrell Buchanan", "Gus Montoya", "Franklyn Villalobos", "Daniella Higgs", "Darlene Zuniga", "Lleyton Chester", "Selena Field", "Hilda Mckenzie", "Umaiza Peck", "Jaden Lam", "Maizie Weiss", "Beck Levy", "Jibril Coles", "Akaash O'Connor", "Keagan Dunkley"}; 
            List<string> namesAdded = new List<string>();
            for(int i=0; i< nbrOfRobbers; i++){
                string name; //= names[new Random().Next(0, 49)];
                Member toAdd = new Member("",10,2.0);
                do{
                    name = names[new Random().Next(0, 49)];  
                }while(namesAdded.Contains(name));
                toAdd.memberName=name;
                toAdd.skillLevel = enterSkillLevel();
                toAdd.courageFactor = enterCourageFactor();
                namesAdded.Add(name);
                newTeam.AddMember(toAdd);
            }
            return newTeam;
        }

        public static int getDifficultyLevel()
        {
            string response;
            int result = 0;
            do
            {
                Console.WriteLine("Choose a level of difficulty (Easy) (Medium) (Hard): ");
                response = Console.ReadLine().ToLower();

            }
            while (response != "easy" && response != "medium" && response != "hard");
            if (response == "easy")
            {
                result = new Random().Next(0, 30);

            }
            else if (response == "medium")
            {
                result = new Random().Next(10, 65);
            }
            else if (response == "hard")
            {
                result = new Random().Next(20, 100);
            }
            return result;
        }
    }
}

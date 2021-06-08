using System; //here
namespace Heist
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get;set; }
        public int PercentageCut { get; set;}

        public void PerformSkill(Bank bank)
        {
            Console.WriteLine($"{Name} is hacking the alarm system. Decreased security by {SkillLevel.ToString()}");
            
            if(SkillLevel >= bank.AlarmScore){
                Console.WriteLine($"{Name} has cracked the safe!!!");
            }
        }
    }
}
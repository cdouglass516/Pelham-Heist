namespace Heist
{
    public class Member
    {
        public string memberName { get; set; }
        public int skillLevel {get; set; }
        public double courageFactor { get; set; }
        public Member(string memberName, int skillLevel, double courageFactor)
        {
            this.memberName = memberName;
            this.skillLevel = skillLevel;
            this.courageFactor = courageFactor;
        }
    }
}
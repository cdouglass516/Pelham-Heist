namespace Heist//here
{
    public interface IRobber

    {
        string Name { get; set; }
        int SkillLevel { get; }
        int PercentageCut { get; }
        void PerformSkill(Bank b);

    }
}
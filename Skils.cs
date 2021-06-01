// using System;

// namespace Heist
// {
//     public class Skills
//     {
//         public int SkillLevel { get; set; }
//         public double CourageFactor { get; set; }

//         public Skills(int skilllevel, double couragefactor)
//         {
//             this.SkillLevel = skilllevel;
//             this.CourageFactor = couragefactor;
//         }

//         public int GetStats()
//         {
//             int skill = new Random().Next(5, 10);
//             return skill;

//         }
//         public double GetCourage()
//         {
//             double courageToBeConverted = new Random().Next(0, 2);
//             double courage = 0;
//             if (courageToBeConverted == 2)
//             {
//                 courage = courageToBeConverted;
//             }
//             else
//             {
//                 courage = courageToBeConverted / .1;
//             }
//             return courage;
//         }
//     }
// }
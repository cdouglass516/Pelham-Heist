using System;

namespace Heist
{
    public class Bank
    {
        public int Difficulty { get; set; }
        public Bank(int difficulty)
        {
            this.Difficulty = difficulty;

        }
        public int HeistLuck()
        {
            int luck = new Random().Next(-10, 10);
            return this.Difficulty + luck;
        }

    }
}
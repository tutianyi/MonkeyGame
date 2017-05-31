using System;
using System.Linq;

namespace MonkeyGame
{
    public class Computer : Monkey
    {
        public Computer(string name) 
            : base(name)
        {
        }

        public override Skill Attack()
        {
            var candidateSkills = Skills
                .Where(x => x.BananaChange + this.BananaCount >= 0)
                .ToList();
            Random r = new Random(Guid.NewGuid().GetHashCode());
            return Use(candidateSkills[r.Next(candidateSkills.Count)]);
        }
    }
}
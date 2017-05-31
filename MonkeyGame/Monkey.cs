using System;
using System.Collections.Generic;
using System.Linq;

namespace MonkeyGame
{
    public abstract class Monkey
    {
        public Monkey(string name)
        {
            Name = name;
            Skills = Skill.InitSkills()
                .Select(x => { x.Monkey = this; return x; })
                .ToList();
        }

        public string Name { get; set; }
        public IList<Skill> Skills { get; set; }
        public int BananaCount { get; set; }

        public abstract Skill Attack();

        public Skill Use(Skill skill)
        {
            BananaCount += skill.BananaChange;
            return skill;
        }

        public bool Burst()
        {
            return BananaCount < 0;
        }
    }
}
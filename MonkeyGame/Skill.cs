using System;
using System.Collections;
using System.Collections.Generic;

namespace MonkeyGame
{
    public class Skill
    {
        public Skill(string name, int bananaChange, int battleIndex)
        {
            Name = name;
            BananaChange = bananaChange;
            BattleIndex = battleIndex;
        }

        public string Name { get; private set; }
        public int BananaChange { get; private set; }
        public int BattleIndex { get; private set; }
        public Monkey Monkey { get; set; }

        public static IList<Skill> InitSkills()
        {
            return new List<Skill>
                         {
                             new Skill("香蕉", 1, 0),
                             new Skill("波", -1, 1),
                             new Skill("挡", 0, -1),
                             new Skill("拳", -3, 3),
                             new Skill("闪", -1, -3)
                         };
        }

        public static bool operator >(Skill first, Skill second)
        {
            return first.BattleIndex > 0 
                && first.BattleIndex > Math.Abs(second.BattleIndex);
        }

        public static bool operator <(Skill first, Skill second)
        {
            return second.BattleIndex > 0
                && second.BattleIndex > Math.Abs(first.BattleIndex);
        }

        public override string ToString()
        {
            return string.Format("{0}： 猴子，猴子，～{1}～", Monkey.Name, this.Name);
        }
    }
}
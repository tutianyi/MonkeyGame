using System;

namespace MonkeyGame
{
    public class Game
    {
        public Game(Monkey first, Monkey second)
        {
            First = first;
            Second = second;
        }

        public Monkey First { get; set; }
        public Monkey Second { get; set; }

        public Monkey Round(out string skillMessage)
        {
            var firstSkill = First.Attack();
            var secondSkill = Second.Attack();
            skillMessage = string.Format("{0}\n{1}", firstSkill, secondSkill);
            return Judge(firstSkill, secondSkill);
        }

        public Monkey Judge(Skill first, Skill second)
        {
            if (first.Monkey.Burst())
                return second.Monkey;
            if (second.Monkey.Burst())
                return first.Monkey;
            if (first > second)
                return first.Monkey;
            if (second > first)
                return second.Monkey;
            return null;
        }
    }
}
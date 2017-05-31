using System;

namespace MonkeyGame
{
    public class Lived : Monkey
    {
        private readonly Func<int> input;

        public Lived(string name, Func<int> input)
            : base(name)
        {
            this.input = input;
        }

        public override Skill Attack()
        {
            return Use(Skills[input() - 1]);
        }
    }
}
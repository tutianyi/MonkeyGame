using NUnit.Framework;

namespace MonkeyGame.Test
{
    [TestFixture]
    public class GameTests
    {
        private Monkey monkeyA;
        private Monkey monkeyB;
        private Game game;

        [SetUp] 
        public void SetUp()
        {
            monkeyA = new Computer("A");
            monkeyB = new Computer("B");
            game = new Game(monkeyA, monkeyB);
        }

        [Test]
        public void judge_when_A_burst()
        {
            monkeyA.BananaCount = -1;
            Assert.AreEqual(monkeyB, game.Judge(monkeyA.Skills[1], monkeyB.Skills[0]));
        }

        [Test]
        public void judge_when_B_burst()
        {
            monkeyB.BananaCount = -1;
            Assert.AreEqual(monkeyA, game.Judge(monkeyA.Skills[0], monkeyB.Skills[1]));
        }

        [Test]
        public void judge_when_A_is_winner()
        {
            monkeyA.BananaCount = 1;
            Assert.AreEqual(monkeyA, game.Judge(monkeyA.Skills[1], monkeyB.Skills[0]));
        }

        [Test]
        public void judge_when_B_is_winner()
        {
            monkeyB.BananaCount = 1;
            Assert.AreEqual(monkeyB, game.Judge(monkeyA.Skills[0], monkeyB.Skills[1]));
        }

        [Test]
        public void judge_when_nobody_is_winner()
        {
            Assert.Null(game.Judge(monkeyA.Skills[0], monkeyB.Skills[0]));
        }
    }
}
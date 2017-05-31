using NUnit.Framework;

namespace MonkeyGame.Test
{
    [TestFixture]
    public class MonkeyTests
    {
        [Test]
        public void when_use_skill()
        {
            Monkey monkey = new Computer("");
            monkey.Use(monkey.Skills[0]);
            Assert.AreEqual(1, monkey.BananaCount);
        }

        [Test]
        public void when_has_not_enough_banana()
        {
            Monkey monkey = new Computer("");
            monkey.BananaCount = -1;
            Assert.True(monkey.Burst());
        }
        
        [Test]
        public void when_has_enough_banana()
        {
            Monkey monkey = new Computer("");
            Assert.False(monkey.Burst());
        }

        [Test]
        public void when_computer_monkey_attack()
        {
            Monkey monkey = new Computer("");

            monkey.BananaCount = 0;
            Assert.Contains(monkey.Attack().Name, new string[] {"香蕉", "挡"});

            monkey.BananaCount = 1;
            Assert.Contains(monkey.Attack().Name, new string[] { "香蕉", "波", "挡", "闪" });
            
            monkey.BananaCount = 3;
            Assert.Contains(monkey.Attack().Name, new string[] { "香蕉", "波", "挡", "拳", "闪" });
        }

        [Test]
        public void when_lived_monkey_attack()
        {
            Monkey monkey = new Lived("", () => 1);
            Assert.AreEqual(monkey.Attack().Name, "香蕉");

            monkey = new Lived("", () => 2);
            Assert.AreEqual(monkey.Attack().Name, "波");

            monkey = new Lived("", () => 3);
            Assert.AreEqual(monkey.Attack().Name, "挡");

            monkey = new Lived("", () => 4);
            Assert.AreEqual(monkey.Attack().Name, "拳");

            monkey = new Lived("", () => 5);
            Assert.AreEqual(monkey.Attack().Name, "闪");
        }
    }
}
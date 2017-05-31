using System.Collections.Generic;
using NUnit.Framework;

namespace MonkeyGame.Test
{
    [TestFixture]
    public class SkillTests
    {
        private IList<Skill> skills;

        [SetUp]
        public void SetUp()
        {
            skills = Skill.InitSkills();
        }

        [Test]
        public void when_init_skills()
        {
            Assert.AreEqual("香蕉", skills[0].Name);
            Assert.AreEqual(1, skills[0].BananaChange);
            Assert.AreEqual(0, skills[0].BattleIndex);
            
            Assert.AreEqual("波", skills[1].Name);
            Assert.AreEqual(-1, skills[1].BananaChange);
            Assert.AreEqual(1, skills[1].BattleIndex);

            Assert.AreEqual("挡", skills[2].Name);
            Assert.AreEqual(0, skills[2].BananaChange);
            Assert.AreEqual(-1, skills[2].BattleIndex);

            Assert.AreEqual("拳", skills[3].Name);
            Assert.AreEqual(-3, skills[3].BananaChange);
            Assert.AreEqual(3, skills[3].BattleIndex);

            Assert.AreEqual("闪", skills[4].Name);
            Assert.AreEqual(-1, skills[4].BananaChange);
            Assert.AreEqual(-3, skills[4].BattleIndex);
        }

        [Test]
        public void when_compare_two_skills()
        {
            Assert.False(skills[0] > skills[0]);
            Assert.False(skills[0] > skills[1]);
            Assert.False(skills[0] > skills[2]);
            Assert.False(skills[0] > skills[3]);
            Assert.False(skills[0] > skills[4]);

            Assert.True(skills[1] > skills[0]);
            Assert.False(skills[1] > skills[1]);
            Assert.False(skills[1] > skills[2]);
            Assert.False(skills[1] > skills[3]);
            Assert.False(skills[1] > skills[4]);

            Assert.False(skills[2] > skills[0]);
            Assert.False(skills[2] > skills[1]);
            Assert.False(skills[2] > skills[2]);
            Assert.False(skills[2] > skills[3]);
            Assert.False(skills[2] > skills[4]);

            Assert.True(skills[3] > skills[0]);
            Assert.True(skills[3] > skills[1]);
            Assert.True(skills[3] > skills[2]);
            Assert.False(skills[3] > skills[3]);
            Assert.False(skills[3] > skills[4]);

            Assert.False(skills[4] > skills[0]);
            Assert.False(skills[4] > skills[1]);
            Assert.False(skills[4] > skills[2]);
            Assert.False(skills[4] > skills[3]);
            Assert.False(skills[4] > skills[4]);
        }

        [Test]
        public void when_to_string()
        {
            skills[0].Monkey = new Computer("电脑");
            Assert.AreEqual("电脑： 猴子，猴子，～香蕉～", skills[0].ToString());
        }
    }
}
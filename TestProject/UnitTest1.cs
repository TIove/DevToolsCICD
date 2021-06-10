using NUnit.Framework;
using Test_CI_CD;

namespace TestProject
{
    public class Tests
    {
        private Person p;
        [SetUp]
        public void Setup()
        {
            p = new Person(15);
        }

        [Test]
        public void ShouldWalk()
        {
            Assert.True(p.Walk(10));
        }
        
        [Test]
        public void ShouldNotWalk()
        {
            Assert.False(p.Walk(20));
        }
    }
}
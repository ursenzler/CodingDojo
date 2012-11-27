namespace CodingDojo.Test
{
    using FluentAssertions;

    using NUnit.Framework;

    [TestFixture]
    public class FooTest
    {
        private Foo testee;

        [SetUp]
        public void SetUp()
        {
            this.testee = new Foo();
        }

        [Test]
        public void Foo()
        {
            this.testee.Should().NotBeNull();
        }
    }
}
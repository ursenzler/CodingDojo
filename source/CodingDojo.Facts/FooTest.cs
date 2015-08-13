namespace CodingDojo.Test
{
    using FluentAssertions;

    using Xunit;

    public class FooFacts
    {
        private readonly Foo testee;

        public FooFacts()
        {
            this.testee = new Foo();
        }

        [Fact]
        public void Foo()
        {
            this.testee.Should().NotBeNull();
        }
    }
}
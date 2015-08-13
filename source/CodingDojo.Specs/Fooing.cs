namespace CodingDojo.Specification
{
    using FluentAssertions;

    using Xbehave;

    public class Fooing
    {
        [Scenario]
        public void DoFoo(
            Foo foo,
            string result)
        {
            "establish foo"._(() =>
                foo = new Foo());

            "when fooing"._(() =>
                result = foo.ToString());

            "should not be bar"._(() =>
                result.Should().NotBe("bar"));
        }
    }
}
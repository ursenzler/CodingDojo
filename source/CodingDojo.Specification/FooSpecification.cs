namespace CodingDojo.Specification
{
    using FluentAssertions;

    using Machine.Specifications;

    [Subject("Foo")]
    public class When_doing_foo
    {
        It should_be_fooed = () => "foo".Should().NotBe("bar");
    }
}
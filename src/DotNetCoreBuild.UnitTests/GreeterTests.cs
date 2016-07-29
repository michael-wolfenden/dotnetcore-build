using Xunit;

namespace DotNetCoreBuild.UnitTests
{
    public class GreeterTests
    {
        [Fact]
        public void GreeterShouldReturnHelloWorldWhenGreeting()
        {
            Assert.Equal("Hello World", new Greeter().Greet());
        }
    }
}

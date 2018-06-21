using Xunit;

namespace MyNetStandard.Tests
{
    public class Class1
    {
        [Fact]
        public void PassingTest() => Assert.True(true);

        [Fact]
        public void FailingTest() => Assert.True(false);
    }
}

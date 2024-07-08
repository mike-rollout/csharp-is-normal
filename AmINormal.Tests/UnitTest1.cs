using Xunit;
using AmINormal;

namespace AmINormal.Tests
{
    public class NormalCheckerTests
    {
        [Fact]
        public void IsNormal_ReturnsAResponse()
        {
            var response = NormalChecker.IsNormal();
            Assert.False(string.IsNullOrEmpty(response));
        }
    }
}

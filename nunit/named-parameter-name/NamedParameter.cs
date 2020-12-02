using NUnit.Framework;

namespace named_parameter_name
{
    public class NamedParameterTests
    {
        [Test]
        public void TestCase([Values("1, 2", "Test")] string parameter)
        {
            Assert.Pass($"Received parameter named '{nameof(parameter)}' with value '{parameter}'");
        }
    }
}
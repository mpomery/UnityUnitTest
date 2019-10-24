using NUnit.Framework;

namespace Tests
{
    public class ExampleTests
    {
        // A Test behaves as an ordinary method
        [Test]
        public void MethodToTestReturnsTrue()
        {
            Assert.IsTrue(Example.MethodToTest());
        }
    }
}

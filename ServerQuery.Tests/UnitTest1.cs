using NUnit.Framework;

namespace ServerQuery.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int result = ServerQuery.Class1.hello();
            Assert.AreEqual(1, result);
        }
    }
}
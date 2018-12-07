using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsHelloWorld;

namespace JenkinsHelloWorldTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World!", Program.CreateMessage());
        }
    }
}

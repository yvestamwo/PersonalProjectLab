using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PersonalProjectLabTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double c = 8;
            double a = 3;
            double b = 5;
            Assert.IsTrue(c == a + b, "TestMethod1 has failed.");
        }
    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            double c = 15;
            double a = 3;
            double b = 5;
            Assert.IsTrue(c == a * b, "TestMethod2 has failed.");
        }
        [TestClass]
        public class UnitTest3
        {
            [TestMethod]
            public void TestMethod3()
            {
                double c = 5;
                double a = 25;
                double b = 5;
                Assert.IsTrue(c == a / b, "TestMethod3 has failed.");
            }
        }
        }
    }

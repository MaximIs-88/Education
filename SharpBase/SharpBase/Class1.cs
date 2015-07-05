using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SharpBase
{
    [TestClass]
    public class Class1
    {
        private int a = 1;
        
        [TestMethod]
        public void Test()
        {
            var b = a++;
            Assert.AreEqual(1, b);
            Assert.AreEqual(2, a);
        }

        [TestMethod]
        public void Test2()
        {
            var b = a + 1;
            Assert.AreEqual(2, b);
            Assert.AreEqual(1, a);

        }

        [TestMethod]
        public void Test3()
        {
            var b = ++a;
            Assert.AreEqual(2, b);
            Assert.AreEqual(2, a);
        }
    }
}

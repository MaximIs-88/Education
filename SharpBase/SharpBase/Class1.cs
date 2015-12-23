using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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

        [TestMethod]
        public void Test34()
        {
            Assert.AreEqual((int)MyEnum.Flag5, 16);
            //Assert.AreEqual(MyEnum.Flag5 | MyEnum.Flag3, "Flag3, Flag5");
            //Assert.AreEqual(MyEnum.Flag5.     .ToString(), "Flag1");
        }
    }

    [Flags]
    public enum MyEnum
    {
        None = 0,
        Flag1 = 1 << 0,
        Flag2 = 1 << 1,
        Flag3 = 1 << 2,
        Flag4 = 1 << 3,
        Flag5 = 1 << 4
    }


}

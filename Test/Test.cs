using Microsoft.VisualStudio.TestTools.UnitTesting;
using Struct;
namespace Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void PlusVector()
        {
            Vector3 expected = new Vector3().GetVector(2, 4, 6);
            Vector3 a = new Vector3().GetVector(1, 2, 3);
            Vector3 b = new Vector3().GetVector(1, 2, 3);
            Assert.AreEqual(expected, b + a);
        }
        [TestMethod]
        public void Minus()
        {
            Vector3 expected = new Vector3().GetVector(0, 0, 0);
            Vector3 a = new Vector3().GetVector(1, 2, 3);
            Vector3 b = new Vector3().GetVector(1, 2, 3);
            Assert.AreEqual(expected, b - a);
        }
        [TestMethod]
        public void Umnogenia()
        {
            Vector3 expected = new Vector3().GetVector(1, 4, 9);
            Vector3 a = new Vector3().GetVector(1, 2, 3);
            Vector3 b = new Vector3().GetVector(1, 2, 3);
            Assert.AreEqual(expected, b * a);
        }
        [TestMethod]
        public void Number_i()
        {
            Vector3 expected = new Vector3().GetVector(2, 4, 6);
            Vector3 a = new Vector3().GetVector(1, 2, 3);
            int i = 2;
            Assert.AreEqual(expected, a * i);
        }
    }
}

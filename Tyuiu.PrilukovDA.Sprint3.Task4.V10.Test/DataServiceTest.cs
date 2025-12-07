using Tyuiu.PrilukovDA.Sprint3.Task4.V10.Lib;

namespace Tyuiu.PrilukovDA.Sprint3.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.014, ds.Calculate(-5, 5));
        }
    }
}

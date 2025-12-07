using Tyuiu.PrilukovDA.Sprint3.Task5.V22.Lib;

namespace Tyuiu.PrilukovDA.Sprint3.Task5.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-1.009, ds.GetSumSumSeries(2, 1, 1, 3, 12));
        }
    }
}

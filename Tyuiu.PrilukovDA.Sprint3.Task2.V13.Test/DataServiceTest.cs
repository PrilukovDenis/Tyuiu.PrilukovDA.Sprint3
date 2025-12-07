using Tyuiu.PrilukovDA.Sprint3.Task2.V13.Lib;

namespace Tyuiu.PrilukovDA.Sprint3.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(216512863.794, ds.GetSumSeries(7, 1, 10));
        }
    }
}

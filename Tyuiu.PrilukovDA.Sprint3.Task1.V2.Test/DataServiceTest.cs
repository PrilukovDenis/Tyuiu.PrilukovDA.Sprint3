

using Tyuiu.PrilukovDA.Sprint3.Task1.V2.Lib;

namespace Tyuiu.PrilukovDA.Sprint3.Task1.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            Assert.AreEqual(0.968, ds.GetSumSeries(1, 15));
        }
    }
}

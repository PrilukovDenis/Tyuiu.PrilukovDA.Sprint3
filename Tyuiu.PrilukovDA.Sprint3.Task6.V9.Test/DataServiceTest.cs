using Tyuiu.PrilukovDA.Sprint3.Task6.V9.Lib;

namespace Tyuiu.PrilukovDA.Sprint3.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(53, ds.GetSumTheDivisors(19, 30));
        }
    }
}

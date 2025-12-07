using Tyuiu.PrilukovDA.Sprint3.Task7.V6.Lib;

namespace Tyuiu.PrilukovDA.Sprint3.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);

            double[] expected = { 23.92, 18.88, 13.1, 7.24, 1.8, -8, -5.7, -11.26, -17.12, -22.88, -27.92};
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], res[i]);
            }
        }
    }
}

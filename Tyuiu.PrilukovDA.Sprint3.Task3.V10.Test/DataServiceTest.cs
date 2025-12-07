

using Tyuiu.PrilukovDA.Sprint3.Task3.V10.Lib;

namespace Tyuiu.PrilukovDA.Sprint3.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("gdff vft ", ds.DeleteCharInString("gdfppf vfppt p", 'p'));
        }
    }
}

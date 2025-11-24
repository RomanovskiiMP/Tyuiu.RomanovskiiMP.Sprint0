using Tyuiu.RomanovskiiMP.Sprint0.Task2.V0.Lib;

namespace Tyuiu.RomanovskiiMP.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Maxim";

            var res = DataService.GetMessage(name);

            Assert.AreEqual("Hi..., Maxim", res);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShakhovDK.Sprint0.Task2.V0.Lib;
namespace Tyuiu.ShakhovDK.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Даниил";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Даниил", res);
        }
    }
}

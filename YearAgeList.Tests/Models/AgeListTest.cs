using Microsoft.VisualStudio.TestTools.UnitTesting;
using YearAgeList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearAgeList.Models.Tests
{
    [TestClass()]
    public class AgeListTest
    {
        [TestMethod()]
        public void GetListCountTest()
        {
            var list = new AgeList(2000, 5, 95);
            Assert.AreEqual<int>(list.GetList().Count(), 91);
        }
    }
}
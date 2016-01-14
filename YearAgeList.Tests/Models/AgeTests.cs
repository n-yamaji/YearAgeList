using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YearAgeList.Models.Tests
{
    [TestClass()]
    public class AgeTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            var _ = new Age(2015, 5);
            Assert.AreEqual<string>(_.ToString(), "5");
        }

        [TestMethod()]
        public void ToJapaneseCalendarStringTest()
        {
            var _ = new Age(2015, 5);
            Assert.AreEqual<string>(_.ToJapaneseCalendarString(), "平成22年04月01日～平成23年03月31日");
        }

        [TestMethod()]
        public void ToJapaneseCalendarStringSeparateTest()
        {
            var _ = new Age(2015, 5);
            Assert.AreEqual<string>(_.ToJapaneseCalendarString("\n"), "平成22年04月01日\n平成23年03月31日");
        }

        [TestMethod()]
        public void ToJapaneseCalendarStringHeiseiTest()
        {
            var _ = new Age(2015, 27);
            Assert.AreEqual<string>(_.ToJapaneseCalendarString(), "昭和63年04月01日～平成01年03月31日");
        }

        [TestMethod()]
        public void ToJapaneseCalendarStringShowaTest()
        {
            var _ = new Age(2015, 89);
            Assert.AreEqual<string>(_.ToJapaneseCalendarString(), "大正15年04月01日～昭和02年03月31日");
        }

        [TestMethod()]
        public void ToJapaneseCalendarStringTaishoTest()
        {
            var _ = new Age(2015, 103);
            Assert.AreEqual<string>(_.ToJapaneseCalendarString(), "明治45年04月01日～大正02年03月31日");
        }

        [TestMethod()]
        public void ToCommonEraStringTest()
        {
            var _ = new Age(2015, 5);
            Assert.AreEqual<string>(_.ToCommonEraString(), "2010年04月01日～2011年03月31日");
        }

        [TestMethod()]
        public void ToCommonEraStringSeparateTest()
        {
            var _ = new Age(2015, 5);
            Assert.AreEqual<string>(_.ToCommonEraString("から"), "2010年04月01日から2011年03月31日");
        }
    }
}
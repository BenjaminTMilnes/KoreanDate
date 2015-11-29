using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KoreanDate;

namespace KoreanDate.Tests
{
    [TestClass]
    public class MonthsInYearTests
    {
        [TestMethod]
        public void MonthsInYear1Test()
        {
            Assert.AreEqual(12, KoreanDate.MonthsInYear(1, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void MonthsInYear2Test()
        {
            Assert.AreEqual(13, KoreanDate.MonthsInYear(2, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void MonthsInYear3Test()
        {
            Assert.AreEqual(12, KoreanDate.MonthsInYear(3, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void MonthsInYear4Test()
        {
            Assert.AreEqual(12, KoreanDate.MonthsInYear(4, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void MonthsInYear10Test()
        {
            Assert.AreEqual(13, KoreanDate.MonthsInYear(10, KoreanDateEraType.Joseon));
        }
    }
}

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
    public class DaysUntilYearTests
    {
        [TestMethod]
        public void DaysUntilYear1Test()
        {
            Assert.AreEqual(0, KoreanDate.DaysUntilYear(1, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void DaysUntilYear2Test()
        {
            Assert.AreEqual(354, KoreanDate.DaysUntilYear(2, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void DaysUntilYear3Test()
        {
            Assert.AreEqual(738, KoreanDate.DaysUntilYear(3, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void DaysUntilYear4Test()
        {
            Assert.AreEqual(1092, KoreanDate.DaysUntilYear(4, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void DaysUntilYear5Test()
        {
            Assert.AreEqual(1446, KoreanDate.DaysUntilYear(5, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void DaysUntilYear6Test()
        {
            Assert.AreEqual(1830, KoreanDate.DaysUntilYear(6, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void DaysUntilYear7Test()
        {
            Assert.AreEqual(2185, KoreanDate.DaysUntilYear(7, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void DaysUntilYear8Test()
        {
            Assert.AreEqual(2569, KoreanDate.DaysUntilYear(8, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void DaysUntilYear9Test()
        {
            Assert.AreEqual(2923, KoreanDate.DaysUntilYear(9, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void DaysUntilYear10Test()
        {
            Assert.AreEqual(3277, KoreanDate.DaysUntilYear(10, KoreanDateEraType.Joseon));
        }
    }
}

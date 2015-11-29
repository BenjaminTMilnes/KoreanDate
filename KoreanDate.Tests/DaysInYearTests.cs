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
    public class DaysInYearTests
    {
        [TestMethod]
        public void DaysInYear1Test()
        {
            Assert.AreEqual(354, KoreanDate.DaysInYear(1, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void DaysInYear2Test()
        {
            Assert.AreEqual(384, KoreanDate.DaysInYear(2, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void DaysInYear3Test()
        {
            Assert.AreEqual(354, KoreanDate.DaysInYear(3, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void DaysInYear4Test()
        {
            Assert.AreEqual(354, KoreanDate.DaysInYear(4, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void DaysInYear5Test()
        {
            Assert.AreEqual(384, KoreanDate.DaysInYear(5, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void DaysInYear6Test()
        {
            Assert.AreEqual(355, KoreanDate.DaysInYear(6, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void DaysInYear7Test()
        {
            Assert.AreEqual(384, KoreanDate.DaysInYear(7, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void DaysInYear8Test()
        {
            Assert.AreEqual(354, KoreanDate.DaysInYear(8, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void DaysInYear9Test()
        {
            Assert.AreEqual(354, KoreanDate.DaysInYear(9, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void DaysInYear10Test()
        {
            Assert.AreEqual(384, KoreanDate.DaysInYear(10, KoreanDateEraType.Joseon));
        }
    }
}

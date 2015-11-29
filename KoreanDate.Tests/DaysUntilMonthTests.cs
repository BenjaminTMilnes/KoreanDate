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
    public class DaysUntilMonthTests
    {
        [TestMethod]
        public void DaysUntilYear1Month1Test()
        {
            Assert.AreEqual(0, KoreanDate.DaysUntilMonth(1, KoreanDateEraType.Joseon, 1));
        }

        [TestMethod]
        public void DaysUntilYear1Month2Test()
        {
            Assert.AreEqual(29, KoreanDate.DaysUntilMonth(1, KoreanDateEraType.Joseon, 2));
        }

        [TestMethod]
        public void DaysUntilYear1Month3Test()
        {
            Assert.AreEqual(59, KoreanDate.DaysUntilMonth(1, KoreanDateEraType.Joseon, 3));
        }

        [TestMethod]
        public void DaysUntilYear1Month4Test()
        {
            Assert.AreEqual(88, KoreanDate.DaysUntilMonth(1, KoreanDateEraType.Joseon, 4));
        }

        [TestMethod]
        public void DaysUntilYear1Month5Test()
        {
            Assert.AreEqual(118, KoreanDate.DaysUntilMonth(1, KoreanDateEraType.Joseon, 5));
        }

        [TestMethod]
        public void DaysUntilYear1Month6Test()
        {
            Assert.AreEqual(147, KoreanDate.DaysUntilMonth(1, KoreanDateEraType.Joseon, 6));
        }

        [TestMethod]
        public void DaysUntilYear1Month7Test()
        {
            Assert.AreEqual(177, KoreanDate.DaysUntilMonth(1, KoreanDateEraType.Joseon, 7));
        }

        [TestMethod]
        public void DaysUntilYear1Month8Test()
        {
            Assert.AreEqual(206, KoreanDate.DaysUntilMonth(1, KoreanDateEraType.Joseon, 8));
        }

        [TestMethod]
        public void DaysUntilYear1Month9Test()
        {
            Assert.AreEqual(236, KoreanDate.DaysUntilMonth(1, KoreanDateEraType.Joseon, 9));
        }

        [TestMethod]
        public void DaysUntilYear1Month10Test()
        {
            Assert.AreEqual(265, KoreanDate.DaysUntilMonth(1, KoreanDateEraType.Joseon, 10));
        }

        [TestMethod]
        public void DaysUntilYear1Month11Test()
        {
            Assert.AreEqual(295, KoreanDate.DaysUntilMonth(1, KoreanDateEraType.Joseon, 11));
        }

        [TestMethod]
        public void DaysUntilYear1Month12Test()
        {
            Assert.AreEqual(324, KoreanDate.DaysUntilMonth(1, KoreanDateEraType.Joseon, 12));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DaysUntilYear1Month13Test()
        {
            KoreanDate.DaysUntilMonth(1, KoreanDateEraType.Joseon, 13);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DaysUntilYear1Month14Test()
        {
            KoreanDate.DaysUntilMonth(1, KoreanDateEraType.Joseon, 14);
        }

        [TestMethod]
        public void DaysUntilYear2Month1Test()
        {
            Assert.AreEqual(354, KoreanDate.DaysUntilMonth(2, KoreanDateEraType.Joseon, 1));
        }
    }
}

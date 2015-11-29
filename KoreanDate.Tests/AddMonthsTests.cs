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
    public class AddMonthsTests
    {
        [TestMethod]
        public void Add0MonthsTest()
        {
            var Date1 = new KoreanDate(1, KoreanDateEraType.Joseon, 4, 8);
            var Date2 = new KoreanDate(1, KoreanDateEraType.Joseon, 4, 8);

            Date1.AddMonths(0);

            Assert.AreEqual(Date2, Date1);
        }

        [TestMethod]
        public void Add1MonthTest()
        {
            var Date1 = new KoreanDate(1, KoreanDateEraType.Joseon, 4, 8);
            var Date2 = new KoreanDate(1, KoreanDateEraType.Joseon, 5, 8);

            Date1.AddMonths(1);

            Assert.AreEqual(Date2, Date1);
        }

        [TestMethod]
        public void Add2MonthsTest()
        {
            var Date1 = new KoreanDate(1, KoreanDateEraType.Joseon, 4, 8);
            var Date2 = new KoreanDate(1, KoreanDateEraType.Joseon, 6, 8);

            Date1.AddMonths(2);

            Assert.AreEqual(Date2, Date1);
        }

        [TestMethod]
        public void Add3MonthsTest()
        {
            var Date1 = new KoreanDate(1, KoreanDateEraType.Joseon, 4, 8);
            var Date2 = new KoreanDate(1, KoreanDateEraType.Joseon, 7, 8);

            Date1.AddMonths(3);

            Assert.AreEqual(Date2, Date1);
        }

        [TestMethod]
        public void Add4MonthsTest()
        {
            var Date1 = new KoreanDate(1, KoreanDateEraType.Joseon, 4, 8);
            var Date2 = new KoreanDate(1, KoreanDateEraType.Joseon, 8, 8);

            Date1.AddMonths(4);

            Assert.AreEqual(Date2, Date1);
        }

        [TestMethod]
        public void Add12MonthsTest()
        {
            var Date1 = new KoreanDate(1, KoreanDateEraType.Joseon, 4, 8);
            var Date2 = new KoreanDate(2, KoreanDateEraType.Joseon, 4, 8);

            Date1.AddMonths(12);

            Assert.AreEqual(Date2, Date1);
        }

        [TestMethod]
        public void Add1MonthAtEndOfYear1Test()
        {
            var Date1 = new KoreanDate(1, KoreanDateEraType.Joseon, 12, 8);
            var Date2 = new KoreanDate(2, KoreanDateEraType.Joseon, 1, 8);

            Date1.AddMonths(1);

            Assert.AreEqual(Date2, Date1);
        }

        [TestMethod]
        public void Add1MonthAtEndOfYear2Test()
        {
            var Date1 = new KoreanDate(2, KoreanDateEraType.Joseon, 13, 8);
            var Date2 = new KoreanDate(3, KoreanDateEraType.Joseon, 1, 8);

            Date1.AddMonths(1);

            Assert.AreEqual(Date2, Date1);
        }
    }
}

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
    public class AddYearsTests
    {
        [TestMethod]
        public void Add0YearsTest()
        {
            var Date1 = new KoreanDate(1, KoreanDateEraType.Joseon, 4, 8);
            var Date2 = new KoreanDate(1, KoreanDateEraType.Joseon, 4, 8);

            Date1.AddYears(0);

            Assert.AreEqual(Date2, Date1);
        }

        [TestMethod]
        public void Add1YearTest()
        {
            var Date1 = new KoreanDate(1, KoreanDateEraType.Joseon, 4, 8);
            var Date2 = new KoreanDate(2, KoreanDateEraType.Joseon, 4, 8);

            Date1.AddYears(1);

            Assert.AreEqual(Date2, Date1);
        }

        [TestMethod]
        public void Add2YearTest()
        {
            var Date1 = new KoreanDate(1, KoreanDateEraType.Joseon, 4, 8);
            var Date2 = new KoreanDate(3, KoreanDateEraType.Joseon, 4, 8);

            Date1.AddYears(2);

            Assert.AreEqual(Date2, Date1);
        }

        [TestMethod]
        public void Add3YearTest()
        {
            var Date1 = new KoreanDate(1, KoreanDateEraType.Joseon, 4, 8);
            var Date2 = new KoreanDate(4, KoreanDateEraType.Joseon, 4, 8);

            Date1.AddYears(3);

            Assert.AreEqual(Date2, Date1);
        }

        [TestMethod]
        public void Add4YearTest()
        {
            var Date1 = new KoreanDate(1, KoreanDateEraType.Joseon, 4, 8);
            var Date2 = new KoreanDate(5, KoreanDateEraType.Joseon, 4, 8);

            Date1.AddYears(4);

            Assert.AreEqual(Date2, Date1);
        }

        [TestMethod]
        public void Add10YearTest()
        {
            var Date1 = new KoreanDate(1, KoreanDateEraType.Joseon, 4, 8);
            var Date2 = new KoreanDate(11, KoreanDateEraType.Joseon, 4, 8);

            Date1.AddYears(10);

            Assert.AreEqual(Date2, Date1);
        }
    }
}

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
    public class AddDaysTests
    {
        [TestMethod]
        public void Add5DaysTest()
        {
            var Date1 = new KoreanDate(1, KoreanDateEraType.Joseon, 1, 1);
            Date1.AddDays(5);

            var Date2 = new KoreanDate(1, KoreanDateEraType.Joseon, 1, 6);

            Assert.AreEqual<KoreanDate>(Date2, Date1);
        }

        [TestMethod]
        public void Add29DaysTest()
        {
            var Date1 = new KoreanDate(1, KoreanDateEraType.Joseon, 1, 1);
            Date1.AddDays(29);

            var Date2 = new KoreanDate(1, KoreanDateEraType.Joseon, 2, 1);

            Assert.AreEqual<KoreanDate>(Date2, Date1);
        }

        [TestMethod]
        public void Add30DaysTest()
        {
            var Date1 = new KoreanDate(1, KoreanDateEraType.Joseon, 1, 1);
            Date1.AddDays(30);

            var Date2 = new KoreanDate(1, KoreanDateEraType.Joseon, 2, 2);

            Assert.AreEqual<KoreanDate>(Date2, Date1);
        }

        [TestMethod]
        public void Add59DaysTest()
        {
            var Date1 = new KoreanDate(1, KoreanDateEraType.Joseon, 1, 1);
            Date1.AddDays(59);

            var Date2 = new KoreanDate(1, KoreanDateEraType.Joseon, 3, 1);

            Assert.AreEqual<KoreanDate>(Date2, Date1);
        }

        [TestMethod]
        public void Add354DaysTest()
        {
            var Date1 = new KoreanDate(1, KoreanDateEraType.Joseon, 1, 1);
            Date1.AddDays(354);

            var Date2 = new KoreanDate(2, KoreanDateEraType.Joseon, 1, 1);

            Assert.AreEqual<KoreanDate>(Date2, Date1);
        }
    }
}

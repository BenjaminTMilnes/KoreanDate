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
    public class FromDayTests
    {
        [TestMethod]
        public void FromDay1Test()
        {
            var Date1 = new KoreanDate(KoreanDateEraType.Joseon, 1);
            var Date2 = new KoreanDate(1, KoreanDateEraType.Joseon, 1, 1);

            Assert.AreEqual(Date2, Date1);
        }

        [TestMethod]
        public void FromDay2Test()
        {
            var Date1 = new KoreanDate(KoreanDateEraType.Joseon, 2);
            var Date2 = new KoreanDate(1, KoreanDateEraType.Joseon, 1, 2);

            Assert.AreEqual(Date2, Date1);
        }

        [TestMethod]
        public void FromDay8Test()
        {
            var Date1 = new KoreanDate(KoreanDateEraType.Joseon, 8);
            var Date2 = new KoreanDate(1, KoreanDateEraType.Joseon, 1, 8);

            Assert.AreEqual(Date2, Date1);
        }

        [TestMethod]
        public void FromDay30Test()
        {
            var Date1 = new KoreanDate(KoreanDateEraType.Joseon, 30);
            var Date2 = new KoreanDate(1, KoreanDateEraType.Joseon, 2, 1);

            Assert.AreEqual(Date2, Date1);
        }

        [TestMethod]
        public void FromDay60Test()
        {
            var Date1 = new KoreanDate(KoreanDateEraType.Joseon, 60);
            var Date2 = new KoreanDate(1, KoreanDateEraType.Joseon, 3, 1);

            Assert.AreEqual(Date2, Date1);
        }

        [TestMethod]
        public void FromDay89Test()
        {
            var Date1 = new KoreanDate(KoreanDateEraType.Joseon, 89);
            var Date2 = new KoreanDate(1, KoreanDateEraType.Joseon, 4, 1);

            Assert.AreEqual(Date2, Date1);
        }

        [TestMethod]
        public void FromDay355Test()
        {
            var Date1 = new KoreanDate(KoreanDateEraType.Joseon, 355);
            var Date2 = new KoreanDate(2, KoreanDateEraType.Joseon, 1, 1);

            Assert.AreEqual(Date2, Date1);
        }
    }
}

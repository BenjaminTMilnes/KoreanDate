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
    public class NewYearTests
    {
        [TestMethod]
        public void NewYear2015Test()
        {
            var Date1 = new KoreanDate(4348, KoreanDateEraType.Gojoseon, 1, 1);
            var Date2 = new DateTime(2015, 2, 19);

            Assert.AreEqual(Date2, KoreanDateConverter.ConvertToGregorianDateTime(Date1));
        }

        [TestMethod]
        public void NewYear2016Test()
        {
            var Date1 = new KoreanDate(4349, KoreanDateEraType.Gojoseon, 1, 1);
            var Date2 = new DateTime(2016, 2, 8);

            Assert.AreEqual(Date2, KoreanDateConverter.ConvertToGregorianDateTime(Date1));
        }

        [TestMethod]
        public void NewYear2017Test()
        {
            var Date1 = new KoreanDate(4350, KoreanDateEraType.Gojoseon, 1, 1);
            var Date2 = new DateTime(2017, 1, 28);

            Assert.AreEqual(Date2, KoreanDateConverter.ConvertToGregorianDateTime(Date1));
        }

        [TestMethod]
        public void NewYear2018Test()
        {
            var Date1 = new KoreanDate(4351, KoreanDateEraType.Gojoseon, 1, 1);
            var Date2 = new DateTime(2018, 2, 16);

            Assert.AreEqual(Date2, KoreanDateConverter.ConvertToGregorianDateTime(Date1));
        }

        [TestMethod]
        public void NewYear2019Test()
        {
            var Date1 = new KoreanDate(4352, KoreanDateEraType.Gojoseon, 1, 1);
            var Date2 = new DateTime(2019, 2, 5);

            Assert.AreEqual(Date2, KoreanDateConverter.ConvertToGregorianDateTime(Date1));
        }

        [TestMethod]
        public void NewYear2020Test()
        {
            var Date1 = new KoreanDate(4353, KoreanDateEraType.Gojoseon, 1, 1);
            var Date2 = new DateTime(2020, 1, 25);

            Assert.AreEqual(Date2, KoreanDateConverter.ConvertToGregorianDateTime(Date1));
        }

        [TestMethod]
        public void NewYear2021Test()
        {
            var Date1 = new KoreanDate(4354, KoreanDateEraType.Gojoseon, 1, 1);
            var Date2 = new DateTime(2021, 2, 12);

            Assert.AreEqual(Date2, KoreanDateConverter.ConvertToGregorianDateTime(Date1));
        }

        [TestMethod]
        public void NewYear2022Test()
        {
            var Date1 = new KoreanDate(4355, KoreanDateEraType.Gojoseon, 1, 1);
            var Date2 = new DateTime(2022, 2, 1);

            Assert.AreEqual(Date2, KoreanDateConverter.ConvertToGregorianDateTime(Date1));
        }

        [TestMethod]
        public void NewYear2023Test()
        {
            var Date1 = new KoreanDate(4356, KoreanDateEraType.Gojoseon, 1, 1);
            var Date2 = new DateTime(2023, 1, 22);

            Assert.AreEqual(Date2, KoreanDateConverter.ConvertToGregorianDateTime(Date1));
        }

        [TestMethod]
        public void NewYear2024Test()
        {
            var Date1 = new KoreanDate(4357, KoreanDateEraType.Gojoseon, 1, 1);
            var Date2 = new DateTime(2024, 2, 10);

            Assert.AreEqual(Date2, KoreanDateConverter.ConvertToGregorianDateTime(Date1));
        }

        [TestMethod]
        public void NewYear2025Test()
        {
            var Date1 = new KoreanDate(4358, KoreanDateEraType.Gojoseon, 1, 1);
            var Date2 = new DateTime(2025, 1, 29);

            Assert.AreEqual(Date2, KoreanDateConverter.ConvertToGregorianDateTime(Date1));
        }
    }
}

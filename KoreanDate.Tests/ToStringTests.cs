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
    public class ToStringTests
    {
        [TestMethod]
        public void ToString1Test()
        {
            var Date1 = new KoreanDate(4248, KoreanDateEraType.Gojoseon, 4, 8);

            Assert.AreEqual("4248", Date1.ToString("YYYY"));
        }

        [TestMethod]
        public void ToString2Test()
        {
            var Date1 = new KoreanDate(4248, KoreanDateEraType.Gojoseon, 4, 8);

            Assert.AreEqual("48", Date1.ToString("YY"));
        }

        [TestMethod]
        public void ToString3Test()
        {
            var Date1 = new KoreanDate(4248, KoreanDateEraType.Gojoseon, 4, 8);

            Assert.AreEqual("04", Date1.ToString("MM"));
        }

        [TestMethod]
        public void ToString4Test()
        {
            var Date1 = new KoreanDate(4248, KoreanDateEraType.Gojoseon, 4, 8);

            Assert.AreEqual("4", Date1.ToString("M"));
        }

        [TestMethod]
        public void ToString5Test()
        {
            var Date1 = new KoreanDate(4248, KoreanDateEraType.Gojoseon, 4, 8);

            Assert.AreEqual("08", Date1.ToString("DD"));
        }

        [TestMethod]
        public void ToString6Test()
        {
            var Date1 = new KoreanDate(4248, KoreanDateEraType.Gojoseon, 4, 8);

            Assert.AreEqual("8", Date1.ToString("D"));
        }

        [TestMethod]
        public void ToString7Test()
        {
            var Date1 = new KoreanDate(4248, KoreanDateEraType.Gojoseon, 4, 8);

            Assert.AreEqual("Gojoseon", Date1.ToString("E"));
        }

        [TestMethod]
        public void ToString8Test()
        {
            var Date1 = new KoreanDate(623, KoreanDateEraType.Joseon, 4, 8);

            Assert.AreEqual("Joseon", Date1.ToString("E"));
        }

        [TestMethod]
        public void ToString9Test()
        {
            var Date1 = new KoreanDate(4248, KoreanDateEraType.Gojoseon, 4, 8);

            Assert.AreEqual("4248/04/08", Date1.ToString("YYYY/MM/DD"));
        }

        [TestMethod]
        public void ToString10Test()
        {
            var Date1 = new KoreanDate(4248, KoreanDateEraType.Gojoseon, 4, 8);

            Assert.AreEqual("4248/4/8", Date1.ToString("YYYY/M/D"));
        }

        [TestMethod]
        public void ToString11Test()
        {
            var Date1 = new KoreanDate(4248, KoreanDateEraType.Gojoseon, 4, 8);

            Assert.AreEqual("4248-04-08", Date1.ToString("YYYY-MM-DD"));
        }

        [TestMethod]
        public void ToString12Test()
        {
            var Date1 = new KoreanDate(4248, KoreanDateEraType.Gojoseon, 4, 8);

            Assert.AreEqual("4248-4-8", Date1.ToString("YYYY-M-D"));
        }

        [TestMethod]
        public void ToString13Test()
        {
            var Date1 = new KoreanDate(4248, KoreanDateEraType.Gojoseon, 4, 8);

            Assert.AreEqual("4248, 04 08", Date1.ToString("YYYY, MM DD"));
        }

        [TestMethod]
        public void ToString14Test()
        {
            var Date1 = new KoreanDate(4248, KoreanDateEraType.Gojoseon, 4, 8);

            Assert.AreEqual("4248, 4 8", Date1.ToString("YYYY, M D"));
        }

        [TestMethod]
        public void ToString15Test()
        {
            var Date1 = new KoreanDate(4248, KoreanDateEraType.Gojoseon, 4, 8);

            Assert.AreEqual("4248, month 4 day 8, Gojoseon", Date1.ToString("YYYY, month M day D, E"));
        }
    }
}

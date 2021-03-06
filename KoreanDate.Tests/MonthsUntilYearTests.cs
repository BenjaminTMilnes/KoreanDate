﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KoreanDate;

namespace KoreanDate.Tests
{
    [TestClass]
    public class MonthsUntilYearTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MonthsUntilYear0Test()
        {
            KoreanDate.MonthsUntilYear(0, KoreanDateEraType.Joseon);
        }

        [TestMethod]
        public void MonthsUntilYear1Test()
        {
            Assert.AreEqual(0, KoreanDate.MonthsUntilYear(1, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void MonthsUntilYear2Test()
        {
            Assert.AreEqual(12, KoreanDate.MonthsUntilYear(2, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void MonthsUntilYear3Test()
        {
            Assert.AreEqual(25, KoreanDate.MonthsUntilYear(3, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void MonthsUntilYear4Test()
        {
            Assert.AreEqual(37, KoreanDate.MonthsUntilYear(4, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void MonthsUntilYear11Test()
        {
            Assert.AreEqual(124, KoreanDate.MonthsUntilYear(11, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void MonthsUntilYearMinus1Test()
        {
            Assert.AreEqual(0, KoreanDate.MonthsUntilYear(-1, KoreanDateEraType.Joseon));
        }

        [TestMethod]
        public void MonthsUntilYearMinus2Test()
        {
            Assert.AreEqual(12, KoreanDate.MonthsUntilYear(-2, KoreanDateEraType.Joseon));
        }
    }
}

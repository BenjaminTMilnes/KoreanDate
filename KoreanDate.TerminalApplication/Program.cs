using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoreanDate;

namespace KoreanDate.TerminalApplication
{
    internal struct DayCounter
    {
        private int _Month;
        private int _Year;

        private double _DaysThroughMonth;
        private double _DaysThroughYear;

        private int _DaysInMonth;
        private int _DaysInYear;
        private int _MonthsInYear;

        public int DaysInMonth { get { return _DaysInMonth; } }
        public int DaysInYear { get { return _DaysInYear; } }
        public int MonthsInYear { get { return _MonthsInYear; } }

        public void CountUpTo(int Year)
        {
            CountUpTo(Year, 13);
        }

        public void CountUpTo(int Year, int Month)
        {
            _Month = 1;
            _Year = 1;

            _DaysThroughMonth = 0;
            _DaysThroughYear = 0;

            _DaysInMonth = 0;
            _DaysInYear = 0;
            _MonthsInYear = 0;

            while (_Year <= Year && _Month <= Month)
            {
                _DaysThroughMonth += KoreanDate.LunarCycle;
                _DaysThroughYear += KoreanDate.LunarCycle;

                if (_DaysThroughMonth > 30)
                {
                    _DaysThroughMonth -= 30;
                    _DaysInMonth = 30;
                }
                else if (_DaysThroughMonth > 29)
                {
                    _DaysThroughMonth -= 29;
                    _DaysInMonth = 29;
                }

                if (_Month < 12 || ((KoreanDate.SolarCycle - _DaysThroughYear) > (KoreanDate.LunarCycle / 2)))
                {
                    _Month++;
                }
                else
                {
                    _DaysInYear = (int)_DaysThroughYear;
                    _MonthsInYear = _Month;

                    _Month = 1;
                    _Year++;

                    _DaysThroughYear -= KoreanDate.SolarCycle;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var DaysInYear = 0;
            var DaysThroughMonth = 0.0;
            var DaysThroughYear = 0.0;
            var Month = 1;
            var LunarYear = 1;

            while (LunarYear < 40)
            {

                DaysThroughMonth += KoreanDate.LunarCycle;
                DaysThroughYear += KoreanDate.LunarCycle;

                if (DaysThroughMonth >= 30.0)
                {                  
                    DaysThroughMonth -= 30.0;
                    DaysInYear += 30;
                    Console.Write(30 + ", ");
                }
                else if (DaysThroughMonth >= 29.0)
                {
                    DaysThroughMonth -= 29.0;
                    DaysInYear += 29;
                    Console.Write(29 + ", ");
                }

                if (Month < 12 || (KoreanDate.SolarCycle - DaysThroughYear) > (KoreanDate.LunarCycle / 2))
                {
                    Month++;
                }
                else
                {
                    Console.Write(DaysInYear + ", ");
                    DaysInYear = 0;
                    DaysThroughYear -= KoreanDate.SolarCycle;
                    Console.Write(Month + ", ");
                    Month = 1;
                    Console.Write(LunarYear);
                    LunarYear++;
                    Console.WriteLine();
                }

            }

            Console.WriteLine();
            Console.WriteLine();

            //for (var i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine("Year " + i.ToString());

            //    var monthdays = new List<int>();

            //    for (var j = 1; j <= KoreanDate.MonthsInYear(i, KoreanDateEraType.Joseon); j++)
            //    {
            //        monthdays.Add(KoreanDate.DaysInMonth(i, KoreanDateEraType.Joseon, j));
            //    }

            //    Console.WriteLine(KoreanDate.MonthsInYear(i, KoreanDateEraType.Joseon) + " Months, " + string.Join("-", monthdays.ToArray()));
            //    Console.WriteLine(KoreanDate.DaysInYear(i, KoreanDateEraType.Joseon) + " Days");

            //    Console.WriteLine();
            //}

            //  Console.WriteLine(KoreanDateConverter.ConvertFromGregorianDateTime(new DateTime(2015, 10, 10)));

            for (var i = 1; i <= 40; i++)
            {
                var j = KoreanDate.MonthsInYear(i, KoreanDateEraType.Gojoseon);

                for (var k = 1; k <= j; k++)
                {
                    Console.Write(KoreanDate.DaysInMonth(i, KoreanDateEraType.Gojoseon, k) + ", ");
                }

                Console.Write(KoreanDate.DaysInYear(i, KoreanDateEraType.Gojoseon) + ", ");

                Console.Write(KoreanDate.MonthsInYear(i, KoreanDateEraType.Gojoseon) + ", ");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

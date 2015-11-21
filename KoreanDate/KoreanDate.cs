using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace KoreanDate
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
                _DaysThroughMonth += KoreanDateConverter.LunarCycle;
                _DaysThroughYear += KoreanDateConverter.LunarCycle;

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

                if (_Month < 12 || ((KoreanDateConverter.SolarCycle - _DaysThroughYear) > (KoreanDateConverter.LunarCycle / 2)))
                {
                    _Month++;
                }
                else
                {
                    _DaysInYear = (int)_DaysThroughYear;
                    _MonthsInYear = _Month;

                    _Month = 1;
                    _Year++;

                    _DaysThroughYear -= KoreanDateConverter.SolarCycle;
                }
            }
        }
    }

    /// <summary>
    /// Represents a Korean date.
    /// </summary>
    public struct KoreanDate : IEquatable<KoreanDate>, IComparable<KoreanDate>
    {
        /*
        
            'Days' is the fundamental unit of this date.

            */

        private int _Year;
        private KoreanDateEraType _EraType;
        private int _Month;
        private int _MonthOfYear;
        private int _Day;
        private int _DayOfYear;
        private int _DayOfMonth;

        /// <summary>
        /// The number of years since the beginning of the calendar
        /// </summary>
        public int Year { get { return _Year; } }

        /// <summary>
        /// The way in which the years are numbered
        /// </summary>
        public KoreanDateEraType EraType { get { return _EraType; } }

        /// <summary>
        /// The number of months since the beginning of the calendar
        /// </summary>
        public int Month { get { return _Month; } }

        /// <summary>
        /// The number of months since the beginning of the year
        /// </summary>
        public int MonthOfYear { get { return _MonthOfYear; } }

        /// <summary>
        /// The number of days since the beginning of the calendar
        /// </summary>
        public int Day { get { return _Day; } }

        /// <summary>
        /// The number of days since the beginning of the year
        /// </summary>
        public int DayOfYear { get { return _DayOfYear; } }

        /// <summary>
        /// The number of days since the beginning of the month
        /// </summary>
        public int DayOfMonth { get { return _DayOfMonth; } }

        /// <summary>
        /// The KoreanDate of today
        /// </summary>
        public static KoreanDate Today { get; }

        public static bool operator ==(KoreanDate a, KoreanDate b)
        {
            return (a.Day == b.Day);
        }

        public static bool operator !=(KoreanDate a, KoreanDate b)
        {
            return (a.Day != b.Day);
        }

        public static bool operator >(KoreanDate a, KoreanDate b)
        {
            return (a.Day > b.Day);
        }

        public static bool operator <(KoreanDate a, KoreanDate b)
        {
            return (a.Day < b.Day);
        }

        public static bool operator >=(KoreanDate a, KoreanDate b)
        {
            return (a.Day >= b.Day);
        }

        public static bool operator <=(KoreanDate a, KoreanDate b)
        {
            return (a.Day <= b.Day);
        }

        /// <summary>
        /// Creates a new instance of KoreanDate based on the number of days since the start of the calendar.
        /// </summary>
        /// <param name="Day"></param>
        public KoreanDate(KoreanDateEraType EraType, int Day)
        {
            _Day = 1;
            _DayOfYear = 1;
            _DayOfMonth = 1;
            _Month = 1;
            _MonthOfYear = 1;
            _Year = 1;
            _EraType = EraType;

            while (Day > 0)
            {
                Day--;

                if (_Day < KoreanDateConverter.LunarCycle * _Month)
                {
                    _Day++;
                    _DayOfYear++;
                    _DayOfMonth++;
                }
                else if (_Month < (KoreanDateConverter.SolarCycle / KoreanDateConverter.LunarCycle) * _Year)
                {
                    _Day++;
                    _DayOfYear++;
                    _DayOfMonth = 1;

                    _Month++;
                    _MonthOfYear++;
                }
                else
                {
                    _Day++;
                    _DayOfYear = 1;
                    _DayOfMonth = 1;

                    _Month++;
                    _MonthOfYear = 1;

                    _Year++;
                }
            }
        }

        /// <summary>
        /// Creates a new instance of KoreanDate based on the year, era type, month, and day.
        /// </summary>
        /// <param name="Year"></param>
        /// <param name="MonthOfYear"></param>
        /// <param name="DayOfMonth"></param>
        public KoreanDate(int Year, KoreanDateEraType EraType, int MonthOfYear, int DayOfMonth)
        {
            throw new NotImplementedException();

            _Year = Year;
            _EraType = EraType;
            _MonthOfYear = MonthOfYear;
            _DayOfMonth = DayOfMonth;
        }

        /// <summary>
        /// Adds the given number of days to this KoreanDate instance.
        /// </summary>
        /// <param name="Days"></param>
        public void AddDays(int Days)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Subtracts the given number of days from this KoreanDate instance.
        /// </summary>
        /// <param name="Days"></param>
        public void SubtractDays(int Days)
        {
            AddDays(-Days);
        }

        /// <summary>
        /// Adds the given number of months to this KoreanDate instance.
        /// </summary>
        /// <param name="Months"></param>
        public void AddMonths(int Months)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Subtracts the given number of months from this KoreanDate instance.
        /// </summary>
        /// <param name="Months"></param>
        public void SubtractMonths(int Months)
        {
            SubtractMonths(-Months);
        }

        /// <summary>
        /// Adds the given number of years to this KoreanDate instance.
        /// </summary>
        /// <param name="Years"></param>
        public void AddYears(int Years)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Subtracts the given number of years from this KoreanDate instance.
        /// </summary>
        /// <param name="Years"></param>
        public void SubtractYears(int Years)
        {
            SubtractYears(-Years);
        }

        /// <summary>
        /// The number of days in the given month in the given year; for the Korean lunisolar calendar, this is either 29 or 30
        /// </summary>
        /// <param name="Year"></param>
        /// <param name="Month"></param>
        /// <returns></returns>
        public static int DaysInMonth(int Year, KoreanDateEraType EraType, int Month)
        {
            var DayCounter1 = new DayCounter();

            DayCounter1.CountUpTo(Year);

            if (Month > DayCounter1.MonthsInYear)
            {
                throw new ArgumentOutOfRangeException();
            }

            DayCounter1.CountUpTo(Year, Month);

            return DayCounter1.DaysInMonth;
        }

        /// <summary>
        /// The number of days in the given year
        /// </summary>
        /// <param name="Year"></param>
        /// <returns></returns>
        public static int DaysInYear(int Year, KoreanDateEraType EraType)
        {
            var DayCounter1 = new DayCounter();

            DayCounter1.CountUpTo(Year);

            return DayCounter1.DaysInYear;
        }

        /// <summary>
        /// The number of months in the given year; for the Korean lunisolar calendar, this is either 12 or 13
        /// </summary>
        /// <param name="Year"></param>
        /// <returns></returns>
        public static int MonthsInYear(int Year, KoreanDateEraType EraType)
        {
            var DayCounter1 = new DayCounter();

            DayCounter1.CountUpTo(Year);

            return DayCounter1.MonthsInYear;
        }

        /// <summary>
        /// Whether or not a given year is a leap year; a normal lunisolar year has twelve months, a leap year has thirteen months
        /// </summary>
        /// <param name="Year"></param>
        /// <returns></returns>
        public static bool IsLeapYear(int Year, KoreanDateEraType EraType)
        {
            return (MonthsInYear(Year, EraType) == 13);
        }

        public bool Equals(KoreanDate d)
        {
            if (d == null)
            {
                return false;
            }

            return Day == d.Day;
        }

        public int CompareTo(KoreanDate d)
        {
            if (d == null)
            {
                return 1;
            }

            return Day.CompareTo(d.Day);
        }

        public override string ToString()
        {
            return "";
        }
    }
}

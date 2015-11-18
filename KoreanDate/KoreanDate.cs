using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace KoreanDate
{
    /// <summary>
    /// Represents a Korean date.
    /// </summary>
    public struct KoreanDate : IEquatable<KoreanDate>, IComparable<KoreanDate>
    {
        private int _Year;
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
        public KoreanDate(int Day)
        {
            _Day = 1;
            _DayOfYear = 1;
            _DayOfMonth = 1;
            _Month = 1;
            _MonthOfYear = 1;
            _Year = 1;

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
        /// Creates a new instance of KoreanDate based on the year, month, and day.
        /// </summary>
        /// <param name="Year"></param>
        /// <param name="MonthOfYear"></param>
        /// <param name="DayOfMonth"></param>
        public KoreanDate(int Year, int MonthOfYear, int DayOfMonth)
        {
            _Year = Year;
            _MonthOfYear = MonthOfYear;
            _DayOfMonth = DayOfMonth;
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

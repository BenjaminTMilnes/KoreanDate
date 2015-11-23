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

    /// <summary>
    /// Represents a Korean date.
    /// </summary>
    public struct KoreanDate : IEquatable<KoreanDate>, IComparable<KoreanDate>, IFormattable
    {
        /*
        
            'Days' is the fundamental unit of this date.

            */

        /// <summary>
        /// The Gregorian date that corresponds to the Korean date 4346-01-01
        /// </summary>
        public readonly static DateTime Epoch = new DateTime(2013, 2, 10);

        /// <summary>
        /// The average orbital period of the moon around the earth
        /// </summary>
        public const double LunarCycle = 29.530589;

        /// <summary>
        /// The average orbital period of the earth around the sun
        /// </summary>
        public const double SolarCycle = 365.2422;

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
        public int Year
        {
            get
            {
                if (_EraType == KoreanDateEraType.Gojoseon)
                {
                    return _Year + 2013 + 2333;
                }
                else if (_EraType == KoreanDateEraType.Joseon)
                {
                    return _Year + 2013 - 1392;
                }
                else
                {
                    throw new Exception("The era type has not been set.");
                }
            }
        }

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
            _Year = 1;
            _EraType = KoreanDateEraType.Gojoseon;
            _Month = 1;
            _MonthOfYear = 1;
            _Day = 1;
            _DayOfYear = 1;
            _DayOfMonth = 1;

            FromDay(EraType, Day);
        }

        private void FromDay(KoreanDateEraType EraType, int Day)
        {
            _Day = Day;
            _Month = (int)Math.Floor(_Day / LunarCycle);

            var SolarYear = (int)Math.Floor(Day / SolarCycle);
            // The lunisolar year will either be one ahead, one behind, or the same as the solar year - that being the whole point of a lunisolar calendar.

            var MonthsUntilYear1 = MonthsUntilYear(SolarYear, EraType);
            var MonthsDifference = _Month - MonthsUntilYear1;

            if (MonthsDifference < 0)
            {
                _Year = SolarYear - 1;
            }
            else if (MonthsDifference > MonthsInYear(SolarYear, EraType))
            {
                _Year = SolarYear + 1;
            }
            else
            {
                _Year = SolarYear;
            }

            _DayOfYear = _Day - DaysUntilYear(_Year, EraType);
            _DayOfMonth = _Day - DaysUntilMonth(_Year, EraType, _Month);
            _MonthOfYear = _Month - MonthsUntilYear(_Year, EraType);

            _EraType = EraType;
        }

        /// <summary>
        /// Creates a new instance of KoreanDate based on the year, era type, month, and day.
        /// </summary>
        /// <param name="Year"></param>
        /// <param name="MonthOfYear"></param>
        /// <param name="DayOfMonth"></param>
        public KoreanDate(int Year, KoreanDateEraType EraType, int MonthOfYear, int DayOfMonth)
        {
            _Year = 1;
            _EraType = KoreanDateEraType.Joseon;
            _Month = 1;
            _MonthOfYear = 1;
            _Day = 1;
            _DayOfYear = 1;
            _DayOfMonth = 1;

            var YearFromEpoch = Year;

            if (EraType == KoreanDateEraType.Gojoseon)
            {
                YearFromEpoch -= 2013 + 2333;
            }
            else if (EraType == KoreanDateEraType.Joseon)
            {
                YearFromEpoch -= 2013 - 1392;
            }

            FromParts(Year, EraType, MonthOfYear, DayOfMonth);
        }

        /// <summary>
        /// Sets the properties of this KoreanDate instance based on the given components. This function will compensate for excessive values like 22 months or 60 days by counting forward.
        /// </summary>
        /// <param name="Year"></param>
        /// <param name="EraType"></param>
        /// <param name="MonthOfYear"></param>
        /// <param name="DayOfMonth"></param>
        private void FromParts(int Year, KoreanDateEraType EraType, int MonthOfYear, int DayOfMonth)
        {
            _Year = Year;
            _EraType = EraType;

            _Month = MonthsUntilYear(Year, EraType) + MonthOfYear;
            _MonthOfYear = MonthOfYear;

            _Day = DaysUntilMonth(Year, EraType, MonthOfYear) + DayOfMonth;
            _DayOfYear = _Day - DaysUntilYear(Year, EraType);
            _DayOfMonth = DayOfMonth;
        }

        /// <summary>
        /// Adds the given number of days to this KoreanDate instance.
        /// </summary>
        /// <param name="Days"></param>
        public void AddDays(int Days)
        {
            FromDay(_EraType, _Day + Days);
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
            FromDay(_EraType, DaysUntilMonth(_Month + Months) + _DayOfMonth);
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
            FromDay(_EraType, DaysUntilYear(_Year + Years, _EraType) + _DayOfYear);
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
            if (Month == MonthsInYear(Year, EraType))
            {
                return (DaysUntilMonth(Year + 1, EraType, 1) - DaysUntilMonth(Year, EraType, Month));
            }
            else
            {
                return (DaysUntilMonth(Year, EraType, Month + 1) - DaysUntilMonth(Year, EraType, Month));
            }
        }

        /// <summary>
        /// The number of days in the given year
        /// </summary>
        /// <param name="Year"></param>
        /// <returns></returns>
        public static int DaysInYear(int Year, KoreanDateEraType EraType)
        {
            return (DaysUntilYear(Year + 1, EraType) - DaysUntilYear(Year, EraType));
        }

        /// <summary>
        /// The number of months in the given year; for the Korean lunisolar calendar, this is either 12 or 13
        /// </summary>
        /// <param name="Year"></param>
        /// <returns></returns>
        public static int MonthsInYear(int Year, KoreanDateEraType EraType)
        {
            return (MonthsUntilYear(Year + 1, EraType) - MonthsUntilYear(Year, EraType));
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

        /// <summary>
        /// The number of days that have passed before the start of the given month in the given year
        /// </summary>
        /// <param name="Year"></param>
        /// <param name="EraType"></param>
        /// <param name="Month"></param>
        /// <returns></returns>
        private static int DaysUntilMonth(int Year, KoreanDateEraType EraType, int MonthOfYear)
        {
            if (MonthOfYear > MonthsInYear(Year, EraType))
            {
                throw new ArgumentOutOfRangeException();
            }

            var Months = MonthsUntilYear(Year, EraType) + MonthOfYear;

            return DaysUntilMonth(Months);
        }

        /// <summary>
        /// The number of days that have passed before the start of the given month
        /// </summary>
        /// <param name="Month"></param>
        /// <returns></returns>
        private static int DaysUntilMonth(int Month)
        {
            return (int)Math.Floor(Month * LunarCycle);
        }

        /// <summary>
        /// The number of days that have passed before the start of the given year.
        /// </summary>
        /// <param name="Year"></param>
        /// <param name="EraType"></param>
        /// <returns></returns>
        private static int DaysUntilYear(int Year, KoreanDateEraType EraType)
        {
            return (int)Math.Floor(LunarCycle * MonthsUntilYear(Year, EraType));
        }

        /// <summary>
        /// The number of months that have passed before the start of the given year
        /// </summary>
        /// <param name="Year"></param>
        /// <param name="EraType"></param>
        /// <returns></returns>
        private static int MonthsUntilYear(int Year, KoreanDateEraType EraType)
        {
            var DaysUntilSolarYear = SolarCycle * Year;
            var RemainderDays = DaysUntilSolarYear % LunarCycle;
            var MonthsUntilYear = (int)Math.Floor(DaysUntilSolarYear / LunarCycle);

            if (RemainderDays > LunarCycle / 2)
            {
                return MonthsUntilYear + 1;
            }
            else
            {
                return MonthsUntilYear;
            }
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
            return ToString("YYYY, M D");
        }

        public string ToString(string Format)
        {
            return ToString(Format, CultureInfo.CurrentCulture);
        }

        public string ToString(string Format, IFormatProvider FormatProvider)
        {
            Format = Format.Replace("YYYY", _Year.ToString("D4", FormatProvider));
            Format = Format.Replace("YY", _Year.ToString("D2", FormatProvider));

            Format = Format.Replace("MM", _MonthOfYear.ToString("D2", FormatProvider));
            Format = Format.Replace("M", _MonthOfYear.ToString("D1", FormatProvider));

            Format = Format.Replace("DD", _DayOfMonth.ToString("D2", FormatProvider));
            Format = Format.Replace("D", _DayOfMonth.ToString("D1", FormatProvider));

            var Era = "";

            if (_EraType == KoreanDateEraType.Gojoseon)
            {
                Era = "Gojoseon";
            }
            else if (_EraType == KoreanDateEraType.Joseon)
            {
                Era = "Joseon";
            }

            Format = Format.Replace("E", Era);

            return Format;
        }
    }
}

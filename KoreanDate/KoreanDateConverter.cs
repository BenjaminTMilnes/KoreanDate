using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanDate
{
    /// <summary>
    /// Converts between Korean and Gregorian dates.
    /// </summary>
    public sealed class KoreanDateConverter
    {
        /// <summary>
        /// The average orbital period of the moon around the earth
        /// </summary>
        public const double LunarCycle = 29.530589;

        /// <summary>
        /// The average orbital period of the earth around the sun
        /// </summary>
        public const double SolarCycle = 365.2422;

        /// <summary>
        /// Converts a Gregorian date into a Korean date.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public KoreanDate ConvertFromGregorianDateTime(DateTime d)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Converts a Korean date into a Gregorian date.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public DateTime ConvertToGregorianDateTime(KoreanDate d)
        {
            throw new NotImplementedException();
        }
    }
}

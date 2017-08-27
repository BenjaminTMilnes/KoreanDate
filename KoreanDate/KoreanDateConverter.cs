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
        /// Converts a Gregorian date into a Korean date.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static KoreanDate ConvertFromGregorianDateTime(DateTime d, KoreanDateEraType EraType = KoreanDateEraType.Gojoseon)
        {
            var Day = (int)Math.Floor((d - KoreanDate.Epoch).TotalDays);

            return new KoreanDate(EraType, Day);
        }

        /// <summary>
        /// Converts a Korean date into a Gregorian date.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static DateTime ConvertToGregorianDateTime(KoreanDate d)
        {
            return KoreanDate.Epoch.AddDays(d.Day);
        }
    }
}

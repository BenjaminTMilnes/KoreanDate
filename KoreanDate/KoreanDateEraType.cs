using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanDate
{
    /// <summary>
    /// Represents the way in which the years of a KoreanDate are numbered.
    /// </summary>
    public enum KoreanDateEraType
    {
        /// <summary>
        /// The years are numbered from the founding of Gojoseon, in 2333 BCE.
        /// </summary>
        Gojoseon = 1,

        /// <summary>
        /// The years are numbered from the founding of Joseon, in 1392 CE.
        /// </summary>
        Joseon = 2
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanDate.TerminalApplication
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.WriteLine(KoreanDateConverter.ConvertFromGregorianDateTime(new DateTime(2015, 10, 10)));

            Console.ReadLine();
        }
    }
}

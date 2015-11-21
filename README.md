Korean Date
===========

A small class library for converting between the solar Gregorian calendar and the lunisolar Korean calendar.

Classes, Structures, and Enumerations
----------------------

### KoreanDate

Represents a date in the Korean lunisolar calendar. The main properties are Year, MonthOfYear, and DayOfMonth.
Time is not represented by the class, since there is no distinct 'Korean Time'.

This structure attempts to mimic the native C# DateTime structure. It contains many similarly-named properties, fields,
and methods, and implements many of the same interfaces.

### KoreanDateEraType

Represents the way in which years are numbered for a KoreanDate. In the Korean calendar, years can be numbered from the start
of the Joseon dynasty, in 1392 CE, or from the start of the Gojoseon dynasty, in 2333 BCE.

### KoreanDateConverter

Converts between a native C# DateTime and KoreanDate.

Examples
--------

```csharp
var converter = new KoreanDateConverter();

var koreanDate = converter.ConvertToKoreanDate(DateTime.Now);
```
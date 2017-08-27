# KoreanDate

A small C# class library for converting between the Gregorian solar calendar and the traditional Korean lunisolar calendar.

The main structure in this library is **KoreanDate**, which represents a date in the Korean lunisolar calendar, and is an analogue of the native C# DateTime structure. It has many similarly-named properties, fields, and methods to DateTime, and implements some of the same interfaces.

The KoreanDate structure has no concept of time, since there is no distinct 'Korean time'. When converting from a DateTime object to a KoreanDate object, the time component is ignored.

The **KoreanDateConverter** class has static functions on it that are useful for converting between Gregorian and Korean dates, but the actual conversion calculation is done by the KoreanDate structure.

The KoreanDate structure has an EraType property, which is one of the values of the **KoreanDateEraType** enumeration. This determines the method used to number the years. In the Korean calendar, years can be numbered from the start of the Joseon dynasty, in 1392 CE, or from the start of the Gojoseon dynasty, in 2333 BCE.

## Examples

### Creating a new instance of KoreanDate

```csharp

var koreanDate = new KoreanDate(4347, KoreanDateEraType.Gojoseon, 8, 4);

```


### Getting today's date in the Korean calendar

```csharp

var today = KoreanDate.Today;

```


### Converting a Gregorian date into a Korean date

```csharp

var koreanDate = KoreanDateConverter.ConvertFromGregorianDateTime(DateTime.Today);

```


### Converting a Korean date into a Gregorian date

```csharp

var date = KoreanDateConverter.ConvertToGregorianDateTime(new KoreanDate(4347, KoreanDateEraType.Gojoseon, 8, 4));

```


### Adding and Subtracting

```csharp

var koreanDate = new KoreanDate(4347, KoreanDateEraType.Gojoseon, 8, 4);

koreanDate.AddDays(1); // 4347, 8 5
koreanDate.SubtractDays(3); // 4347, 8 2

koreanDate.AddMonths(1); // 4347, 9 2
koreanDate.SubtractMonths(3); // 4347, 6 2

koreanDate.AddYears(1); // 4348, 6 2
koreanDate.SubtractYears(2); // 4346, 6 2

```


### Finding out the number of months in a year

```csharp

KoreanDate.MonthsInYear(4347, KoreanDateEraType.Gojoseon);

```


### Finding out if a year is a leap year

```csharp

KoreanDate.IsLeapYear(4347, KoreanDateEraType.Gojoseon);

```


### KoreanDate.ToString()

```csharp

var koreanDate = new KoreanDate(4346, KoreanDateEraType.Gojoseon, 8, 4);

koreanDate.ToString(); // 4346, 8 4

koreanDate.ToString("YYYY"); // 4346
koreanDate.ToString("YY"); // 46
koreanDate.ToString("MM"); // 08
koreanDate.ToString("M"); // 8
koreanDate.ToString("DD"); // 04
koreanDate.ToString("D"); // 4
koreanDate.ToString("E"); // Gojoseon

koreanDate.ToString("YYYY E, M D"); // 4346 Gojoseon, 8, 4

```
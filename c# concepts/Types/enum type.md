## Enumeration types
An enumeration type (or enum type) is a value type defined by a set of named constants.

eg:
```cs
enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}

enum WeekDays
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
```

### Enum Values
If values are not assigned to enum members, then the compiler will assign integer values to each member starting with zero by default.
```cs
enum Categories
{
    Electronics,    // 0
    Food,           // 1
    Automotive = 6, // 6
    Arts,           // 7
    BeautyCare,     // 8
    Fashion         // 9
}
```

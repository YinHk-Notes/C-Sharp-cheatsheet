## Enumeration types
An **enumeration type** (or `enum` type) is a **value type** defined by a set of **named constants**.

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
enum WeekDays
{
    Monday,     // 0
    Tuesday,    // 1
    Wednesday,  // 2
    Thursday,   // 3
    Friday,     // 4
    Saturday,   // 5
    Sunday      // 6
}


enum Categories
{
    Electronics,    // 0
    Food,           // 1
    Automotive = 6, // 6
    Arts,           // 7
    BeautyCare,     // 8
    Fashion         // 9
}

//You can also explicitly specify the associated constant values
enum Categories
{
    Electronics = 1,  
    Food = 5, 
    Automotive = 6, 
    Arts = 10, 
    BeautyCare = 11, 
    Fashion = 15,
    WomanFashion = 15
}

```

enum can be of any numeric data type such as byte, sbyte, short, ushort, int, uint, long, or ulong. However, an enum cannot be a string type.  Specify the type after `enum` name as `: type`

```cs
enum Categories: byte
{
    Electronics = 1,  
    Food = 5, 
    Automotive = 6, 
    Arts = 10, 
    BeautyCare = 11, 
    Fashion = 15
}
```

Access `enum` \
An enum can be accessed using the dot syntax: `enum.member`


Explicit casting is required to convert from an enum type to its underlying integral type.
```cs
Console.WriteLine(WeekDays.Friday); //output: Friday 
int day = (int) WeekDays.Friday; // enum to int conversion
Console.WriteLine(day); //output: 4 
		
var wd = (WeekDays) 5; // int to enum conversion
Console.WriteLine(wd);//output: Saturday
```

### Convert String to Enum in C#

| Method | Description |
| --- | --- |
| Enum.TryParse() | Converts the string representation of one or more enum member names or numeric values to an equivalent enum objects. It returns true if the conversion succeeded and false if failed. It is recommended to use the Enum.TryParse() over Enum.Parse() method. |
| Enum.Parse() | Converts the string representation of one or more enum member name or numeric value to an equivalent enum object. |


https://www.tutorialsteacher.com/articles/convert-string-to-enum-in-csharp






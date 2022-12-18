## Array
In C# the arrays have fixed length, which is set at the time of their instantiation and determines the total number of elements. Once the length of an array is set we cannot change it anymore.
When we declare an array type variable, it is a **reference**

```cs
class TestArraysClass
{
    static void Main()
    {
        // Declare a single-dimensional array of 5 integers.
        int[] array1 = new int[5];

        // Declare and initialize with values.
        int[] array2 = new int[] { 1, 3, 5, 7, 9 };
        string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        
        //Array Declaration & Initialization with specified length
        int[] nums = new int[5]{ 2, 4, 6, 8, 10 }; 
        string[] cities = new string[3]{ "Mumbai", "London", "New York" };

        // Alternative syntax.
        int[] array3 = { 1, 2, 3, 4, 5, 6 };

        // Declare a two dimensional array.
        int[,] multiDimensionalArray1 = new int[2, 3];
        
        // Declare and initialize an array.
        int[,] theArray = new int[5, 10];
        System.Console.WriteLine("The array has {0} dimensions.", theArray.Rank); //Output: The array has 2 dimensions

        // Declare and set array element values.
        int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

        // Declare a jagged array.
        int[][] jaggedArray = new int[6][];

        // Set the values of the first array in the jagged array structure.
        jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
    }
}
```

It is not necessary to declare and initialize an array in a single statement. You can first declare an array then initialize i
```cs
int[] evenNums;

evenNums = new int[5];
evenNums[0] = 2;
evenNums[1] = 4;
...
// or
evenNums = new int[]{ 2, 4, 6, 8, 10 };
//or
evenNums = new int[5]{ 2, 4, 6, 8, 10 };
```

Accessing Array Elements
```cs
myArray[index]
```

Accessing Array using for Loop
```cs
int[] evenNums = { 2, 4, 6, 8, 10 };

for(int i = 0; i < evenNums.Length; i++)
    Console.WriteLine(evenNums[i]);  

```

Accessing Array using foreach Loop
```cs
int[] evenNums = { 2, 4, 6, 8, 10}; 
string[] cities = { "Mumbai", "London", "New York" }; 

foreach(var item in evenNums)
    Console.WriteLine(item);   

foreach(var city in cities)
    Console.WriteLine(city);  
```
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/

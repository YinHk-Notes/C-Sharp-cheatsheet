## Array
In C# the arrays have fixed length, which is set at the time of their instantiation and determines the total number of elements. Once the length of an array is set we cannot change it anymore.
When we declare an array type variable, it is a **reference**. Arrays are reference types

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

Length of array
```cs
array.Length;
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

Passing Array as Argument
```cs
public static void UpdateArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        arr[i] = arr[i] + 10;   
}
```
Printing an Array to the Console
```cs
string[] array = { "one", "two", "three", "four" };
for (int index = 0; index < array.Length; index++)
{
    // Print each element on a separate line
    Console.WriteLine("Element[{0}] = {1}", index, array[index]);
}
```

### Multidimensional Arrays
> `[,]` declares two-dimensional array, `[, ,]` declares three-dimensional array, `[, , ,]` declares four-dimensional array, and so on.
```cs
int[,] arr2d; // two-dimensional array
int[, ,] arr3d; // three-dimensional array
int[, , ,] arr4d ; // four-dimensional array
int[, , , ,] arr5d; // five-dimensional array

/* example */

int[,] arr2d = new int[3,2]{ {1, 2}, {3, 4}, {5, 6} };
// or 
int[,] arr2d = { {1, 2}, {3, 4}, {5, 6} };

```



https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/

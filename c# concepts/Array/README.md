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

        //Array Declaration & Initialization with specified length
        int[] nums = new int[5]{ 2, 4, 6, 8, 10 }; 
        string[] cities = new string[3]{ "Mumbai", "London", "New York" };
        
        // Declare and initialize with values.
        int[] array2 = new int[] { 1, 3, 5, 7, 9 };
        string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

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
evenNums = new int[5]{ 2, 4, 6, 8, 10 };
//or
evenNums = new int[]{ 2, 4, 6, 8, 10 };
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

Accessing the Elements of a Multidimensional Array
```cs
int[,] matrix =
{
    {1, 2, 3, 4},
    {5, 6, 7, 8},
};

//Access matrix
matrix[row, col];
matrix[0, 0];  //1
matrix[0, 1];  //2
matrix[1, 2];  //7
matrix[1, 3];  //8


int[, ,] arr3d = new int[2, 2, 2]{ { {1, 2}, {3, 4} }, { {5, 6}, {7, 8} } };
arr3d[0, 0, 1]; // returns 2 
arr3d[0, 1, 0]; // returns 3 
```
Printing Matrices
```cs
// Declare and initialize a matrix of size 2 x 4
int[,] matrix =
{
    {1, 2, 3, 4}, // row 0 values
    {5, 6, 7, 8}, // row 1 value
};
// Print the matrix on the console
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write(matrix[row, col]);
    }
    Console.WriteLine();
}
```

### Jagged arrays
Arrays of arrays, which we call jagged arrays. Jagged arrays store arrays instead of literal values.
A jagged array is initialized with two square brackets `[][]`. The first bracket specifies the size of an array,
and the second bracket specifies the dimensions of the array which is going to be stored
```cs
int[][] jArray1 = new int[2][]; // can include two single-dimensional arrays 
int[][,] jArray2 = new int[3][,]; // can include three two-dimensional arrays 
```
```cs
int[][] jaggedArray = new int[3][];

jaggedArray[0] = new int[5];
jaggedArray[1] = new int[4];
jaggedArray[2] = new int[2];

jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
jaggedArray[1] = new int[] { 0, 2, 4, 6 };
jaggedArray[2] = new int[] { 11, 22 };

//or

int[][] jaggedArray2 = new int[][]
{
    new int[] { 1, 3, 5, 7, 9 },
    new int[] { 0, 2, 4, 6 },
    new int[] { 11, 22 }
};

```

Access a jagged array using two for loops
```cs
int[][] jArray = new int[2][]{
                new int[3]{1, 2, 3},
                new int[4]{4, 5, 6, 7}
            };

for(int i=0; i<jArray.Length; i++)
{
	for(int j=0; j < (jArray[i]).Length; j++)
		Console.WriteLine(jArray[i][j]);
}
```
```cs
//The following jagged array stores two-dimensional arrays where the second bracket [,] indicates the two-dimensional array.
int[][,] jArray = new int[2][,];

jArray[0] = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
jArray[1] = new int[2, 2] { { 7, 8 }, { 9, 10 } }; 

jArray[0][1, 1]; //returns 4
                                             
jArray[1][1, 0]; //returns 9
                                             
jArray[1][1, 1]; //returns 10
```


https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/

## `break`, `continue`, `return` and `goto`

### `break` 

`break` used to terminate iteration proccess.

```cs
int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
foreach (int number in numbers)
{
    if (number == 3)
    {
        break;
    }

    Console.Write($"{number} ");
}
Console.WriteLine();
Console.WriteLine("End of the example.");
// Output:
// 0 1 2 
// End of the example.

```

### `continue`
`continue` is used to jump or skip or bypass the current step in the iteration.

```cs
for (int i = 0; i < 5; i++)
{
    Console.Write($"Iteration {i}: ");
    
    if (i < 3)
    {
        Console.WriteLine("skip");
        continue;
    }
    
    Console.WriteLine("done");
}
// Output:
// Iteration 0: skip
// Iteration 1: skip
// Iteration 2: skip
// Iteration 3: done
// Iteration 4: done
```


### `return`
The `return` statement terminates execution of the function in which it appears and returns control and the function's result

```cs
Console.WriteLine("First call:");
DisplayIfNecessary(6);

Console.WriteLine("Second call:");
DisplayIfNecessary(5);

void DisplayIfNecessary(int number)
{
    if (number % 2 == 0)
    {
        return;
    }

    Console.WriteLine(number);
}
// Output:
// First call:
// Second call:
// 5
```

### `Ref returns`

By default, the `return` statement returns the **value of an expression**. You can **return a reference to a variable**.
To do that, use the `return` statement with the `ref` keyword.

```cs
var xs = new int[] { 10, 20, 30, 40 };
ref int found = ref FindFirst(xs, s => s == 30);
found = 0;
Console.WriteLine(string.Join(" ", xs));  // output: 10 20 0 40

ref int FindFirst(int[] numbers, Func<int, bool> predicate)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (predicate(numbers[i]))
        {
            return ref numbers[i];
        }
    }
    throw new InvalidOperationException("No element satisfies the given condition.");
}
```


### `goto`
transfers control to a statement that is marked by a label.

`label` is an identifier. When `goto label;` is encountered, the control of the program is transferred to `label:`. Then the code below `label:` is executed.


```cs
goto label;
... 
...
label:
  ...
  ...
```
```cs
using System;

namespace CSharpGoto {

  class Program {
    public static void Main(string[] args) {
      
      // label
      repeat: 
        Console.WriteLine("Enter a number less than 10");
        int num = Convert.ToInt32(Console.ReadLine());  

        if(num >= 10) {
          // transfers control to repeat
          goto repeat;
        }

        Console.WriteLine(num + " is less than 10");
        Console.ReadLine();
    }
  }
}
```


```cs
var matrices = new Dictionary<string, int[][]>
{
    ["A"] = new[]
    {
        new[] { 1, 2, 3, 4 },
        new[] { 4, 3, 2, 1 }
    },
    ["B"] = new[]
    {
        new[] { 5, 6, 7, 8 },
        new[] { 8, 7, 6, 5 }
    },
};

CheckMatrices(matrices, 4);

void CheckMatrices(Dictionary<string, int[][]> matrixLookup, int target)
{
    foreach (var (key, matrix) in matrixLookup)
    {
        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                if (matrix[row][col] == target)
                {
                    goto Found;
                }
            }
        }
        Console.WriteLine($"Not found {target} in matrix {key}.");
        continue;

    Found:
        Console.WriteLine($"Found {target} in matrix {key}.");
    }
}
// Output:
// Found 4 in matrix A.
// Not found 4 in matrix B.
```

```cs
using System;

namespace CSharpGoto {

  class Program {

    static void Main() {
    for(int i = 0; i <= 10; i++) {

      if(i == 5) {
        // transfers control to End label
        goto End;
      }

      Console.WriteLine(i);
    }

    // End label
    End:
      Console.WriteLine("Loop End");
      Console.ReadLine();
    }
  }
}
```

> **Note**: You can use the goto statement to **get out of a nested loop**. When you work with nested loops, consider refactoring separate loops into separate methods. That may lead to a simpler, more readable code without the **`goto`** statement.

```cs
using System;

namespace CSharpGoto {

  class Program {
    public static void Main(string[] args) {
      
      // label
      repeat: 
        Console.WriteLine("Enter a number less than 10");
        int num = Convert.ToInt32(Console.ReadLine());  

        if(num >= 10) {
          // transfers control to repeat
          goto repeat;
        }

        Console.WriteLine(num + " is less than 10");
        Console.ReadLine();
    }
  }
}
```

```cs
using System;

namespace CSharpGoto {

  class Program {

    public static void Main(string[] args) {

      Console.Write("Choose your coffee? milk or black: ");
      string coffeeType = Console.ReadLine();

      switch (coffeeType) {
        case "milk":
          Console.WriteLine("Can I have a milk coffee?");
          break;

        case "black":
          Console.WriteLine("Can I have a black coffee?");
          // transfer code to case "milk" 
          goto case "milk";
     
        default:
          Console.WriteLine("Not available.");
            break;
        }
      Console.ReadLine();
    }
  }
}

```

### ref 
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/jump-statements

https://www.programiz.com/csharp-programming/goto

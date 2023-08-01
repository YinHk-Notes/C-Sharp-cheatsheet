### For loop
```cs
for (statement 1; statement 2; statement 3) 
{
  // code block to be executed
}
```
### foreach Loop
```cs
foreach (type variableName in arrayName) 
{
  // code block to be executed
}
```

### Switch
```cs
switch(expression) 
{
  case x:
    // code block
    break;
  case y:
    // code block
    break;
  default:
    // code block
    break;
}
```

### while loop
```
While(condition)
{
    //code block
}
```
```cs
int i = 0; // initialization

while (i < 10) // condition
{
    Console.WriteLine("i = {0}", i);

    i++; // increment
}
```
### Ternary Operator
```
condition ? statement 1 : statement 2
```


### Jump statements
The jump statements unconditionally transfer control.
- **`break`**: terminates the closest enclosing iteration process.
- **`continue`**: starts a new iteration of the closest enclosing iteration process.
- **`return`**: terminates execution of the function in which it appears and returns control and the function's result.
- **`goto`**: transfers control to a statement that is marked by a **label**.
  
### await foreach
When a sequence is generated **asynchronously**, you can use the await foreach statement to asynchronously consume the sequence:
```cs
await foreach (var item in asyncSequence)
{
Console.WriteLine(item?.ToString());
}

```

### `IEnumerable<T>`
Exposes the enumerator, which supports a simple iteration over a collection of a specified type.
```cs
public interface IEnumerable<out T> : System.Collections.IEnumerable
```

An iterator method defines how to generate the objects in a sequence when requested. You use the `yield return` contextual keywords to define an iterator method.

Eg:
```cs
public IEnumerable<int> GetSingleDigitNumbers()
{
    yield return 0;
    yield return 1;
    yield return 2;
    yield return 3;
    yield return 4;
    yield return 5;
    yield return 6;
    yield return 7;
    yield return 8;
    yield return 9;
}
```

```cs
public IEnumerable<int> GetSetsOfNumbers()
{
    int index = 0;
    while (index < 10)
        yield return index++;

    yield return 50;

    index = 100;
    while (index < 110)
        yield return index++;
}
```

### `IAsyncEnumerable<T>`
Exposes an enumerator that provides asynchronous iteration over values of a specified type.

```cs
public interface IAsyncEnumerable<out T>
```

Eg:
```cs
public async IAsyncEnumerable<int> GetSetsOfNumbersAsync()
{
    int index = 0;
    while (index < 10)
        yield return index++;

    await Task.Delay(500);

    yield return 50;

    await Task.Delay(500);

    index = 100;
    while (index < 110)
        yield return index++;
}
```



### ref
https://learn.microsoft.com/en-us/dotnet/csharp/iterators

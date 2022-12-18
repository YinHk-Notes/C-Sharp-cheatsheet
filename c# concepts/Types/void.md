## void
void as the return type of a method to specify that the method doesn't return a value

```cs
public static void Display(IEnumerable<int> numbers)
{
    if (numbers is null)
    {
        return;
    }

    Console.WriteLine(string.Join(" ", numbers));
}
```

> You can also use void as a referent type to declare a pointer to an unknown type.
> Cannot use void as the type of a variable
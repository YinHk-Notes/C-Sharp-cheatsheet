## sealed

You can use **`sealed`** modifier on class, method or property that overrides a virtual method or property in a base class.

> The **`sealed`** modifier prevents other classes from inheriting from it.

> The **`sealed`** modifier prevent a virtual method or property in a base class from overriding.

eg:
```cs
class X
{
    protected virtual void F() { Console.WriteLine("X.F"); }
    protected virtual void F2() { Console.WriteLine("X.F2"); }
}

class Y : X
{
    sealed protected override void F() { Console.WriteLine("Y.F"); }
    protected override void F2() { Console.WriteLine("Y.F2"); }
}

class Z : Y
{
    // Attempting to override F causes compiler error CS0239.
    // protected override void F() { Console.WriteLine("Z.F"); }

    // Overriding F2 is allowed.
    protected override void F2() { Console.WriteLine("Z.F2"); }
}
```



### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/sealed


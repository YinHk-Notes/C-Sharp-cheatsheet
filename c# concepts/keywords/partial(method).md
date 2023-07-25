##partial method
A partial method has its signature defined in one part of a partial type, and its implementation defined in another part of the type. 

> Partial methods enable class designers to provide method hooks, similar to event handlers, that developers may decide to implement or not. If the developer does not supply an implementation, the compiler removes the signature at compile time. 

- Declarations must begin with the contextual keyword partial.
- Signatures in both parts of the partial type must match.


The `partial` keyword isn't allowed on constructors, finalizers, overloaded operators, property declarations, or event declarations.


A partial method isn't required to have an implementation in the following cases:

- It doesn't have any accessibility modifiers (including the default private).
- It returns `void`.
- It doesn't have any `out` parameters.
- It doesn't have any of the following modifiers **`virtual`**, **`override`**, **`sealed`**, **`new`**, or **`extern`**.


Any method that doesn't conform to all those restrictions (for example, **`public virtual partial void`** method), **must provide an implementation**.


```cs
namespace PM
{
    partial class A
    {
        partial void OnSomethingHappened(string s);
    }

    // This part can be in a separate file.
    partial class A
    {
        // Comment out this method and the program
        // will still compile.
        partial void OnSomethingHappened(String s)
        {
            Console.WriteLine("Something happened: {0}", s);
        }
    }
}
```


### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/partial-method

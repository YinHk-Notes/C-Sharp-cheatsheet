## partial type
Partial type definitions allow for the definition of a class, struct, interface, or record to be **split into multiple files**.

Eg:
In File1.cs:
```cs
namespace PC
{
    partial class A
    {
        int num = 0;
        void MethodA() { }
        partial void MethodC();
    }
}
```
In File2.cs 
```cs
namespace PC
{
    partial class A
    {
        void MethodB() { }
        partial void MethodC() { }
    }
}

```

> Splitting a class, struct or interface type over several files can be useful when you are working with large projects, or with automatically generated code such as that provided by the Windows Forms Designer. A **partial type** may contain a **partial method**.

### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/partial-type

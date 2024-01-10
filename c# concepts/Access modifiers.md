## Access modifiers

**Access modifiers** are keywords used to specify the declared accessibility of a member or a type. It determine the access Levels of the code. This section introduces the five access modifiers:

- `public`
- `protected`
- `internal`
- `private`
- `file`

> **Encapsulation** is implemented by using **access specifiers**. An access specifier defines the **scope and visibility of a class member**. 

|Modifier|Description|
|-|-|
|`public`|	The code is accessible for all classes. **Access is not restricted**.|
|`private`|The code is only accessible within the **same class**, **cannot be accessed from any other class**. Private members are accessible only within the body of the class or the struct in which they are declared. The type or member can be accessed only by code in the same **`class`** or **`struct`**.|
|`protected`|	The code is **accessible within the same class**, or in a class that is **inherited from that class**. You will learn more about inheritance in a later chapter. Access is limited to the containing class or types derived from the containing class. A protected member is accessible within its class and by **derived class instances**.|
|`internal`|	The code is only **accessible within its own assembly**, but **not from another assembly**. Access is limited to the **current assembly**. Used to **limit the access to the elements of the class only to files from the same assembly**, i.e. the **same project in Visual Studio**. When we create several projects in Visual Studio, the classes from will be compiled in different assemblies.|
|`protected internal`| Access is limited to the **current assembly or types derived from the containing class**.|
|`private protected`|Access is **limited to the containing class** or **types derived from the containing class** **within the current assembly**.|
|`file`|**restricts a top-level type's scope** and **visibility to the file** in which it's declared.|


|Members|Default|Allowed declared accessibility|
|-|-|-|
|`enum`|`public`|None|
|`class`|`private`|`public` `protected` `internal` `private` `protected internal` `private protected`|
|`interface`|`public`|`public` `protected` `internal` `private*` `protected internal` `private protected`|
|`struct`|`private`|`public` `internal` `private`|

| Caller's location | `public` | `protected internal` | `protected` | `internal` | `private protected` | `private` |
| --- | --- | --- | --- | --- | --- | --- |
| Within the class | ✔️️ | ✔️ | ✔️ | ✔️ | ✔️ | ✔️ |
| Derived class (same assembly) | ✔️ | ✔️ | ✔️ | ✔️ | ✔️ | ❌ |
| Non-derived class (same assembly) | ✔️ | ✔️ | ❌ | ✔️ | ❌ | ❌ |
| Derived class (different assembly) | ✔️ | ✔️ | ✔️ | ❌ | ❌ | ❌ |
| Non-derived class (different assembly) | ✔️ | ❌ | ❌ | ❌ | ❌ | ❌ |


> **`Classes`**, **`records`**, and **`structs`** declared directly within a namespace (in other words, that aren't nested within other classes or structs) can be either **`public`** or **`internal`**. **`internal`** is the **default** if no access modifier is specified.


### `internal`
```cs
public class BaseClass
{  
    // Only accessible within the same assembly.
    internal static int x = 0;
}
```
```cs
// This example contains two files, Assembly1.cs and Assembly1_a.cs. 
// The first file contains an internal base class, BaseClass. 
// In the second file, an attempt to instantiate BaseClass will produce an error.


// Assembly1.cs  
// Compile with: /target:library  
internal class BaseClass
{  
   public static int intM = 0;  
}  

// Assembly1_a.cs  
// Compile with: /reference:Assembly1.dll  
class TestAccess
{  
   static void Main()
   {  
      var myBase = new BaseClass();   // CS0122  
   }  
}
```
```cs
// In this example, use the same files you used in example 1, 
// and change the accessibility level of BaseClass to public. 
// Also change the accessibility level of the member intM to internal. In this case, you can instantiate the class, 
// but you cannot access the internal member.


// Assembly2.cs  
// Compile with: /target:library  
public class BaseClass
{  
   internal static int intM = 0;  
}

// Assembly2_a.cs  
// Compile with: /reference:Assembly2.dll  
public class TestAccess
{  
   static void Main()
   {  
      var myBase = new BaseClass();   // Ok.  
      BaseClass.intM = 444;    // CS0117  
   }  
}
```
### `protected`
```cs
class A
{
    protected int x = 123;
}

class B : A
{
    static void Main()
    {
        var a = new A();
        var b = new B();

        // Error CS1540, because x can only be accessed by
        // classes derived from A.
        // a.x = 10;

        // OK, because this class derives from A.
        b.x = 10;
    }
}
```

### `protected internal`
A `protected internal` member is accessible from the current assembly or from types that are derived from the containing class.
```cs
// Assembly1.cs
// Compile with: /target:library
public class BaseClass
{
   protected internal int myValue = 0;
}

class TestAccess
{
    void Access()
    {
        var baseObject = new BaseClass();
        baseObject.myValue = 5;
    }
}
```
```cs
// Assembly2.cs
// Compile with: /reference:Assembly1.dll
class DerivedClass : BaseClass
{
    static void Main()
    {
        var baseObject = new BaseClass();
        var derivedObject = new DerivedClass();

        // Error CS1540, because myValue can only be accessed by
        // classes derived from BaseClass.
        // baseObject.myValue = 10;

        // OK, because this class derives from BaseClass.
        derivedObject.myValue = 10;
    }
}
```
### `private protected`
 A `private protected` member is accessible by types derived from the containing class, **but only within its containing assembly**.
```cs
public class BaseClass
{
    private protected int myValue = 0;
}

public class DerivedClass1 : BaseClass
{
    void Access()
    {
        var baseObject = new BaseClass();

        // Error CS1540, because myValue can only be accessed by
        // classes derived from BaseClass.
        // baseObject.myValue = 5;

        // OK, accessed through the current derived class instance
        myValue = 5;
    }
}
```
```cs
// Assembly2.cs
// Compile with: /reference:Assembly1.dll
class DerivedClass2 : BaseClass
{
    void Access()
    {
        // Error CS0122, because myValue can only be
        // accessed by types in Assembly1
        // myValue = 10;
    }
}
```
### `file`
Beginning with **C# 11**, the `file` contextual keyword is a type modifier.
The file modifier restricts a top-level type's scope and visibility to the file in which it's declared. The file modifier will generally be applied to types written by a source generator. The `file` modifier declares a file-local type.

```cs
file class HiddenWidget
{
    // implementation
}
```
```cs
// In File1.cs:
file interface IWidget
{
    int ProvideAnswer();
}

file class HiddenWidget
{
    public int Work() => 42;
}

public class Widget : IWidget
{
    public int ProvideAnswer()
    {
        var worker = new HiddenWidget();
        return worker.Work();
    }
}
```
```cs
// In File2.cs:
// Doesn't conflict with HiddenWidget
// declared in File1.cs
public class HiddenWidget
{
    public void RunTask()
    {
        // omitted
    }
}
```

### ref 
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers



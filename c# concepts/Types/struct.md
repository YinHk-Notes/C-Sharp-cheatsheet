## struct

**`struct`** is the value type data type that represents data structures. It can contain a **parameterized constructor**, **static constructor**, **constants**, **fields**, **methods**, **properties**, **indexers**, **operators**, **events**, and **nested types**.

Structs **share most of the same syntax** as classes, but **more limited than classes** in the following ways:

- Within a struct declaration, fields **cannot be initialized** unless they are declared as **`const`** or **`static`**. ( Beginning with C# 11, if you don't initialize all fields in a struct, the compiler adds code to the constructor that initializes those fields to the default value.)
- A struct **cannot declare a parameterless constructor** (a constructor without parameters) or a finalizer.
- Structs are **copied on assignment**. When a struct is assigned to a new variable, **all the data** is **copied**, and any modification to the new copy does not change the data for the original copy. This is important to remember when working with **collections of value types** such as **`Dictionary<string, myStruct>`**.
- Structs are **value types**, unlike classes, which are reference types.
- Unlike classes, **structs can be instantiated**(creating object) without using a **`new`** operator.
- Structs can declare **constructors** that **have parameters**.
- Structs **do not support inheritance**, but they can **implement interfaces**.
- A struct **cannot be null**, and a struct variable **cannot be assigned null** unless the variable is declared as a **nullable type**.
- Structs can include **constructors**, **constants**, **fields**, **methods**, **properties**, **indexers**, **operators**, **events** & **nested types**.
- Structs **cannot include a parameterless constructor** or a **destructor**.
- Structs **cannot inherit another structure** or **class**, and it **cannot be the base of a class**.
- **Struct members** **cannot be specified as `abstract`, `sealed`, `virtual`, or `protected`**.


```cs
struct Book
{
    public string Title;
    public string Author;
    public int Pages;
}

class BookClass
{
    public string Title;
    public string Author;
    public int Pages;
}
```

### Declaration

eg:
```cs
struct Coordinate
{
    public int x;
    public int y;
}
```




A **`struct`** object can be created **with** or **without** the **`new`** operator, same as primitive type variables.

```cs
struct Coordinate
{
    public int x;
    public int y;
}

Coordinate point = new Coordinate();
Console.WriteLine(point.x); //output: 0  
Console.WriteLine(point.y); //output: 0
```

If you declare a variable of **`struct`** type **without** using **`new`** keyword, it does not call any constructor, so all the members **remain unassigned**. Therefore, you **must assign values** to each member before accessing them, otherwise, it will give a compile-time error.

```cs
struct Coordinate
{
    public int x;
    public int y;
}

Coordinate point;
Console.Write(point.x); // Compile time error  

point.x = 10;
point.y = 20;
Console.Write(point.x); //output: 10  
Console.Write(point.y); //output: 20
```

### `readonly` struct
You use the readonly modifier to declare that a structure type is **immutable**. All data members of a **`readonly`** struct **must be** **read-only** as follows:

- Any field declaration **must** have the **`readonly`** modifier.
- Any property, including auto-implemented ones, **must be read-only**. In C# 9.0 and later, a property may have an init accessor.


https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct#readonly-struct

### Structs vs Classes
Due to their memory allocation differences, **structs are generally** **faster** **than classes**. If you’re working with a large amount of data, structs can be more efficient because they don’t require the overhead of heap memory allocation.

However, there are some cases where classes are faster than structs. For example, when copying large objects, classes can be more efficient because they only copy a reference to the object instead of the object itself.

Another advantage of using structs is that they are **value types**, meaning that they are copied by value rather than by reference. This can be useful in situations where you want to ensure that the original data is not modified by any subsequent operations.

On the other hand, classes are **reference types**, which means that they are passed by reference. This can be useful in situations where you want to modify the original data without creating a new copy of it.


### Best Practices for Using Structs and Classes

- When using structs, it’s important to keep their **size small**, so they’re stored on the stack instead of the heap. This can help to improve performance and reduce memory usage.

- When using classes, it’s a good idea to use **inheritance** to create hierarchies of objects with shared properties and methods. This can help to reduce code duplication and make your code more maintainable.

- Another important consideration when using structs and classes in C# is to use them appropriately based on their intended purpose. Structs are **best used for small, simple data structures that don’t require a lot of functionality**, while classes are better suited for **more complex objects with behavior and functionality**.



### Common Mistakes to Avoid

- One common mistake when using structs is to make them too large. If your struct is too large, it will be stored on the heap instead of the stack, which can cause **performance issues**.

- Another mistake is to use a class when a struct would be more appropriate. If you’re working with simple data types, using a struct can be more efficient and improve performance.

- It’s also important to note that structs are **value types**, while classes are **reference types**. This means that when you pass a struct to a method or assign it to a variable, a copy of the struct is created. This can lead to unexpected behavior if you’re not careful.

- Additionally, structs cannot inherit from other structs or classes, and they cannot be used as a base for other types. If you need to create a more complex data structure, a class may be a better choice.





### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct

https://www.programiz.com/csharp-programming/struct

https://www.tutorialsteacher.com/csharp/csharp-struct

**Choosing Between Class and Struct** \
https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/choosing-between-class-and-struct

https://www.bytehide.com/blog/struct-vs-class-csharp


## virtual
C# virtual method is a method that can be **redefined in derived classes.**

a virtual method has an implementation in a base class as well as derived the class. It is used when a method's basic functionality is the same but sometimes more functionality is needed in the derived class. A virtual method is created in the base class that can be overriden in the derived class.

**virtual** keyword is used to modify a method, property, indexer, or event declaration and allow for it to be overridden in a derived class.

<aside>
📌 It is an error to use the `virtual` modifier on a static property.

</aside>

<aside>
📌 A virtual inherited property can be overridden in a derived class by including a property declaration that uses the `override` modifier.

</aside>

### ref
[https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual)
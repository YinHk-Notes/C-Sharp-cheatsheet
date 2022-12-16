## Static

- **Static** Classes
- **Static** Class Members

<aside>
📌 Static means not unique
</aside>


Use the static modifier to declare a static member,  which belongs to the type itself rather than to a specific object. Static cannot be instantiated. The static modifier can be used with classes, fields, methods, properties, operators, events, and constructors. (A non-static class can contain static methods, fields, properties, or events. Static class should have static member only, a static class can only contain static data members, static methods, and a static constructor. It is not allowed to create objects of the static class.  Static class cannot be instantiated [create objects of the static class], and cannot inherit a static class from another class. )


It is more typical to declare a non-static class with some static members, than to declare an entire class as static. Two common uses of **static fields** are to **keep a count of the number** of objects that have been instantiated, or to **store a value that must be shared among all instances**.

Static methods can be **overloaded** but **not overridden**, because they belong to the class, and not to any instance of the class. Static method are shared by all objects of the class, one copy for all objects. A **static method**, which means that it can be accessed without creating an object of the class, unlike **public**, which can only be accessed by objects

Static methods and properties cannot access non-static fields and events in their containing type, and they cannot access an instance variable of any object unless it's explicitly passed in a method parameter.

Although a field cannot be declared as **static const**, a [const](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/const) field is essentially static in its behavior. It belongs to the type, not to instances of the type. Therefore, const fields can be accessed by using the same ClassName.MemberName notation that's used for static fields. No object instance is required.

<aside>
⚠️ C# does not support static local variables (that is, variables that are declared in method scope

</aside>
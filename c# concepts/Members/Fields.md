## Fields


**Fields** are **variables declared at class scope**. 

A field may be a built-in numeric type or an instance of another class.

A field is a variable of any type that is declared directly in a **class or struct**. 

**Fields** are members of their containing type.

A **class or struct** may have instance fields or `static` fields or both. 
Instance fields are specific to an instance of a type. If you have a **class T**, with an instance **field F**, 
you can create two objects of **type T**, and modify the value of F in each object without affecting the value in the other object. By contrast, a static field belongs to the class itself, and is shared among all instances of that class. 

Changes made from instance A will be visibly immediately to instances B and C if they access the field. eg:



```cs
// private field
private DateTime date;

// public field (Generally not recommended.)
public string day;
```



### ref
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/fields


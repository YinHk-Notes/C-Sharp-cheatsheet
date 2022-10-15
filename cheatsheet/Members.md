# Members

**Classes** and **structs** have members that represent their data and behavior.

eg **Fields, properties, constants, methods , constructors…**

memebers

- fields
- properties
- constants
- methods
- constructors

### Field

Fields are **variables declared at class scope** A field may be a built-in numeric type or an instance of another class.A field is a variable of any type that is declared directly in a **class** or **struct**. Fields are members of their containing type.A class or struct may have instance fields or static fields or both. Instance fields are specific to an instance of a type. If you have a class T, with an instance field F, you can create two objects of type T, and modify the value of F in each object without affecting the value in the other object. By contrast, a static field belongs to the class itself, and is shared among all instances of that class. Changes made from instance A will be visibly immediately to instances B and C if they access the field. eg:

```csharp
// private field
private DateTime date;

// public field (Generally not recommended.)
public string day;
```

### Constant

Constants are **declared with the const modifier.**
Constants are immutable values which are known at compile time and do not change for the life of the program. Constants are declared with the const modifier. Only the C# built-in types (excluding [System.Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)) may be declared as const. eg

```csharp
const int months = 12;
const int weeks = 52;
const int days = 365;
```

### Properties

Properties **enable a class to expose a public way of getting and setting values**,  while hiding implementation or verification code.  Properties combine aspects of both **fields** and **methods**.

<aside>
💬 類似field, 但可public 得到和設定其value
</aside>

- Properties **enable a class to expose a public way of getting and setting values**, while hiding implementation or verification code.
- A [get](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/get) property accessor is used to **return the property value**, and a [set](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/set) property accessor is used to **assign a new value**. These accessors can have different access levels. For more information, see [Restricting Accessor Accessibility](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/restricting-accessor-accessibility).**
- The [value](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/value) keyword is used to define the value being assigned by the set accessor.

**syntax:**

```csharp
<Access Specifier> <Return Type> <property Name>{
	get{ return the field’s value  ;}
	set{  the field’s variable  = value;}
}
```

Eg:

```csharp

class Person{
  
	private string name; // field
  public string Name   // property{
    get { return name; }
    set { name = value; }
  }
}
class Program{
  static void Main(string[] args){

    Person myObj = new Person();
    myObj.Name = "Liam";

    Console.WriteLine(myObj.Name);
  }
}
```

**OR**

```csharp
class Person{
  public string Name  // property
  { get; set; }
}
class Program{
  static void Main(string[] args){

    Person myObj = new Person();
    myObj.Name = "Liam";
    Console.WriteLine(myObj.Name);
  }
}
```

<aside>
💬 Propety’s name is **same** to the field’s name, but need to **capitalize first word**.

</aside>

**The get accessor:** 

<aside>
📌 The body of the get accessor resembles that of a method. It must **return a value of the property type**.
</aside>

**The set accessor:** 

<aside>
📌 a method whose return type is [void](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/void). It uses an **implicit parameter called value**, whose type is the type of the property.
</aside>





[Fields](https://www.notion.so/Fields-cee8a2b63e21426f9125e3c76ce68494)

[Constant](https://www.notion.so/Constant-05eccd7af10f40f8b7c2b7a76ada485b)

[Properties](https://www.notion.so/Properties-cf3a1994cb4442d8b2964e63d2043d22)

[Constructor](https://www.notion.so/Constructor-3a73e2e69e7a439c87dcfab35e534d9f)

[method](https://www.notion.so/method-8f0bd3bed61d4bef9d0ca61c245df702)

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

[Fields](https://www.notion.so/Fields-cee8a2b63e21426f9125e3c76ce68494)

[Constant](https://www.notion.so/Constant-05eccd7af10f40f8b7c2b7a76ada485b)

[Properties](https://www.notion.so/Properties-cf3a1994cb4442d8b2964e63d2043d22)

[Constructor](https://www.notion.so/Constructor-3a73e2e69e7a439c87dcfab35e534d9f)

[method](https://www.notion.so/method-8f0bd3bed61d4bef9d0ca61c245df702)

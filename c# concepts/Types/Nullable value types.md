## Nullable types

A **nullable value type** `T?` represents all values of its **underlying value type `T`** and an **additional `null` value**. Use a nullable value type when you need to represent the undefined value of an underlying value type. 
ou can refer to a nullable value type with an underlying type **`T`** in any of the following interchangeable forms: **`Nullable<T>`** or **`T?`**.

A **value type cannot be assigned a null value**. For example, **`int i = null`** will give you a compile time error. 

**Nullable types** that allow you to **assign null to value type variables**. You can declare nullable types using **`Nullable<T>`** where **`T`** is a type.

You typically use a nullable value type when you need to represent the undefined value of an underlying value type. For example, a Boolean, or bool, variable can only be either true or false. However, in some applications a variable value can be undefined or missing. For example, a database field may contain true or false, or it may contain no value at all, that is, **`NULL`**. You can use the **`bool?`** type in that scenario.

eg:
```cs
Nullable<int> i = null;
```

use the `'?'` operator to shorthand the syntax e.g. `int?`, `long?` instead of using `Nullable<T>`.
```cs
double? pi = 3.14;
char? letter = 'a';

int m2 = 10;
int? m = m2;

bool? flag = null;

// An array of a nullable value type:
int?[] arr = new int?[10];

int? i = null;
double? D = null;
```

Conversion from a nullable value type to an underlying type.
Use the `'??'` operator to assign a nullable type to a non-nullable type
```cs
int? a = 28;
int b = a ?? -1;
Console.WriteLine($"b is {b}");  // output: b is 28

int? c = null;
int d = c ?? -1;
Console.WriteLine($"d is {d}");  // output: d is -1
```





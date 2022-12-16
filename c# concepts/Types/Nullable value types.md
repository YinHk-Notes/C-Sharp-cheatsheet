## Nullable types

A **nullable value type** `T?` represents all values of its underlying value type T and an additional null value. Use a nullable value type when you need to represent the undefined value of an underlying value type.

A value type cannot be assigned a null value. For example, `int i = null` will give you a compile time error. Nullable types that allow you to assign null to value type variables. You can declare nullable types using `Nullable<t>` where `T` is a type.

You typically use a nullable value type when you need to represent the undefined value of an underlying value type. For example, a Boolean, or bool, variable can only be either true or false. However, in some applications a variable value can be undefined or missing. For example, a database field may contain true or false, or it may contain no value at all, that is, NULL. You can use the bool? type in that scenario.

eg:
```cs
Nullable<int> i = null;
```
```cs
double? pi = 3.14;
char? letter = 'a';

int m2 = 10;
int? m = m2;

bool? flag = null;

// An array of a nullable value type:
int?[] arr = new int?[10];
```

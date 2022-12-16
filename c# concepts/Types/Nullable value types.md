## Nullable types

A **nullable value type** `T?` represents all values of its underlying value type T and an additional null value. Use a nullable value type when you need to represent the undefined value of an underlying value type.

You typically use a nullable value type when you need to represent the undefined value of an underlying value type. For example, a Boolean, or bool, variable can only be either true or false. However, in some applications a variable value can be undefined or missing. For example, a database field may contain true or false, or it may contain no value at all, that is, NULL. You can use the bool? type in that scenario.



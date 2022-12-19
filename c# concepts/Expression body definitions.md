### Expression body definitions
You can use an expression body definition whenever the logic for any supported member, such as a method or property, consists of a single expression. Expression-bodied members provide a minimal and concise syntax to define properties and methods. It helps to eliminate boilerplate code and helps writing code that is more readable.

syntax:
```
member => expression;
```
Expression body definitions can be used with the following type members:

- Method
- Read-only property
- Property
- Constructor
- Finalizer
- Indexer


An expression-bodied method consists of a single expression that returns a value whose type matches the method's return type, or, for methods that return void, that performs some operation.
```cs
int GetRectangleArea(int length, int breadth) 
{
    return length * breadth;
} 

// can be written as 
int GetRectangleArea(int length, int breadth) => length * breadth;
```

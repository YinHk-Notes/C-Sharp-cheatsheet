## Method

Syntax
```
<Access Specifier> <Return Type> <Method Name> (Parameter List) {
    //...statement...
}
```

> Methods and Functions are the same in C#.                                                                                   However, Methods are used in C# and are functions that operate through a designated class. A method is a group of statements that together perform a task. Every C# program has at least one class with a method named **Main**.

### Void method

void isn't allowed in the parameter list of a method. A method that takes no parameters and returns no value, 
the return type is “void”.


```CS
void SampleMethod(){
	// Body of the method.**
}
```

### Method Overloading
With method overloading, multiple methods can have the same name with **different parameters** or **different type of parameters**.
```cs
int MyMethod(int x)
float MyMethod(float x)
double MyMethod(double x, double y)
```
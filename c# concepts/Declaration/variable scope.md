## Variable Scope
In C#, a variable has three types of scope:

-   Class Level Scope
-   Method Level Scope
-   Block Level Scope

### C# Class Level Variable Scope
when we declare a variable inside a class, the variable can be accessed within the class. This is known as **class level variable scope**.
Class level variables are known as fields and they are declared outside of methods, constructors, and blocks of the class.

```cs
class Student
{
    private string _firstName = "Bruce"; 
    private string _lastName = "Lee";
    
    public void DisplayFullName()
    {
        Console.WriteLine(_firstName + " " + _lastName);
    }

    public string FullName
    {
        get
        {
            return _firstName + " " + _lastName; 
        }
    }
}
```

### Method Level Variable Scope
When we declare a variable inside a method, the variable cannot be accessed outside of the method. This is known as method level variable scope.

It cannot be accessed outside the method


### Block Level Variable Scope
When we declare a variable inside a block (for loop, while loop, if..else), the variable can only be accessed within the block. This is known as block level variable scope.



### ref 
https://www.programiz.com/csharp-programming/variable-scope

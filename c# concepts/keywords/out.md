## out(parameter modifier)

`out` allows you to pass parameters using **references** and to **change the values** of those parameters as well.

`out` keyword is used to pass arguments to method as a **reference type**.

`out` is used to state that the **parameter** passed **must be modified by the method**.



You can use the out keyword in two contexts:
- As a **parameter modifier**, which lets you pass an argument to a method **by reference** rather than by **value**.
- In **generic type parameter** declarations for **interfaces** and **delegates**, which specifies that a **type** parameter is **covariant**.


> The `out` keyword is identical to the `ref` keyword, with the exception that `ref` needs the variable to be initialized prior to being passed. It is similar to `ref` keyword. But the main difference between `ref` and `out` keyword is that ref needs that the variable must be initialized before it passed to the method. But out parameter doesn’t require the variables to be initialized before it passed to the method.

-   In c#, `out` keyword is used to pass arguments to the method as a **reference type**.
-   It is also similar to the in keyword but the _in_ keyword does not allow the method that called to change the argument value but `ref` allows.
-   For using _out_ keyword as a parameter both the method definition and calling method must use the _out_ keyword explicitly.
-   The out parameters are not allowed to use in asynchronous methods.
-   The out parameters are not allowed to use in iterator methods.
-   There can be more than one out parameter in a method.
-   At the time of method call, out parameter can be declared inline. But the inline out parameters can be accessed in the same block of code where it calls.
-   Method overloading can also be done using out parameters.
-   Properties cannot be passed as out parameters as these are not variables.
-   Up to C# 6.0, a user first declares the variable then it can only pass as an out argument. But from C# 7.0, excepting a separate variable declaration, the user can also declare the out variable in the argument list of the method call.

```cs
// No need to initialize 
// the variable here
data_type variable_name;

Method_Name(out variable_name);

// you can also convert both above two 
// lines of codes as follows from
//  C# 7.0 onwards
Method_Name(out data_type variable_name);
```




>  When working with the out keyword in C#, both the method signature and the calling method **must explicitly specify the `out` keyword**.

Eg:
```cs
int number;
OutDemo(out number);
Console.WriteLine(number); //The value is now 100
void OutDemo(out int number)
{
    number = 100;
}
```



```cs
// Main method
    static public void Main()
    {
 
        // Declaring variable
        // without assigning value
        int i;
 
        // Pass variable i to the method
        // using out keyword
        Addition(out i);
 
        // Display the value i
        Console.WriteLine("The addition of the value is: {0}", i);
    }
 
    // Method in which out parameter is passed
    // and this method returns the value of
    // the passed parameter
    public static void Addition(out int i)
    {
        i = 30;
        i += i;
    }
}
```

### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out-parameter-modifier \
https://www.infoworld.com/article/3678688/how-to-use-the-in-out-and-ref-keywords-in-net-core.html \
https://www.pluralsight.com/guides/csharp-in-out-ref-parameters \
https://www.geeksforgeeks.org/out-parameter-with-examples-in-c-sharp/



## params
A method in C# defines a number of arguments and their types in the method declaration.

When a method is called, it expects the same number and types of the arguments passed by the caller code, unless there are **optional parameters**.

In C#, the **`params`** keyword in C# allows a method to accept a **variable number of arguments**.

By using params keyword in a method argument definition, we can pass a number of arguments. 

`params` can be used to declare method that does not know the number of parameters.

Parmas are also useful to write "clean code". Instead of using various overloaded methods to pass multiple values, we can simply **create an array and pass it as an arugment** or a comma separated list of values.

Restriction:
- No additional parameters are permitted after the `params` keyword in a method declaration.
- Only one `params` keyword is permitted in a method declaration.

When you call a method with a `params` parameter, you can pass in:

-   A comma-separated list of arguments of the type of the array elements.
-   An array of arguments of the specified type.
-   No arguments. If you send no arguments, the length of the `params` list is zero.



Eg:
```cs
public static int TotalMarks(params int[] list)
    {
        int total = 0;
        for (int i = 0; i < list.Length; i++)
            total += list[i];
        return total;
    }

    public static string AllSubjects(params string[] subjects)
    {
        System.Text.StringBuilder builder = new System.Text.StringBuilder();
        for (int i = 0; i < subjects.Length; i++)
        {
            builder.Append(subjects[i]);
            builder.Append(" ");
        }
        return builder.ToString();
    }
```

```cs

public class MyClass
{
    public static void UseParams(params int[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();
    }

    public static void UseParams2(params object[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        // You can send a comma-separated list of arguments of the
        // specified type.
        UseParams(1, 2, 3, 4);
        UseParams2(1, 'a', "test");

        // A params parameter accepts zero or more arguments.
        // The following calling statement displays only a blank line.
        UseParams2();

        // An array argument can be passed, as long as the array
        // type matches the parameter type of the method being called.
        int[] myIntArray = { 5, 6, 7, 8, 9 };
        UseParams(myIntArray);

        object[] myObjArray = { 2, 'b', "test", "again" };
        UseParams2(myObjArray);

        // The following call causes a compiler error because the object
        // array cannot be converted into an integer array.
        //UseParams(myObjArray);

        // The following call does not cause an error, but the entire
        // integer array becomes the first element of the params array.
        UseParams2(myIntArray);
    }
}
/*
Output:
    1 2 3 4
    1 a test

    5 6 7 8 9
    2 b test again
    System.Int32[]
*/

```


### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/params

https://www.javatpoint.com/c-sharp-params

https://www.c-sharpcorner.com/UploadFile/c63ec5/use-params-keyword-in-C-Sharp/

https://www.c-sharpcorner.com/UploadFile/manas1/params-in-C-Sharp-pass-variable-number-of-parameters-to-method/


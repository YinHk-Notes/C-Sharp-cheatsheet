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



### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/params

https://www.javatpoint.com/c-sharp-params

https://www.c-sharpcorner.com/UploadFile/c63ec5/use-params-keyword-in-C-Sharp/

https://www.c-sharpcorner.com/UploadFile/manas1/params-in-C-Sharp-pass-variable-number-of-parameters-to-method/


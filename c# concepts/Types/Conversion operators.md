## Conversion operators
A conversion operator declaration introduces a **user-defined conversion**, which augments the pre-defined implicit and explicit conversions.

A conversion operator declaration that includes the **`implicit`** keyword introduces a user-defined implicit conversion. Implicit conversions can occur in a variety of situations, including function member invocations, cast expressions, and assignments. 


A conversion operator declaration that includes the **`explicit`** keyword introduces a user-defined explicit conversion. Explicit conversions can occur in cast expressions


For a given source type `S` and target type `T`, if `S` or `T` are nullable value types, let `S₀` and `T₀` refer to their underlying types; otherwise, `S₀` and `T₀` are equal to `S` and `T` respectively. A class or struct is permitted to declare a conversion from a source type `S` to a target type `T` only if all of the following are true:

-   `S₀` and `T₀` are different types.
    
-   Either `S₀` or `T₀` is the instance type of the class or struct that contains the operator declaration.
    
-   Neither `S₀` nor `T₀` is an _interface\_type_.
    
-   Excluding user-defined conversions, a conversion does not exist from `S` to `T` or from `T` to `S`.



### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/classes#15104-conversion-operators

## Partial method

A partial class or struct may contain a partial method. 

One part of the class contains the **signature of the method**. An **implementation** can be defined in the same part or another part.

> If the implementation is not supplied, then the method and all calls to the method are removed at compile time. Implementation may be required depending on method signature.

A partial method isn't required to have an **implementation** in the following cases:
- It doesn't have any accessibility modifiers (including the default private).
- It returns void.
- It doesn't have any out parameters.
- It doesn't have any of the following modifiers virtual, override, sealed, new, or extern.


Partial methods enable the implementer of one part of a class to **declare a method**. The **implementer** of another part of the class can define that method.

-   **Template code**: The template reserves a method name and signature so that generated code can call the method. These methods follow the restrictions that enable a developer to decide whether to implement the method. If the method is not implemented, then the compiler removes the method signature and all calls to the method. The calls to the method, including any results that would occur from evaluation of arguments in the calls, have no effect at run time. Therefore, any code in the partial class can freely use a partial method, even if the implementation is not supplied. No compile-time or run-time errors will result if the method is called but not implemented.
-   **Source generators**: Source generators provide an implementation for methods. The human developer can add the method declaration (often with attributes read by the source generator). The developer can write code that calls these methods. The source generator runs during compilation and provides the implementation. In this scenario, the restrictions for partial methods that may not be implemented often aren't followed.


### ref
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/partial-classes-and-methods



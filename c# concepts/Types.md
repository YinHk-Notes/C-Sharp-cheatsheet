## Types

The variables in C#, are categorized into the following types: 

- **Value Types**
    
    The value types directly contain data, can be assigned a value directly.
  
    **eg:** 
    ```csharp
    byte num = 0xA;
    
    int i = 5;
    
    char c = 'Z';
    ```
    
    > **structs** are also value types
    
   
- **Reference Types**

    The **reference types** do not contain the actual data stored in a variable, but they contain a reference to the variables.
    
    A type that is defined as a [class](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class), [delegate](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/delegate), array, or [interface](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface) 

- **Pointer Types**
    
  Store the memory address of another type. Pointers in C# have the same capabilities as the pointers in C or C++.
  
  Syntax:
  ```
  type* identifier;
  ```
  eg:
  ```csharp
    char* cptr;
    int* iptr;
   ```
  

### value types vs reference type
**Value types** differ from reference types in that variables of the value types directly contain their data, whereas variables of the **reference types** store references to their data, the latter being known as **objects**. 

In other words, they refer to a memory location. Using multiple variables, the reference types can refer to a memory location. If the data in the memory location is changed by one of the variables, the other variable automatically reflects this change in value.


### **C# Type Casting**

Type casting is when you assign a value of one data type to another [type.In](http://type.in/) C#, there are two types of casting:

- **Implicit Casting** (automatically) - converting a smaller type to a larger type size char → int → long → float → double
- **Explicit Casting** (manually) - converting a larger type to a smaller size type. Explicit casting must be done manually by placing the type in parentheses in front of the value double → float → long → int → char

[Casting and type conversions - C# Programming Guide](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions)

[](https://www.w3schools.com/cs/cs_type_casting.asp)

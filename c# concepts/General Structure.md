## General Structure of C#
C# programs can consist of one or more files. Each file can contain zero or more `namespaces`. A `namespace` can contain types such as `classes`, `structs`, `interfaces`, `enumerations`, and `delegates`.

```cs
// A skeleton of a C# program 
using System;
namespace YourNamespace
{
    
    class YourClass 
    {
    
    }

    struct YourStruct
    {
    
    }

    interface IYourInterface 
    {
    
    }

    delegate int YourDelegate();

    enum YourEnum 
    {
    
    }

    namespace YourNestedNamespace
    {
        struct YourStruct 
	{
	
        }
    }

    class YourMainClass
    {
        static void Main(string[] args) 
	{
            //Your program starts here...
        }
    }
}
```

- The **Main** method is the entry point for all C# programs. The Main method states what the class does when executed.
- C# is case sensitive.
- The program execution starts at the Main method.
- Unlike Java, program file name could be different from the class name.
- All statements and expression must end with a semicolon (;).




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

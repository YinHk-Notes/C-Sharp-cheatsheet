## Namespace

### Why using namespace?
- namespaces used to organize its many classes.
- declaring your own namespaces can help you **control the scope of class and method** names in larger programming projects.
- similar to "Package" in java

### Namespaces have the following properties:

- They organize large code projects.
- They're delimited by using the `.` operator.
- The using directive obviates the requirement to specify the name of the namespace for every class.
- The global namespace is the "root" namespace: global`::`System will always refer to the .NET System namespace.



The namespace keyword is used to declare a scope. The ability to create scopes within your project helps organise code and lets you create globally-unique types.

```cs
namespace N1     // N1
{
    class C1      // N1.C1
    {
        class C2   // N1.C1.C2
        {
        }
    }
    namespace N2  // N1.N2
		{
        class C2   // N1.N2.C2
        {
        }
    }
}
```






### ref 
https://www.c-sharpcorner.com/article/working-with-namespaces-in-C-Sharp/

https://www.delftstack.com/howto/csharp/csharp-include-class/





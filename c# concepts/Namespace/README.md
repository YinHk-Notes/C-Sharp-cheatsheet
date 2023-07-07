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
- Namespaces in C# can be nested.
- If two classes are in the same namespace, they will **'know'** about each other and be in the **same scope**.



The namespace keyword is used to **declare a scope**. The ability to create scopes within your project helps organise code and lets you create globally-unique types.


A namespace in C# is a logically **arranged class, struct, interface, enum, or delegate**. **Namespaces in C# can be nested**, meaning you can define a class and include it in another class.

A class in a specific namespace and a class from another **`.cs`** file can be called by **`using <namespace>;`**.




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

### Class with same namespace

To give a class a namespace, we simply wrap the class in another set of curly braces and declare the namespace like this:
```cs
namespace ExampleNameSpace
{

  public class ExampleClass
  {
    // all ExampleClass methods, fields, and properties here
  }

}

```
We can wrap other classes in the same namespace to make them available to each other:
```cs
namespace ExampleNameSpace
{

  public class SecondClass
  {
    // all SecondClass methods, fields, and properties here
  }

}

```

Examplpe:
```cs
namespace App
{
    public class MyClass
    {
        public MyClass()
        {
            myVariable = 1;
        }
    
        public int myVariable;

        public static int StaticVariable = 3;
    
    }
}
```

```cs
using App; // at the beginning of your .cs file
MyClass myClass = new MyClass();
var v = myClass.myVariable; // defined in the App namespace
var stat = MyClass.StaticVariable;
```

or you can use the **full identifier**
```cs
App.MyClass myClass = new App.MyClass();
var v = myClass.myVariable;
var stat = App.MyClass.StaticVariable;
```





### How to access other class
- Use **`using <namespace>`** to Include a Class Into Another Class in C#
- Use **Inheritance** to Include a Class Into Another Class in C#


### Use `using <namespace>`

Example:

```cs
// WelcomeClass.cs

namespace SubClassNamS
{
    public class WelcomeClass
    {
        public static void Welcome()
        {
            // To show a message box when this method from `WelcomeClass` will be called by another class
            MessageBox.Show("Hello World!", "Test Subject", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
```


```cs
// Form1.cs

// Use `using` Namespace of another class from a different file
using static SubClassNamS.WelcomeClass;

namespace IncludeClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Button `Button1` click event
        private void button1_Click(object sender, EventArgs e)
        {
            // No need to mention `WelcomeClass` here
            Welcome();
        }
    }
}
```
> Including `SubClassNamS.WelcomeClass` enables us to access `WelcomeClass` from the `SubClassNamS` namespace.

> This method helps you import or include a `WelcomeClass` class into the `Form1` class by introducing its methods and members using namespace in C#.


### Same namespace across multiple different files

> Namespaces can (and usually are) split across multiple code files.

> The Contacts namespace will contain all classes defined across files that define that namespace.


> The classes in those namespaces are compiled separately, but (generally, leaving out external resources for now) into a single output file (i.e. an exe or a dll).





### ref 
https://www.c-sharpcorner.com/article/working-with-namespaces-in-C-Sharp/

https://www.delftstack.com/howto/csharp/csharp-include-class/

https://www.learnhowtoprogram.com/fidgetech-3-c-and-net/3-0-lessons-25-34-objects-and-methods/3-0-0-28-namespaces-and-file-structure






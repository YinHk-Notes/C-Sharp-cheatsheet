### class

#### declare a class
static class
```cs
public static ClassName 
{
   ....
}
```
public class
```cs
public ClassName 
{
   ....
}
```
private class
```cs
//No need tospecify private which is default 
ClassName 
{
   ....
}
```

### Creating objects
Using `new` keywords for instantiating an object
```
ClassName objName = new ClassName();
```

### Access the object 
```
ClassName objName
```

#### Acess the object's method inside `Main()`
```cs

class Script
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hi there!");
		Script script = new Script();
		script.myMethod();
	}
	public void myMethod()
   	{
               //....
   	}
}
```

### Access other class
```cs
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
namespace ConsoleApplication1  
{  
    class PrivateVariable  
    {  
        private int i = 10; //Declaring and initializing a private variable  
        public void DisplayVariable()  
        {  
            Console.Write("The Value of Private Variable=" + i); //Accessing Private variable with in a public methode  
        }  
    }  
    class DisplayPrivateVariable  
    {  
        static void Main()  
        {  
            PrivateVariable objPrivateVariable = new PrivateVariable();  
            objPrivateVariable.DisplayVariable(); //Calling the public method  
        }  
    }  
}
```
Using inner class:
```cs
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
namespace ConsoleApplication1  
{  
    class PrivateVariable2  
    {  
        class Outerclass  
        {  
            private int i = 10;  
            private int j = 20;  
            class Innerclass  
            {  
                static void Main()  
                {  
                    Outerclass objouter = new Outerclass();  
                    int Result = objouter.i + objouter.j;  
                    Console.Write("Sum=" + Result);  
                    Console.ReadLine();  
                }  
            }  
        }  
    }  
}
```
Using Properties:
```cs

using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
namespace ConsoleApplication1  
{  
    class Employee  
    {  
        private int _EmpID = 1001;  
        private string _EmpName;  
        public int EmpID  
        {  
            get  
            {  
                return _EmpID;  
            }  
        }  
        public string EmpName  
        {  
            get  
            {  
                return _EmpName;  
            }  
            set  
            {  
                _EmpName = "Smith";  
            }  
        }  
    }  
    class AcessEmployee  
    {  
        static void Main()  
        {  
            Employee objEmployee = new Employee();  
            Console.WriteLine("Employee ID: " + objEmployee.EmpID);  
            Console.WriteLine("Employee old Name: " + objEmployee.EmpName);  
            objEmployee.EmpName = "Dyne Smith";  
            Console.WriteLine("Employee New Name: " + objEmployee.EmpName);  
            Console.ReadLine();  
        }  
    }  
}  

```



### ref 
https://www.c-sharpcorner.com/blogs/how-to-access-private-variables-of-a-class-in-another-class-in-c-sharp

https://www.w3schools.com/cs/cs_classes.php


<p align="center"><img src="https://github.com/YinHk-Notes/Csharp/blob/main/csharp-logo.png" height="200px"></p>

# Csharp
This is code, notes, and snippets about C#
-- --

**#Learning C#** :



*   [https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/)
*   [https://www.w3schools.com/cs/](https://www.w3schools.com/cs/)

**#naming convention:** 
*  **Variable naming 要 camel case** 
*  **Method name 大階開頭** 
*  **Access modifier 細階** 
*  **void 細階**
*  **type 細階**
*  **class name 大階**

**#C# cheatsheet: [https://github.com/hcmue/CSharp-Cheatsheet](https://github.com/hcmue/CSharp-Cheatsheet)**
**#.NET Framework API 參考:** \
**[https://docs.microsoft.com/zh-tw/dotnet/api/?view=netframework-4.8](https://docs.microsoft.com/zh-tw/dotnet/api/?view=netframework-4.8)**

**#using System:[https://docs.microsoft.com/zh-tw/dotnet/api/system?view=netframework-4.8](https://docs.microsoft.com/zh-tw/dotnet/api/system?view=netframework-4.8)**

**#System Namespace:** \
The [System](https://docs.microsoft.com/en-us/dotnet/api/system?view=netframework-4.8) namespace contains fundamental classes and base classes that define commonly-used value and reference data types, events and event handlers, interfaces, attributes, and processing exceptions .using System means that we can use classes from the System namespace.


**#using System.Collection:** \
The namespace contains interfaces and classes that define various collections of objects, such as lists, queues, bit arrays, hash tables and dictionaries. \
**[https://docs.microsoft.com/en-us/dotnet/api/system.collections?view=netframework-4.8](https://docs.microsoft.com/en-us/dotnet/api/system.collections?view=netframework-4.8)**


**#using System.Collections.Generic:** \
The namespace contains interfaces and classes that define generic collections, which allow users to create strongly typed collections that provide better type safety and performance than non-generic strongly typed collections. \
**[https://docs.microsoft.com/zh-tw/dotnet/api/system.collections.generic?view=netframework-4.8](https://docs.microsoft.com/zh-tw/dotnet/api/system.collections.generic?view=netframework-4.8)**

**#General Structure of a C#:**  \
 C# programs can consist of one or more files. Each file can contain zero or more namespaces. A namespace can contain types such as classes, structs, interfaces, enumerations, and delegates.


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


**#**A C# console application must contain a **Main method**, in which control starts and ends. The Main method is where you create objects and execute other methods.The **Main method** is a **[static](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static)** method that resides inside a class or a struct.The** Main method** is where you create objects and execute other methods. The **Main method** is the entry point of a C# application. When the application is started, the **Main method** is the first method that is invoked.

*   The Main method is the entry point of an executable program; it is where the program control starts and ends.
*   Main is declared inside a class or struct. Main must be [static](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static) and it need not be [public](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/public). (In the earlier example, it receives the default access of [private](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/private).) The enclosing class or struct is not required to be static.
*   Main can either have a void, int, or, starting with C# 7.1, Task, or Task&lt;int>return type.

<table>
  <tr>
   <td>
using
   </td>
   <td>Here, using keyword is employed for fetching all the associated methods that are within the System namespace. Any C# program can have multiple using statements. <strong>using System</strong>; directive at the beginning of the program, you can directly use the <strong><a href="https://docs.microsoft.com/en-us/dotnet/api/system">System</a></strong> classes and methods 
   </td>
  </tr>
  <tr>
   <td>namespace
   </td>
   <td>Next statement is used for declaring a namespace which is <strong><span style="text-decoration:underline;">a collection of classes</span></strong> under a single unit; here "printHelloC#".
   </td>
  </tr>
  <tr>
   <td>Class
   </td>
   <td>Next, you have declared a class "Hello C#" using the keyword class which is used for preserving the concept of encapsulation.
   </td>
  </tr>
  <tr>
   <td>main()
   </td>
   <td>Inside a class, you can have multiple methods and declaring variable names. The static/void is a return value.
   </td>
  </tr>
  <tr>
   <td>Console.WriteLine()
   </td>
   <td>Console.WriteLine() is a predefined method used for displaying any string or variable's value in a C# program.Eg: <strong>Console.WriteLine("Hello World!");</strong>
   </td>
  </tr>
</table>



**#Comments**


**// A Hello World! program    **or** /* A "Hello World!" program in*/**


**#Types:**


**Custom Types**


You use the [struct](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/struct), [class](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class), [interface](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface), and [enum](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/enum) constructs to create your own custom types


**1. Value Types/Data Tyoes**


** eg:**


**byte num = 0xA;**


**int i = 5;**


**char c = 'Z';**


structs are also value types


**2. Reference Types**


A type that is defined as a [class](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class), [delegate](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/delegate), array, or [interface](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface) is a _reference type_


**[https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/)**


**[https://www.w3schools.com/cs/cs_data_types.asp](https://www.w3schools.com/cs/cs_data_types.asp)**


**#C# Type Casting**

Type casting is when you assign a value of one data type to another type.In C#, there are two types of casting:



*   Implicit Casting (automatically) - converting a smaller type to a larger type size \
char -> int -> long -> float -> double
*   Explicit Casting (manually) - converting a larger type to a smaller size type.Explicit casting must be done manually by placing the type in parentheses in front of the value \
double -> float -> long -> int -> char

**[https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions)**


**[https://www.w3schools.com/cs/cs_type_casting.asp](https://www.w3schools.com/cs/cs_type_casting.asp)**


**#Declare variables in C#:**


**syntax: **


**&lt;data_type> &lt;variable_names>; **


**eg:**


**char ch = 'g';**


**int xy = 6, roll = 42;**


**byte b = 22;**


**double pi = 3.14159;**


**float salary = 20000.0f;**


(When declaring variable must specify its type)


**or  syntax:**


**&lt;reference_type> &lt; variable_name>;**


**#Main() return values:**


The Main method can return **void** or **int.   **eg**:**


**static void Main()**


**{**


**    //...**


**}**


**or**


**static int Main()**


**{**


**    //...**


**    return 0;**


**}**


**#Console.WriteLine():**


Console.WriteLine() is used to output (print) values


**[https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline?view=netframework-4.8](https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline?view=netframework-4.8)**


**#Console.Readline():**


**to get user input. **


**[https://www.w3schools.com/cs/cs_user_input.asp](https://www.w3schools.com/cs/cs_user_input.asp)**


**#Console property and method:**


**[https://docs.microsoft.com/en-us/dotnet/api/system.console?view=netframework-4.8](https://docs.microsoft.com/en-us/dotnet/api/system.console?view=netframework-4.8)**


**#C# operator:**


**[https://docs.microsoft.com/zh-tw/dotnet/csharp/language-reference/operators/](https://docs.microsoft.com/zh-tw/dotnet/csharp/language-reference/operators/)**


**[https://www.w3schools.com/cs/cs_operators.asp](https://www.w3schools.com/cs/cs_operators.asp)**


**x++ increment**


**x- - decrement**


**x%y modulus**


**&&  and**


**||  or**


**!  not**


**# C#Math:**


**[https://www.w3schools.com/cs/cs_math.asp](https://www.w3schools.com/cs/cs_math.asp)**


**[https://docs.microsoft.com/zh-tw/dotnet/api/system.math?view=netframework-4.8](https://docs.microsoft.com/zh-tw/dotnet/api/system.math?view=netframework-4.8)**


**# Method: **


Methods are declared in a [class](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class) or [struct](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/struct) by specifying the access level such as public or private. A method is a group of statements that together perform a task. Every C# program has at least one class with a method named Main.To use a method, you need to define the method and Call the method. 


The syntax for defining a method in C#:


&lt;Access Specifier> &lt;Return Type> &lt;Method Name>(Parameter List) {


   Method Body


}


Methods and Functions are the same in C#.

However, Methods are used in C# and are functions that operate through a designated class. A method is a group of statements that together perform a task. Every C# program has at least one class with a method named Main.


**# Void method: ** void isn't allowed in the parameter list of a method. A method that takes no parameters and returns no value, the return type is “void”. 


**void SampleMethod()**


**{**


**    // Body of the method.**


**}**


**#Access modifiers:**


Access modifiers are keywords used to specify the declared accessibility of a member or a type. This section introduces the four access modifiers:



*   public
*   protected
*   internal
*   private

<table>
  <tr>
   <td>
<strong>Modifier</strong>
   </td>
   <td><strong>Description</strong>
   </td>
  </tr>
  <tr>
   <td>public
   </td>
   <td>The code is accessible for <span style="text-decoration:underline;">all classes</span>
   </td>
  </tr>
  <tr>
   <td>private
   </td>
   <td>The code is only accessible within the<span style="text-decoration:underline;"> same class</span>
   </td>
  </tr>
  <tr>
   <td>protected
   </td>
   <td>The code is accessible within the same class, or in a class that is inherited from that class. You will learn more about <a href="https://www.w3schools.com/cs/cs_inheritance.asp">inheritance</a> in a later chapter
   </td>
  </tr>
  <tr>
   <td>internal
   </td>
   <td>The code is only accessible within its own assembly, but not from another assembly. You will learn more about this in a later chapter
   </td>
  </tr>
</table>



[https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers)


**[https://www.w3schools.com/cs/cs_access_modifiers.asp](https://www.w3schools.com/cs/cs_access_modifiers.asp)**


**#Members **


# <span style="text-decoration:underline;">Classes</span> and <span style="text-decoration:underline;">structs</span> have <span style="text-decoration:underline;">members</span> that represent their data and behavior. 


eg Fields, properties, constants, methods , constructors….


**#Fields**


Fields are variables declared at class scope. A field may be a built-in numeric type or an instance of another class.A _field_ is a variable of any type that is declared directly in a [class](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class) or [struct](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/struct). Fields are _members_ of their containing type.A class or struct may have instance fields or static fields or both. Instance fields are specific to an instance of a type. If you have a class T, with an instance field F, you can create two objects of type T, and modify the value of F in each object without affecting the value in the other object. By contrast, a static field belongs to the class itself, and is shared among all instances of that class. Changes made from instance A will be visibly immediately to instances B and C if they access the field. eg:


// private field


       private DateTime date;


       // public field (Generally not recommended.)


       public string day;


**#Constant**


Constants are declared with the [const](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/const) modifier.Constants are immutable values which are known at compile time and do not change for the life of the program. Constants are declared with the [const](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/const) modifier. Only the C# built-in types (excluding [System.Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)) may be declared as const. eg


const int months = 12;


const int weeks = 52;


const int days = 365;


**#Class and object(instance)**


The class keyword is preceded by the access level. Because** [public](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/public) **is used in this case, **anyone can create instances of this class**. The name of the class follows the class keyword. The remainder of the definition is the class body, where the behavior and data are defined. Fields, properties, methods, and events on a class are collectively referred to as _class members_.  A class is a reference type. A program may create many objects of the same class. Objects are also called instances.


//Declaring an object of type MyClass.


MyClass mc = new MyClass();


//Declaring another object of the same type, assigning it the value of the first object.


MyClass mc2 = mc;


**#Declaring Classes**:


public class Customer


{


   // Fields, properties, methods and events go here...


}


**#Creating objects(instantiate)**: 


**A<span style="text-decoration:underline;"> class defines a type of object, but it is not an object itself.</span> An object is a concrete entity based on a class.Objects can be created by using the [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new) keyword followed by the name of the class**.


Customer object1 = new Customer();


**#creating object references:   eg **  


Customer object3 = new Customer();


Customer object4 = object3;


**#Class inheritance:  eg**


public class Manager : Employee


{


    // Employee fields, properties, methods and events are inherited


    // New Manager fields, properties, methods and events go here...


}


**#Struct:**


Structs share most of the same syntax as classes,but more limited than classes in the following ways:



*   Within a struct declaration, fields cannot be <span style="text-decoration:underline;">initialized </span>unless they are declared as const or static.
*   A struct cannot declare a parameterless constructor (a constructor without parameters) or a finalizer.
*   Structs are copied on assignment. When a struct is assigned to a new variable, all the data is copied, and any modification to the new copy does not change the data for the original copy. This is important to remember when working with collections of value types such as Dictionary&lt;string, myStruct>.
*   Structs are value types, unlike classes, which are reference types.
*   Unlike classes, structs can be instantiated(creating object) without using a <span style="text-decoration:underline;">new</span> operator.
*   Structs can declare constructors that have parameters.
*   Structs do not support inheritance, but they can implement interfaces.
*   A struct cannot be null, and a struct variable cannot be assigned null unless the variable is declared as a nullable type.

**#Declare struct:**


**public struct PostalAddress**


**{**


**    // Fields, properties, methods and events go here...**


**}**


**#Properties:**


Properties enable a class to expose a public way of getting and setting values, while hiding implementation or verification code. Properties combine aspects of both <span style="text-decoration:underline;">fields </span>and <span style="text-decoration:underline;">methods</span>.


(類似field, 但可public 得到和設定其value)

*   Properties enable a class to expose a public way of getting and setting values, while hiding implementation or verification code.
*   A [get](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/get) property accessor is used to return the property value, and a [set](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/set)property accessor is used to assign a new value. These accessors can have different access levels. For more information, see [Restricting Accessor Accessibility](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/restricting-accessor-accessibility).
*   The [value](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/value) keyword is used to define the value being assigned by the set accessor.

**syntax: **


&lt;Access Specifier> &lt;Return Type> &lt;property Name>{


  get{ <span style="text-decoration:underline;">return</span> the field’s value  ;}


  set{  the field’s variable  = <span style="text-decoration:underline;">value</span>;}


}


Eg:


class Person


{


  private string name; // field


  public string Name   // property


  {


    get { return name; }


    set { name = value; }


  }


}


class Program


{


  static void Main(string[] args)


  {


    Person myObj = new Person();


    myObj.Name = "Liam";


    Console.WriteLine(myObj.Name);


  }


}


OR


class Person


{


  public string Name  // property


  { get; set; }


}


class Program


{


  static void Main(string[] args)


  {


    Person myObj = new Person();


    myObj.Name = "Liam";


    Console.WriteLine(myObj.Name);


  }


}


(Propety’s name is<span style="text-decoration:underline;"> same</span> to the field’s name, but need to capitalize first word.)


**The get accesor: **The body of the get accessor resembles that of a method. It must **return a value of the property type**.


**The set accesor : **a method whose return type is [void](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/void). It uses an **implicit parameter called value**, whose type is the type of the property.** **

**[https://www.w3schools.com/cs/cs_properties.asp](https://www.w3schools.com/cs/cs_properties.asp)**

**#Constructor:**


Constructors are<span style="text-decoration:underline;"> methods</span> that are called when the object is first created. They are often used to **<span style="text-decoration:underline;">initialize</span> the data of an object**. **Constructor can have <span style="text-decoration:underline;">parameters</span>**. 


A constructor is a special method that is used to initialize objects. The advantage of a constructor, is that it is called when an object of a class is created. It can be used to set initial values for fields. Constructors enable the programmer to set default values, limit instantiation, and write code that is flexible and easy to read.A constructor is a method whose name is the same as the name of its class. Its method signature includes only the method name and its parameter list; it does not include a return type. eg:


private string last;


   private string first;


   


   public Person(string lastName, string firstName)


   {


      last = lastName;


      first = firstName;


   }


A static constructor is used to initialize any [static](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static) data, or to perform a particular action that needs to be performed once only.


**[https://www.w3schools.com/cs/cs_constructors.asp](https://www.w3schools.com/cs/cs_constructors.asp)**


**#Array:**


Declare an array by specifying the type of its elements:


**<span style="text-decoration:underline;">type[] arrayName</span>;**


**        // Declare a single-dimensional array. **


**        int[] array1 = new int[5];**


**        // Declare and set array element values.**


**        int[] array2 = new int[] { 1, 3, 5, 7, 9 };**


**        // Alternative syntax.**


**        int[] array3 = { 1, 2, 3, 4, 5, 6 };**


**        // Declare a two dimensional array.**


**        int[,] multiDimensionalArray1 = new int[2, 3];**


**        // Declare and set array element values.**


**        int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };**


**        // Declare a jagged array.**


**        int[][] jaggedArray = new int[6][];**


**        // Set the values of the first array in the jagged array structure.**


**        jaggedArray[0] = new int[4] { 1, 2, 3, 4 };**


arrays are actually objects, to get length of array: eg


int[] numbers = { 1, 2, 3, 4, 5 };


int lengthOfNumbers = numbers.Length;


***a single-dimensional array :  **eg int[] array = new int[5];


**dataType[] arrayRefVar = new dataType[arraySize];**


Array Initialization: eg  int[] array1 = new int[] { 1, 3, 5, 7, 9 };


Multidimensional Array: eg  int[, ,] array1 = new int[4, 2, 3];


Array Initialization: eg int[, ,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },{ { 7, 8, 9 }, { 10, 11, 12 } } };


Jagged Array:  


A jagged array is an array whose elements are arrays. The elements of a jagged array can be of different dimensions and sizes. eg:


int[][] jaggedArray = new int[3][];


jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };


jaggedArray[1] = new int[] { 0, 2, 4, 6 };


jaggedArray[2] = new int[] { 11, 22 };


using foreach in array:


foreach statement processes elements in increasing index order, starting with index 0 and ending with index Length - 1


int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };


foreach (int i in numbers)


{


    System.Console.Write("{0} ", i);


}


// Output: 4 5 6 1 2 3 -2 -1 0


Passing single-dimensional arrays as arguments:


void PrintArray(int[] arr)


{


    // Method code.


}


PrintArray(new int[] { 1, 3, 5, 7, 9 });


Passing multidimensional arrays as arguments:


void Print2DArray(int[,] arr)


{


    // Method code.


}


Print2DArray(new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } });


# **enum**


The enum keyword is used to declare an enumeration, a distinct type that consists of a set of named constants called the enumerator list. Eg:


enum Day {Sat, Sun, Mon, Tue, Wed, Thu, Fri};


**#Namespace**


The **namespace** keyword is used to declare a scope. The ability to create scopes within your project helps organize code and lets you create globally-unique types.


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


**# static (<span style="text-decoration:underline;">Static Classes</span> and <span style="text-decoration:underline;">Static Class Members</span>):(Static means <span style="text-decoration:underline;">not unique</span>)**


Use the static modifier to declare a static member, which <span style="text-decoration:underline;">belongs to the type itself rather than to a specific object</span>. Static cannot be<span style="text-decoration:underline;"> instantiated</span>. The static modifier can be used with classes, fields, methods, properties, operators, events, and constructors. (**A non-static class can contain static methods, fields, properties, or events. Static class should have static member only, a static class can only contain static data members, static methods, and a static constructor.It is not allowed to create objects of the static class. Static class cannot be instantiated[create objects of the static class], and cannot inherit a static class from another class.** )


It is more typical to declare a non-static class with some static members, than to declare an entire class as static. Two<span style="text-decoration:underline;"> common uses of **static fields**</span> are to **keep a count of the number of objects **that have been instantiated, or to** store a value that must be shared among all instances**.


Static methods can be overloaded but not overridden, because they belong to the class, and not to any instance of the class.Static method are shared by all objects of the class,one copy for all objects. A static method, which means that it can be accessed without creating an object of the class, unlike public, which can only be accessed by objects


Static methods and properties cannot access non-static fields and events in their containing type, and they cannot access an instance variable of any object unless it's explicitly passed in a method parameter.


Although a field cannot be declared as static const, a [const](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/const) field is essentially static in its behavior. It belongs to the type, not to instances of the type. Therefore, const fields can be accessed by using the same ClassName.MemberName notation that's used for static fields. No object instance is required.


C# does not support static local variables (that is, variables that are declared in method scope).


**[https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members)**


**[https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static)**


**#If statement:**


**if (_condition_) **


**{**


**  _// block of code to be executed if the condition is True_**


**}**


**if (_condition_)**


**{**


**  _// block of code to be executed if the condition is True_**


**} **


**else **


**{**


**  _// block of code to be executed if the condition is False_**


**}**


**if (_condition1_)**


**{**


**  _// block of code to be executed if condition1 is True_**


**} **


**else if (_condition2_) **


**{**


**  _// block of code to be executed if the condition1 is false and condition2 is True_**


**} **


**else**


**{**


**  _// block of code to be executed if the condition1 is false and condition2 is False_**


**}**


***Short hand if statement:**


**_variable = (condition) ? expressionTrue : expressionFalse;_**


**# C# for loop:**


**for (_statement 1_;_ statement 2_;_ statement 3_) **


**{**


**  _// code block to be executed_**


**}**


**Statement 1 is executed (one time) before the execution of the code block. Statement 2 defines the condition for executing the code block.         Statement 3 is executed (every time) after the code block has been executed.**


eg:


for (int i = 0; i &lt; 5; i++) 


{


  Console.WriteLine(i);


}


**#while loop:**


**[https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while)**


**#Switch:**


**[https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/switch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/switch)**


**# C# break/continue:**


break statement can also be used to jump out of a loop.


continue skips the one of the index in loop 


**# override : [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/override](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/override)**


**# virtual : [https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual)**


**# abstract:**


[https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract)


**#interface:**


**[https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/interfaces/](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/interfaces/)**


**#inheritance:**

it is possible to **<span style="text-decoration:underline;">inherit fields and methods</span>** from one class to another. We group the "inheritance concept" into two categories:



*   Derived Class (child) - the class that inherits from another class
*   Base Class (parent) - the class being inherited from

To inherit from a class, use the : symbol.


**[https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/inheritance#running-the-examples](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/inheritance#running-the-examples)**


**[https://www.w3schools.com/cs/cs_inheritance.asp](https://www.w3schools.com/cs/cs_inheritance.asp)**


**#List&lt;T>: **Represents a strongly typed list of objects that can be accessed by index. Provides methods to search, sort, and manipulate lists.


**[https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netframework-4.8](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netframework-4.8)**


**#Generic:**


**[https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/)**


**#Generic Function/Method:**


A generic method is a method that is declared with type parameters


**[https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-methods](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-methods)**


**#left shift and right shift &lt;</>>:**


**[https://www.cnblogs.com/kakimsun/archive/2010/04/27/1722403.html](https://www.cnblogs.com/kakimsun/archive/2010/04/27/1722403.html)**


**# C# keyworld reference:**


**[https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/) **

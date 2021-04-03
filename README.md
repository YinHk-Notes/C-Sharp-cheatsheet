<p align="center"><img src="https://github.com/YinHk-Notes/Csharp/blob/main/csharp-logo.png" height="200px"></p>

# Csharp
This is code, notes, and snippets about C#
-- --

<p>

<strong><span style="text-decoration:underline;">C# Programming</span></strong>
</p>
<p>

<strong>#Learning C#</strong> :
</p>
<ul>

<li><a href="https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/">https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/</a>

<li><a href="https://www.w3schools.com/cs/">https://www.w3schools.com/cs/</a>
<p>

<strong>#naming convention:</strong>
</p>
<p>

<strong> Variable naming 要 camel case</strong>
</p>
<p>

<strong> Method name 大階開頭</strong>
</p>
<p>

<strong> Access modifier 細階</strong>
</p>
<p>

<strong> void 細階</strong>
</p>
<p>

<strong> type 細階</strong>
</p>
<p>

<strong> class name 大階</strong>
</p>
<p>

<strong>#C# cheatsheet: <a href="https://github.com/hcmue/CSharp-Cheatsheet">https://github.com/hcmue/CSharp-Cheatsheet</a></strong>
</p>
<p>

<strong>#.NET Framework API 參考:</strong>
</p>
<p>

<strong><a href="https://docs.microsoft.com/zh-tw/dotnet/api/?view=netframework-4.8">https://docs.microsoft.com/zh-tw/dotnet/api/?view=netframework-4.8</a></strong>
</p>
<p>

<strong># using System:      <a href="https://docs.microsoft.com/zh-tw/dotnet/api/system?view=netframework-4.8">https://docs.microsoft.com/zh-tw/dotnet/api/system?view=netframework-4.8</a></strong>
</p>
<p>

<strong> *System Namespace:  </strong>The <a href="https://docs.microsoft.com/en-us/dotnet/api/system?view=netframework-4.8">System</a> namespace contains fundamental classes and base classes that define commonly-used value and reference data types, events and event handlers, interfaces, attributes, and processing exceptions .using System means that we can use classes from the System namespace.
</p>
<p>

<strong>#using System.Collection:  </strong>The namespace contains interfaces and classes that define various collections of objects, such as lists, queues, bit arrays, hash tables and dictionaries.
</p>
<p>

<strong><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections?view=netframework-4.8">https://docs.microsoft.com/en-us/dotnet/api/system.collections?view=netframework-4.8</a></strong>
</p>
<p>

<strong>#using System.Collections.Generic:    </strong> The namespace contains interfaces and classes that define generic collections, which allow users to create strongly typed collections that provide better type safety and performance than non-generic strongly typed collections.
</p>
<p>

<strong><a href="https://docs.microsoft.com/zh-tw/dotnet/api/system.collections.generic?view=netframework-4.8">https://docs.microsoft.com/zh-tw/dotnet/api/system.collections.generic?view=netframework-4.8</a></strong>
</p>
<p>

<strong>#General Structure of a C#: </strong> 
</p>
<p>

 C# programs can consist of one or more files. Each file can contain zero or more namespaces. A namespace can contain types such as classes, structs, interfaces, enumerations, and delegates.
</p>
<p>

// A skeleton of a C# program 
</p>
<p>

using System;
</p>
<p>

namespace YourNamespace
</p>
<p>

{
</p>
<p>

    class YourClass
</p>
<p>

    {
</p>
<p>

    }
</p>
<p>

    struct YourStruct
</p>
<p>

    {
</p>
<p>

    }
</p>
<p>

    interface IYourInterface 
</p>
<p>

    {
</p>
<p>

    }
</p>
<p>

    delegate int YourDelegate();
</p>
<p>

    enum YourEnum 
</p>
<p>

    {
</p>
<p>

    }
</p>
<p>

    namespace YourNestedNamespace
</p>
<p>

    {
</p>
<p>

        struct YourStruct 
</p>
<p>

        {
</p>
<p>

        }
</p>
<p>

    }
</p>
<p>

    class YourMainClass
</p>
<p>

    {
</p>
<p>

        static void Main(string[] args) 
</p>
<p>

        {
</p>
<p>

            //Your program starts here...
</p>
<p>

        }
</p>
<p>

    }
</p>
<p>

}
</p>
<p>

<strong>#</strong>A C# console application must contain a <strong>Main method</strong>, in which control starts and ends. The Main method is where you create objects and execute other methods.The <strong>Main method</strong> is a <strong><a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static">static</a></strong> method that resides inside a class or a struct.The<strong> Main method</strong> is where you create objects and execute other methods. The <strong>Main method</strong> is the entry point of a C# application. When the application is started, the <strong>Main method</strong> is the first method that is invoked.
</p>
<ul>

<li>The Main method is the entry point of an executable program; it is where the program control starts and ends.

<li>Main is declared inside a class or struct. Main must be <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static">static</a> and it need not be <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/public">public</a>. (In the earlier example, it receives the default access of <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/private">private</a>.) The enclosing class or struct is not required to be static.

<li>Main can either have a void, int, or, starting with C# 7.1, Task, or Task&lt;int>return type.

<table>
  <tr>
   <td>
using
</li>
</ul>
</li>
</ul>
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


<p>

<strong>#Comments</strong>
</p>
<p>

<strong>// A Hello World! program    </strong>or<strong> /* A "Hello World!" program in*/</strong>
</p>
<p>

<strong>#Types:</strong>
</p>
<p>

<strong>Custom Types</strong>
</p>
<p>

You use the <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/struct">struct</a>, <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class">class</a>, <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface">interface</a>, and <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/enum">enum</a> constructs to create your own custom types
</p>
<p>

<strong>1. Value Types/Data Tyoes</strong>
</p>
<p>

<strong> eg:</strong>
</p>
<p>

<strong>byte num = 0xA;</strong>
</p>
<p>

<strong>int i = 5;</strong>
</p>
<p>

<strong>char c = 'Z';</strong>
</p>
<p>

structs are also value types
</p>
<p>

<strong>2. Reference Types</strong>
</p>
<p>

A type that is defined as a <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class">class</a>, <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/delegate">delegate</a>, array, or <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface">interface</a> is a <em>reference type</em>
</p>
<p>

<strong><a href="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/">https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/</a></strong>
</p>
<p>

<strong><a href="https://www.w3schools.com/cs/cs_data_types.asp">https://www.w3schools.com/cs/cs_data_types.asp</a></strong>
</p>
<p>

<strong>#C# Type Casting</strong>
</p>
<p>
Type casting is when you assign a value of one data type to another type.In C#, there are two types of casting:
</p>
<ul>

<li>Implicit Casting (automatically) - converting a smaller type to a larger type size<br>char -> int -> long -> float -> double

<li>Explicit Casting (manually) - converting a larger type to a smaller size type.Explicit casting must be done manually by placing the type in parentheses in front of the value<br>double -> float -> long -> int -> char
<p>

<strong><a href="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions">https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions</a></strong>
</p>
<p>

<strong><a href="https://www.w3schools.com/cs/cs_type_casting.asp">https://www.w3schools.com/cs/cs_type_casting.asp</a></strong>
</p>
<p>

<strong>#Declare variables in C#:</strong>
</p>
<p>

<strong>syntax: </strong>
</p>
<p>

<strong>&lt;data_type> &lt;variable_names>; </strong>
</p>
<p>

<strong>eg:</strong>
</p>
<p>

<strong>char ch = 'g';</strong>
</p>
<p>

<strong>int xy = 6, roll = 42;</strong>
</p>
<p>

<strong>byte b = 22;</strong>
</p>
<p>

<strong>double pi = 3.14159;</strong>
</p>
<p>

<strong>float salary = 20000.0f;</strong>
</p>
<p>

(When declaring variable must specify its type)
</p>
<p>

<strong>or  syntax:</strong>
</p>
<p>

<strong>&lt;reference_type> &lt; variable_name>;</strong>
</p>
<p>

<strong>#Main() return values:</strong>
</p>
<p>

The Main method can return <strong>void</strong> or <strong>int.   </strong>eg<strong>:</strong>
</p>
<p>

<strong>static void Main()</strong>
</p>
<p>

<strong>{</strong>
</p>
<p>

<strong>    //...</strong>
</p>
<p>

<strong>}</strong>
</p>
<p>

<strong>or</strong>
</p>
<p>

<strong>static int Main()</strong>
</p>
<p>

<strong>{</strong>
</p>
<p>

<strong>    //...</strong>
</p>
<p>

<strong>    return 0;</strong>
</p>
<p>

<strong>}</strong>
</p>
<p>

<strong>#Console.WriteLine():</strong>
</p>
<p>

Console.WriteLine() is used to output (print) values
</p>
<p>

<strong><a href="https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline?view=netframework-4.8">https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline?view=netframework-4.8</a></strong>
</p>
<p>

<strong>#Console.Readline():</strong>
</p>
<p>

<strong>to get user input. </strong>
</p>
<p>

<strong><a href="https://www.w3schools.com/cs/cs_user_input.asp">https://www.w3schools.com/cs/cs_user_input.asp</a></strong>
</p>
<p>

<strong>#Console property and method:</strong>
</p>
<p>

<strong><a href="https://docs.microsoft.com/en-us/dotnet/api/system.console?view=netframework-4.8">https://docs.microsoft.com/en-us/dotnet/api/system.console?view=netframework-4.8</a></strong>
</p>
<p>

<strong>#C# operator:</strong>
</p>
<p>

<strong><a href="https://docs.microsoft.com/zh-tw/dotnet/csharp/language-reference/operators/">https://docs.microsoft.com/zh-tw/dotnet/csharp/language-reference/operators/</a></strong>
</p>
<p>

<strong><a href="https://www.w3schools.com/cs/cs_operators.asp">https://www.w3schools.com/cs/cs_operators.asp</a></strong>
</p>
<p>

<strong>x++ increment</strong>
</p>
<p>

<strong>x- - decrement</strong>
</p>
<p>

<strong>x%y modulus</strong>
</p>
<p>

<strong>&&  and</strong>
</p>
<p>

<strong>||  or</strong>
</p>
<p>

<strong>!  not</strong>
</p>
<p>

<strong># C#Math:</strong>
</p>
<p>

<strong><a href="https://www.w3schools.com/cs/cs_math.asp">https://www.w3schools.com/cs/cs_math.asp</a></strong>
</p>
<p>

<strong><a href="https://docs.microsoft.com/zh-tw/dotnet/api/system.math?view=netframework-4.8">https://docs.microsoft.com/zh-tw/dotnet/api/system.math?view=netframework-4.8</a></strong>
</p>
<p>

<strong># Method: </strong>
</p>
<p>

Methods are declared in a <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class">class</a> or <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/struct">struct</a> by specifying the access level such as public or private. A method is a group of statements that together perform a task. Every C# program has at least one class with a method named Main.To use a method, you need to define the method and Call the method. 
</p>
<p>

The syntax for defining a method in C#:
</p>
<p>

&lt;Access Specifier> &lt;Return Type> &lt;Method Name>(Parameter List) {
</p>
<p>

   Method Body
</p>
<p>

}
</p>
</li>
</ul>
<p>
Methods and Functions are the same in C#.
</p>
<p>
However, Methods are used in C# and are functions that operate through a designated class. A method is a group of statements that together perform a task. Every C# program has at least one class with a method named Main.
</p>
<p>

<strong># Void method: </strong> void isn't allowed in the parameter list of a method. A method that takes no parameters and returns no value, the return type is “void”. 
</p>
<p>

<strong>void SampleMethod()</strong>
</p>
<p>

<strong>{</strong>
</p>
<p>

<strong>    // Body of the method.</strong>
</p>
<p>

<strong>}</strong>
</p>
<p>

<strong>#Access modifiers:</strong>
</p>
<p>

Access modifiers are keywords used to specify the declared accessibility of a member or a type. This section introduces the four access modifiers:
</p>
<ul>

<li>public

<li>protected

<li>internal

<li>private

<table>
  <tr>
   <td>
<strong>Modifier</strong>
</li>
</ul>
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


<p>

<a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers">https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers</a>
</p>
<p>

<strong><a href="https://www.w3schools.com/cs/cs_access_modifiers.asp">https://www.w3schools.com/cs/cs_access_modifiers.asp</a></strong>
</p>
<p>

<strong>#Members </strong>
</p>
<h1><span style="text-decoration:underline;">Classes</span> and <span style="text-decoration:underline;">structs</span> have <span style="text-decoration:underline;">members</span> that represent their data and behavior. </h1>


<p>

eg Fields, properties, constants, methods , constructors….
</p>
<p>

<strong>#Fields</strong>
</p>
<p>

Fields are variables declared at class scope. A field may be a built-in numeric type or an instance of another class.A <em>field</em> is a variable of any type that is declared directly in a <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class">class</a> or <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/struct">struct</a>. Fields are <em>members</em> of their containing type.A class or struct may have instance fields or static fields or both. Instance fields are specific to an instance of a type. If you have a class T, with an instance field F, you can create two objects of type T, and modify the value of F in each object without affecting the value in the other object. By contrast, a static field belongs to the class itself, and is shared among all instances of that class. Changes made from instance A will be visibly immediately to instances B and C if they access the field. eg:
</p>
<p>

// private field
</p>
<p>

       private DateTime date;
</p>
<p>

       // public field (Generally not recommended.)
</p>
<p>

       public string day;
</p>
<p>

<strong>#Constant</strong>
</p>
<p>

Constants are declared with the <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/const">const</a> modifier.Constants are immutable values which are known at compile time and do not change for the life of the program. Constants are declared with the <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/const">const</a> modifier. Only the C# built-in types (excluding <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object">System.Object</a>) may be declared as const. eg
</p>
<p>

const int months = 12;
</p>
<p>

const int weeks = 52;
</p>
<p>

const int days = 365;
</p>
<p>

<strong>#Class and object(instance)</strong>
</p>
<p>

The class keyword is preceded by the access level. Because<strong> <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/public">public</a> </strong>is used in this case, <strong>anyone can create instances of this class</strong>. The name of the class follows the class keyword. The remainder of the definition is the class body, where the behavior and data are defined. Fields, properties, methods, and events on a class are collectively referred to as <em>class members</em>.  A class is a reference type. A program may create many objects of the same class. Objects are also called instances.
</p>
<p>

//Declaring an object of type MyClass.
</p>
<p>

MyClass mc = new MyClass();
</p>
<p>

//Declaring another object of the same type, assigning it the value of the first object.
</p>
<p>

MyClass mc2 = mc;
</p>
<p>

<strong>#Declaring Classes</strong>:
</p>
<p>

public class Customer
</p>
<p>

{
</p>
<p>

   // Fields, properties, methods and events go here...
</p>
<p>

}
</p>
<p>

<strong>#Creating objects(instantiate)</strong>: 
</p>
<p>

<strong>A<span style="text-decoration:underline;"> class defines a type of object, but it is not an object itself.</span> An object is a concrete entity based on a class.Objects can be created by using the <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new">new</a> keyword followed by the name of the class</strong>.
</p>
<p>

Customer object1 = new Customer();
</p>
<p>

<strong>#creating object references:   eg </strong>  
</p>
<p>

Customer object3 = new Customer();
</p>
<p>

Customer object4 = object3;
</p>
<p>

<strong>#Class inheritance:  eg</strong>
</p>
<p>

public class Manager : Employee
</p>
<p>

{
</p>
<p>

    // Employee fields, properties, methods and events are inherited
</p>
<p>

    // New Manager fields, properties, methods and events go here...
</p>
<p>

}
</p>
<p>

<strong>#Struct:</strong>
</p>
<p>

Structs share most of the same syntax as classes,but more limited than classes in the following ways:
</p>
<ul>

<li>Within a struct declaration, fields cannot be <span style="text-decoration:underline;">initialized </span>unless they are declared as const or static.

<li>A struct cannot declare a parameterless constructor (a constructor without parameters) or a finalizer.

<li>Structs are copied on assignment. When a struct is assigned to a new variable, all the data is copied, and any modification to the new copy does not change the data for the original copy. This is important to remember when working with collections of value types such as Dictionary&lt;string, myStruct>.

<li>Structs are value types, unlike classes, which are reference types.

<li>Unlike classes, structs can be instantiated(creating object) without using a <span style="text-decoration:underline;">new</span> operator.

<li>Structs can declare constructors that have parameters.

<li>Structs do not support inheritance, but they can implement interfaces.

<li>A struct cannot be null, and a struct variable cannot be assigned null unless the variable is declared as a nullable type.
<p>

<strong>#Declare struct:</strong>
</p>
<p>

<strong>public struct PostalAddress</strong>
</p>
<p>

<strong>{</strong>
</p>
<p>

<strong>    // Fields, properties, methods and events go here...</strong>
</p>
<p>

<strong>}</strong>
</p>
<p>

<strong>#Properties:</strong>
</p>
<p>

Properties enable a class to expose a public way of getting and setting values, while hiding implementation or verification code. Properties combine aspects of both <span style="text-decoration:underline;">fields </span>and <span style="text-decoration:underline;">methods</span>.
</p>
<p>

(類似field, 但可public 得到和設定其value)
</p>
<ul>

<li>Properties enable a class to expose a public way of getting and setting values, while hiding implementation or verification code.

<li>A <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/get">get</a> property accessor is used to return the property value, and a <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/set">set</a>property accessor is used to assign a new value. These accessors can have different access levels. For more information, see <a href="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/restricting-accessor-accessibility">Restricting Accessor Accessibility</a>.

<li>The <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/value">value</a> keyword is used to define the value being assigned by the set accessor.
<p>

<strong>syntax: </strong>
</p>
<p>

&lt;Access Specifier> &lt;Return Type> &lt;property Name>{
</p>
<p>

  get{ <span style="text-decoration:underline;">return</span> the field’s value  ;}
</p>
<p>

  set{  the field’s variable  = <span style="text-decoration:underline;">value</span>;}
</p>
<p>

}
</p>
<p>

Eg:
</p>
<p>

class Person
</p>
<p>

{
</p>
<p>

  private string name; // field
</p>
<p>

  public string Name   // property
</p>
<p>

  {
</p>
<p>

    get { return name; }
</p>
<p>

    set { name = value; }
</p>
<p>

  }
</p>
<p>

}
</p>
<p>

class Program
</p>
<p>

{
</p>
<p>

  static void Main(string[] args)
</p>
<p>

  {
</p>
<p>

    Person myObj = new Person();
</p>
<p>

    myObj.Name = "Liam";
</p>
<p>

    Console.WriteLine(myObj.Name);
</p>
<p>

  }
</p>
<p>

}
</p>
<p>

OR
</p>
<p>

class Person
</p>
<p>

{
</p>
<p>

  public string Name  // property
</p>
<p>

  { get; set; }
</p>
<p>

}
</p>
<p>

class Program
</p>
<p>

{
</p>
<p>

  static void Main(string[] args)
</p>
<p>

  {
</p>
<p>

    Person myObj = new Person();
</p>
<p>

    myObj.Name = "Liam";
</p>
<p>

    Console.WriteLine(myObj.Name);
</p>
<p>

  }
</p>
<p>

}
</p>
<p>

(Propety’s name is<span style="text-decoration:underline;"> same</span> to the field’s name, but need to capitalize first word.)
</p>
<p>

<strong>The get accesor: </strong>The body of the get accessor resembles that of a method. It must <strong>return a value of the property type</strong>.
</p>
</li>
</ul>
</li>
</ul>
<p>
<strong>The set accesor : </strong>a method whose return type is <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/void">void</a>. It uses an <strong>implicit parameter called value</strong>, whose type is the type of the property.<strong> </strong>
</p>
<p>
<strong><a href="https://www.w3schools.com/cs/cs_properties.asp">https://www.w3schools.com/cs/cs_properties.asp</a></strong>
</p>
<p>
<strong>#Constructor:</strong>
</p>
<p>

Constructors are<span style="text-decoration:underline;"> methods</span> that are called when the object is first created. They are often used to <strong><span style="text-decoration:underline;">initialize</span> the data of an object</strong>. <strong>Constructor can have <span style="text-decoration:underline;">parameters</span></strong>. 
</p>
<p>

A constructor is a special method that is used to initialize objects. The advantage of a constructor, is that it is called when an object of a class is created. It can be used to set initial values for fields. Constructors enable the programmer to set default values, limit instantiation, and write code that is flexible and easy to read.A constructor is a method whose name is the same as the name of its class. Its method signature includes only the method name and its parameter list; it does not include a return type. eg:
</p>
<p>

private string last;
</p>
<p>

   private string first;
</p>
<p>

   
</p>
<p>

   public Person(string lastName, string firstName)
</p>
<p>

   {
</p>
<p>

      last = lastName;
</p>
<p>

      first = firstName;
</p>
<p>

   }
</p>
<p>

A static constructor is used to initialize any <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static">static</a> data, or to perform a particular action that needs to be performed once only.
</p>
<p>

<strong><a href="https://www.w3schools.com/cs/cs_constructors.asp">https://www.w3schools.com/cs/cs_constructors.asp</a></strong>
</p>
<p>

<strong>#Array:</strong>
</p>
<p>

Declare an array by specifying the type of its elements:
</p>
<p>

<strong><span style="text-decoration:underline;">type[] arrayName</span>;</strong>
</p>
<p>

<strong>        // Declare a single-dimensional array. </strong>
</p>
<p>

<strong>        int[] array1 = new int[5];</strong>
</p>
<p>

<strong>        // Declare and set array element values.</strong>
</p>
<p>

<strong>        int[] array2 = new int[] { 1, 3, 5, 7, 9 };</strong>
</p>
<p>

<strong>        // Alternative syntax.</strong>
</p>
<p>

<strong>        int[] array3 = { 1, 2, 3, 4, 5, 6 };</strong>
</p>
<p>

<strong>        // Declare a two dimensional array.</strong>
</p>
<p>

<strong>        int[,] multiDimensionalArray1 = new int[2, 3];</strong>
</p>
<p>

<strong>        // Declare and set array element values.</strong>
</p>
<p>

<strong>        int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };</strong>
</p>
<p>

<strong>        // Declare a jagged array.</strong>
</p>
<p>

<strong>        int[][] jaggedArray = new int[6][];</strong>
</p>
<p>

<strong>        // Set the values of the first array in the jagged array structure.</strong>
</p>
<p>

<strong>        jaggedArray[0] = new int[4] { 1, 2, 3, 4 };</strong>
</p>
<p>

arrays are actually objects, to get length of array: eg
</p>
<p>

int[] numbers = { 1, 2, 3, 4, 5 };
</p>
<p>

int lengthOfNumbers = numbers.Length;
</p>
<p>

<strong>*a single-dimensional array :  </strong>eg int[] array = new int[5];
</p>
<p>

<strong>dataType[] arrayRefVar = new dataType[arraySize];</strong>
</p>
<p>

Array Initialization: eg  int[] array1 = new int[] { 1, 3, 5, 7, 9 };
</p>
<p>

Multidimensional Array: eg  int[, ,] array1 = new int[4, 2, 3];
</p>
<p>

Array Initialization: eg int[, ,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },{ { 7, 8, 9 }, { 10, 11, 12 } } };
</p>
<p>

Jagged Array:  
</p>
<p>

A jagged array is an array whose elements are arrays. The elements of a jagged array can be of different dimensions and sizes. eg:
</p>
<p>

int[][] jaggedArray = new int[3][];
</p>
<p>

jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
</p>
<p>

jaggedArray[1] = new int[] { 0, 2, 4, 6 };
</p>
<p>

jaggedArray[2] = new int[] { 11, 22 };
</p>
<p>

using foreach in array:
</p>
<p>

foreach statement processes elements in increasing index order, starting with index 0 and ending with index Length - 1
</p>
<p>

int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
</p>
<p>

foreach (int i in numbers)
</p>
<p>

{
</p>
<p>

    System.Console.Write("{0} ", i);
</p>
<p>

}
</p>
<p>

// Output: 4 5 6 1 2 3 -2 -1 0
</p>
<p>

Passing single-dimensional arrays as arguments:
</p>
<p>

void PrintArray(int[] arr)
</p>
<p>

{
</p>
<p>

    // Method code.
</p>
<p>

}
</p>
<p>

PrintArray(new int[] { 1, 3, 5, 7, 9 });
</p>
<p>

Passing multidimensional arrays as arguments:
</p>
<p>

void Print2DArray(int[,] arr)
</p>
<p>

{
</p>
<p>

    // Method code.
</p>
<p>

}
</p>
<p>

Print2DArray(new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } });
</p>
<p>

# <strong>enum</strong>
</p>
<p>

The enum keyword is used to declare an enumeration, a distinct type that consists of a set of named constants called the enumerator list. Eg:
</p>
<p>

enum Day {Sat, Sun, Mon, Tue, Wed, Thu, Fri};
</p>
<p>

<strong>#Namespace</strong>
</p>
<p>

The <strong>namespace</strong> keyword is used to declare a scope. The ability to create scopes within your project helps organize code and lets you create globally-unique types.
</p>
<p>

namespace N1     // N1
</p>
<p>

{
</p>
<p>

    class C1      // N1.C1
</p>
<p>

    {
</p>
<p>

        class C2   // N1.C1.C2
</p>
<p>

        {
</p>
<p>

        }
</p>
<p>

    }
</p>
<p>

    namespace N2  // N1.N2
</p>
<p>

    {
</p>
<p>

        class C2   // N1.N2.C2
</p>
<p>

        {
</p>
<p>

        }
</p>
<p>

    }
</p>
<p>

}
</p>
<p>

<strong># static (<span style="text-decoration:underline;">Static Classes</span> and <span style="text-decoration:underline;">Static Class Members</span>):(Static means <span style="text-decoration:underline;">not unique</span>)</strong>
</p>
<p>

Use the static modifier to declare a static member, which <span style="text-decoration:underline;">belongs to the type itself rather than to a specific object</span>. Static cannot be<span style="text-decoration:underline;"> instantiated</span>. The static modifier can be used with classes, fields, methods, properties, operators, events, and constructors. (<strong>A non-static class can contain static methods, fields, properties, or events. Static class should have static member only, a static class can only contain static data members, static methods, and a static constructor.It is not allowed to create objects of the static class. Static class cannot be instantiated[create objects of the static class], and cannot inherit a static class from another class.</strong> )
</p>
<p>

It is more typical to declare a non-static class with some static members, than to declare an entire class as static. Two<span style="text-decoration:underline;"> common uses of <strong>static fields</strong></span> are to <strong>keep a count of the number of objects </strong>that have been instantiated, or to<strong> store a value that must be shared among all instances</strong>.
</p>
<p>

Static methods can be overloaded but not overridden, because they belong to the class, and not to any instance of the class.Static method are shared by all objects of the class,one copy for all objects. A static method, which means that it can be accessed without creating an object of the class, unlike public, which can only be accessed by objects
</p>
<p>

Static methods and properties cannot access non-static fields and events in their containing type, and they cannot access an instance variable of any object unless it's explicitly passed in a method parameter.
</p>
<p>

Although a field cannot be declared as static const, a <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/const">const</a> field is essentially static in its behavior. It belongs to the type, not to instances of the type. Therefore, const fields can be accessed by using the same ClassName.MemberName notation that's used for static fields. No object instance is required.
</p>
<p>

C# does not support static local variables (that is, variables that are declared in method scope).
</p>
<p>

<strong><a href="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members">https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members</a></strong>
</p>
<p>

<strong><a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static">https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static</a></strong>
</p>
<p>

<strong>#If statement:</strong>
</p>
<p>

<strong>if (<em>condition</em>) </strong>
</p>
<p>

<strong>{</strong>
</p>
<p>

<strong>  <em>// block of code to be executed if the condition is True</em></strong>
</p>
<p>

<strong>}</strong>
</p>
<p>

<strong>if (<em>condition</em>)</strong>
</p>
<p>

<strong>{</strong>
</p>
<p>

<strong>  <em>// block of code to be executed if the condition is True</em></strong>
</p>
<p>

<strong>} </strong>
</p>
<p>

<strong>else </strong>
</p>
<p>

<strong>{</strong>
</p>
<p>

<strong>  <em>// block of code to be executed if the condition is False</em></strong>
</p>
<p>

<strong>}</strong>
</p>
<p>

<strong>if (<em>condition1</em>)</strong>
</p>
<p>

<strong>{</strong>
</p>
<p>

<strong>  <em>// block of code to be executed if condition1 is True</em></strong>
</p>
<p>

<strong>} </strong>
</p>
<p>

<strong>else if (<em>condition2</em>) </strong>
</p>
<p>

<strong>{</strong>
</p>
<p>

<strong>  <em>// block of code to be executed if the condition1 is false and condition2 is True</em></strong>
</p>
<p>

<strong>} </strong>
</p>
<p>

<strong>else</strong>
</p>
<p>

<strong>{</strong>
</p>
<p>

<strong>  <em>// block of code to be executed if the condition1 is false and condition2 is False</em></strong>
</p>
<p>

<strong>}</strong>
</p>
<p>

<strong>*Short hand if statement:</strong>
</p>
<p>

<strong><em>variable = (condition) ? expressionTrue : expressionFalse;</em></strong>
</p>
<p>

<strong># C# for loop:</strong>
</p>
<p>

<strong>for (<em>statement 1</em>;<em> statement 2</em>;<em> statement 3</em>) </strong>
</p>
<p>

<strong>{</strong>
</p>
<p>

<strong>  <em>// code block to be executed</em></strong>
</p>
<p>

<strong>}</strong>
</p>
<p>

<strong>Statement 1 is executed (one time) before the execution of the code block. Statement 2 defines the condition for executing the code block.         Statement 3 is executed (every time) after the code block has been executed.</strong>
</p>
<p>

eg:
</p>
<p>

for (int i = 0; i &lt; 5; i++) 
</p>
<p>

{
</p>
<p>

  Console.WriteLine(i);
</p>
<p>

}
</p>
<p>

<strong>#while loop:</strong>
</p>
<p>

<strong><a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while">https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while</a></strong>
</p>
<p>

<strong>#Switch:</strong>
</p>
<p>

<strong><a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/switch">https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/switch</a></strong>
</p>
<p>

<strong># C# break/continue:</strong>
</p>
<p>

break statement can also be used to jump out of a loop.
</p>
<p>

continue skips the one of the index in loop 
</p>
<p>

<strong># override : <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/override">https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/override</a></strong>
</p>
<p>

<strong># virtual : <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual">https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual</a></strong>
</p>
<p>

<strong># abstract:</strong>
</p>
<p>

<a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract">https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract</a>
</p>
<p>

<strong>#interface:</strong>
</p>
<p>

<strong><a href="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/interfaces/">https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/interfaces/</a></strong>
</p>
<p>

<strong>#inheritance:</strong>
</p>
<p>
it is possible to <strong><span style="text-decoration:underline;">inherit fields and methods</span></strong> from one class to another. We group the "inheritance concept" into two categories:
</p>
<ul>

<li>Derived Class (child) - the class that inherits from another class

<li>Base Class (parent) - the class being inherited from
</li>
</ul>
<p>
To inherit from a class, use the : symbol.
</p>
<p>

<strong><a href="https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/inheritance#running-the-examples">https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/inheritance#running-the-examples</a></strong>
</p>
<p>

<strong><a href="https://www.w3schools.com/cs/cs_inheritance.asp">https://www.w3schools.com/cs/cs_inheritance.asp</a></strong>
</p>
<p>

<strong>#List&lt;T>: </strong>Represents a strongly typed list of objects that can be accessed by index. Provides methods to search, sort, and manipulate lists.
</p>
<p>

<strong><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netframework-4.8">https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netframework-4.8</a></strong>
</p>
<p>

<strong>#Generic:</strong>
</p>
<p>

<strong><a href="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/">https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/</a></strong>
</p>
<p>

<strong>#Generic Function/Method:</strong>
</p>
<p>

A generic method is a method that is declared with type parameters
</p>
<p>

<strong><a href="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-methods">https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-methods</a></strong>
</p>
<p>

<strong>#left shift and right shift &lt;</>>:</strong>
</p>
<p>

<strong><a href="https://www.cnblogs.com/kakimsun/archive/2010/04/27/1722403.html">https://www.cnblogs.com/kakimsun/archive/2010/04/27/1722403.html</a></strong>
</p>
<p>

<strong># C# keyworld reference:</strong>
</p>
<p>

<strong><a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/">https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/</a> </strong>
</p>

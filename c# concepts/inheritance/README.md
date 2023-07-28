## inheritance
It is possible to **inherit fields and methods** from one class to another. We group the 

"inheritance concept" into two categories:

- **Derived Class** (child) -  the class that inherits from another class
- **Base Class** (parent)   -  the class being inherited from

To inherit from a class, use the " **:** " symbol.

```
📌 Derived Class : Base Class

```

### Inheritance in interfaces
C# allows the user to inherit one interface into another interface.


> When a class implements the inherited interface then it **must provide the implementation of all the members** that are defined within the **interface inheritance chain**.

> If a class implements an interface, then it is necessary to implement all the method that defined by that interface including the base interface methods. Otherwise, the compiler throws an error.

> If both derived interface and base interface declares the same member then the base interface member name is hidden by the derived interface member name.

Syntax:
```cs
// declaring an interface
access_modifier interface interface_name 
{
   // Your code
}

// inheriting the interface
access_modifier interface interface_name : interface_name
{
    // Your code
}
```
Eg:
```cs
// C# program to illustrate the concept
// of inheritance in interface
using System;

// declaring an interface
public interface A {
	
	// method of interface
	void mymethod1();
	void mymethod2();
}

// The methods of interface A
// is inherited into interface B
public interface B : A {
	
	// method of interface B
	void mymethod3();
}


// Below class is inheriting
// only interface B
// This class must
// implement both interfaces
class Geeks : B
{
	
	// implementing the method
	// of interface A
	public void mymethod1()
	{
		Console.WriteLine("Implement method 1");
	}
	
	// Implement the method
	// of interface A
	public void mymethod2()
	{
		Console.WriteLine("Implement method 2");
	}
	
	// Implement the method
	// of interface B
	public void mymethod3()
	{
		Console.WriteLine("Implement method 3");
	}
}

// Driver Class
class GFG {

	// Main method
	static void Main(String []args)
	{
		
		// creating the object
		// class of Geeks
		Geeks obj = new Geeks();
		
		// calling the method
		// using object 'obj'
		obj.mymethod1();
		obj.mymethod2();
		obj.mymethod3();
	}
}

```
If you don't want other classes to inherit from a class, use the **`sealed`** keyword:

```cs
sealed class Vehicle 
{
  ...
}

class Car : Vehicle 
{
  ...
}


```


### ref

https://www.geeksforgeeks.org/c-sharp-inheritance-in-interfaces/

https://www.w3schools.com/cs/cs_inheritance.php






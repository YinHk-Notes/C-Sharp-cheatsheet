## Encapsulation

**Encapsulation** is defined as the **wrapping up of data** under a single unit. It is the mechanism that binds together code and the data it manipulates. In a different way, encapsulation is a protective shield that prevents the data from being accessed by the code outside this shield.

Property in C# is a class member that exposes the class' `private` fields. 

-   Technically in encapsulation, the variables or data of a class are hidden from any other class and can be accessed only through any member function of its own class in which they are declared.
-   As in encapsulation, the data in a class is hidden from other classes, so it is also known as **data-hiding**.
-   Encapsulation makes sure that **"sensitive" data** is hidden from users.
-   **Encapsulation can be achieved by**:
    - declare **fields/variables** as **`private`**.
    - provide **`public`**, **`get`** and **`set`** methods, through **properties**, to access and update the value of a **`private`** field

Eg:
```cs
class Person
{
  private string name; // field

  public string Name   // property
  {
    get { return name; }   // get method
    set { name = value; }  // set method
  }
}
```


```cs

// C# program to illustrate encapsulation
using System;

public class DemoEncap {

	// private variables declared
	// these can only be accessed by
	// public methods of class
	private String studentName;
	private int studentAge;

	// using accessors to get and
	// set the value of studentName
	public String Name
	{

		get { return studentName; }

		set { studentName = value; }
	}

	// using accessors to get and
	// set the value of studentAge
	public int Age
	{

		get { return studentAge; }

		set { studentAge = value; }
	}
}

// Driver Class
class GFG {

	// Main Method
	static public void Main()
	{

		// creating object
		DemoEncap obj = new DemoEncap();

		// calls set accessor of the property Name,
		// and pass "Ankita" as value of the
		// standard field 'value'
		obj.Name = "
		Ankita& quot;
		;

		// calls set accessor of the property Age,
		// and pass "21" as value of the
		// standard field 'value'
		obj.Age = 21;

		// Displaying values of the variables
		Console.WriteLine(" Name : " + obj.Name);
		Console.WriteLine(" Age : " + obj.Age);
	}
}


```

### Why use encapsulation?

Encapsulation is an important concept in object-oriented programming (OOP) because it allows you to hide the internal details (implementation) of an object from other objects and the outside world.

- **Abstraction**: Encapsulation allows you to create a level of abstraction between the internal workings of an object and its external behavior. This makes it easier to understand the code and reduces the risk of errors caused by changing the internal data directly.
- **Security**: Encapsulation allows you to control access to the internal data of an object, which can improve the security of the system by **preventing unauthorized access** or **modification of sensitive data**.
- **Flexibility**: Encapsulation allows you to change the internal implementation of an object without affecting the rest of the system. This makes your code more flexible and adaptable to changing requirements.
- **Reusability**: Encapsulation also improves the re-usability and easy to change with new requirements.
- **Testing code is easy**: Encapsulated code is easy to test for unit testing.
- **Data Hiding**: The user will have no idea about the inner implementation of the class. It will not be visible to the user that how the class is stored values in the variables. He only knows that we are passing the values to accessors and variables are getting initialized to that value.



### ref
https://www.geeksforgeeks.org/c-sharp-encapsulation/

https://www.c-sharpcorner.com/article/encapsulation-in-C-Sharp/


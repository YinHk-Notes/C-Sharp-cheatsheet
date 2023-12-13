## Anonymous Method
An anonymous method is a method which doesn’t contain any method name. No need to specify method name.

An Anonymous method is defined using the **`delegate`** keyword and the user can assign this method to a variable of the **`delegate`** type.

```cs
delegate(parameter_list){
    // Code..
};
```


```cs
// C# program to illustrate how to
// create an anonymous function
using System;

class GFG {

	public delegate void petanim(string pet);

	// Main method
	static public void Main()
	{

		// An anonymous method with one parameter
		petanim p = delegate(string mypet)
		{
			Console.WriteLine("My favorite pet is: {0}",
												mypet);
		};
		p("Dog");
	}
}

```


### ref
https://www.geeksforgeeks.org/anonymous-method-in-c-sharp/



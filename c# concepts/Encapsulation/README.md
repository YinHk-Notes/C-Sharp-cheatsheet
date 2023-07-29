## Encapsulation

**Encapsulation** is defined as the **wrapping up of data** under a single unit. It is the mechanism that binds together code and the data it manipulates. In a different way, encapsulation is a protective shield that prevents the data from being accessed by the code outside this shield.

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


### ref
https://www.geeksforgeeks.org/c-sharp-encapsulation/


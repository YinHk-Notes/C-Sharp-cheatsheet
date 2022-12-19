## constructor
- Constructors are methods that are called when the object is first created. They are often used to initialize the data of an object.  
- Constructor can have parameters.
- A constructor is a special method that is used to initialize objects.
- The advantage of a constructor, is that it is called when an object of a class is created. It can be used to set initial values for fields
- Constructors enable the programmer to set default values, limit instantiation, and write code that is flexible and easy to read.
- A constructor is a method whose name is the same as the name of its class.
- Cobstructor does not include a return type. 

```cs
class Car
{
  public string model;

  // Create a class constructor with a parameter
  public Car(string modelName)
  {
    model = modelName;
  }

  static void Main(string[] args)
  {
    Car Ford = new Car("Mustang");
    Console.WriteLine(Ford.model);
  }
}
```
```cs
class Car
{
  public string model;
  public string color;
  public int year;

  // Create a class constructor with multiple parameters
  public Car(string modelName, string modelColor, int modelYear)
  {
    model = modelName;
    color = modelColor;
    year = modelYear;
  }

  static void Main(string[] args)
  {
    Car Ford = new Car("Mustang", "Red", 1969);
    Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
  }
}

```
A constructor can be implemented as a single statement, you can use an expression body definition
```cs
public class Location
{
   private string locationName;
   public Location(string name) => Name = name;
}
```

### static constructor
A `static` constructor is used to initialize any static data, or to perform a particular action that needs to be performed once only.
A class or struct can also have a static constructor, which initializes `static` members of the type.

- static constructors are parameterless.
- If you don't provide a static constructor to initialize static fields, the C# compiler initializes static fields to their default value

```cs
public class Adult : Person
{
   private static int minimumAge;

   public Adult(string lastName, string firstName) : base(lastName, firstName)
   { }

   static Adult()
   {
      minimumAge = 18;
   }

   // Remaining implementation of Adult class.
}
```

You can also define a static constructor with an expression body definition
```cs
public class Child : Person
{
   private static int maximumAge;

   public Child(string lastName, string firstName) : base(lastName, firstName)
   { }

   static Child() => maximumAge = 18;

   // Remaining implementation of Child class.
}
```





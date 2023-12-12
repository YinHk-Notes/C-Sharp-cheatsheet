## constructor
- Constructors are methods that are called when the object is first created. They are often used to **initialize the data of an object**.  
- Constructor **can have parameters**.
- A constructor is a special method that is used to **initialize objects**.
- The advantage of a constructor, is that it is **called when an object of a class is created**. It can be used to **set initial values for fields**
- Constructors enable the programmer to set default values, limit instantiation, and write code that is flexible and easy to read.
- A constructor is a method whose **name is the same as the name of its class**.
- Cobstructor **does not include a return type**.
- If a class contains **no instance constructor declarations**, a **default instance constructor is automatically provided**. 

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
Classes and structs can also define multiple constructors, and neither is required to define a parameterless constructor.
```cs
public class Employee
{
    public int Salary;

    public Employee() { }

    public Employee(int annualSalary)
    {
        Salary = annualSalary;
    }

    public Employee(int weeklySalary, int numberOfWeeks)
    {
        Salary = weeklySalary * numberOfWeeks;
    }
}
```
Constructors that take parameters **must be called** through a **`new`** statement or a **`base`** statement.
A constructor can use the `base` keyword to call **the constructor of a base class**. 
```cs
public class Manager : Employee
{
    public Manager(int annualSalary) : base(annualSalary)
    {
        //Add further instructions here.
    }
}
```
If a base-class constructor isn't called explicitly by using the base keyword, the parameterless constructor, if there's one, is called implicitly. This means that the following constructor declarations are effectively the same:
```cs
public Manager(int initialData)
{
    //Add further instructions here.
}

//same as 
public Manager(int initialData) : base()
{
    //Add further instructions here.
}
```
> If a base class doesn't offer a parameterless constructor, the derived class must make an explicit call to a base constructor by using base

A constructor can invoke another constructor in the same object by using the `this` keyword. Used tocalled previous same constructor in the same class.
```cs
public Employee(int weeklySalary, int numberOfWeeks) : this(weeklySalary * numberOfWeeks)
{
    //...
}

//same as 
public Employee(int annualSalary)
{
    Salary = annualSalary;
}

public Employee(int weeklySalary, int numberOfWeeks)
{
    Salary = weeklySalary * numberOfWeeks;
}
```

If no constructor declared, default constructor is automatically provided
```cs
class Person {  
    //This class has no constructor  
    public void getPersonProfile() {  
        Console.WriteLine("Base class:getPersonProfile() have no constructor");  
    }  
}  
class Program {  
    static void Main(string[] args) {  
        //Create object of person  
        Person p = new Person();  
        p.getPersonProfile();  
    }  
}  


```

### static constructor
A `static` constructor is used to initialize any static data, or to perform a particular action that needs to be performed once only.
A class or struct can also have a static constructor, which initializes `static` members of the type.

- static constructors are parameterless.
- If you don't provide a static constructor to initialize static fields, the C# compiler initializes static fields to their default value
- A static constructor is called automatically. It initializes the class before the first instance is created or any static members declared in that class (not its base classes) are referenced.
- A class or struct can only have one static constructor.
- A static constructor doesn't take access modifiers or have parameters.
- Static constructors cannot be inherited or overloaded.
- A static constructor is used to initialize any static data, or to perform a particular action that needs to be performed only once.
- The only classes in C# which don't have any instance constructors are static classes, and they can't have constructors.



```cs
class SimpleClass
{
    // Static variable that must be initialized at run time.
    static readonly long baseline;

    // Static constructor is called at most one time, before any
    // instance constructor is invoked or member is accessed.
    static SimpleClass()
    {
        baseline = DateTime.Now.Ticks;
    }
}
```
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
   { 
      //...
   }

   static Child() => maximumAge = 18;

   // Remaining implementation of Child class.
}
```

### private constructor 
A private constructor is a special instance constructor. It is generally used in classes that contain `static` members only
If a class has one or more private constructors and no public constructors, other classes (except nested classes) cannot create instances of this class.
```cs
public class Counter
{
    private Counter() { }

    public static int currentCount;

    public static int IncrementCount()
    {
        return ++currentCount;
    }
}

class TestCounter
{
    static void Main()
    {
        // If you uncomment the following statement, it will generate
        // an error because the constructor is inaccessible:
        // Counter aCounter = new Counter();   // Error
    }
}
```


### ref
https://www.c-sharpcorner.com/blogs/can-a-class-work-without-constructor-in-c-sharp

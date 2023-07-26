### Indexers

An **indexer** allows an **object to be indexed** such as an array.

**Indexers** allow **instances of a class** or **struct** to be indexed just like arrays.

The **indexed value** can be set or retrieved **without explicitly specifying** a type or instance member.


When you define an indexer for a class, this class behaves similar to a virtual array. You can then access the instance of this class using the **array access operator `[]`**.

Defining a property involves providing a property name. Indexers are not defined with names, but with the **`this`** keyword, which refers to the object instance.


-   Indexers enable objects to be indexed in a similar manner to arrays.
-   A **`get`** accessor returns a value. A **`set`** accessor assigns a value.
-   The **`value`** keyword is used to define the value being assigned by the set accessor.
-   Indexers do not have to be indexed by an integer value; it is up to you how to define the specific look-up mechanism.
-   Indexers can be overloaded.
-   Indexers can have more than one formal parameter, for example, when accessing a two-dimensional array.



**syntax:** 

```cs
element-type this[int index] {

   // The get accessor.
   get {
      // return the value specified by index
   }
   
   // The set accessor.
   set {
      // set the value specified by index
   }
}

```
Eg:
```cs
// Indexer declaration
public int this[int index]
{
    // get and set accessors
}
```
For generic, eg:
```cs
using System;

class SampleCollection<T>
{
   // Declare an array to store the data elements.
   private T[] arr = new T[100];

   // Define the indexer to allow client code to use [] notation.
   public T this[int i]
   {
      get { return arr[i]; }
      set { arr[i] = value; }
   }
}

class Program
{
   static void Main()
   {
      var stringCollection = new SampleCollection<string>();
      stringCollection[0] = "Hello, World";
      Console.WriteLine(stringCollection[0]);
   }
}
// The example displays the following output:
//       Hello, World.
```

```cs
using System;

namespace IndexerApplication {
   
   class IndexedNames {
      private string[] namelist = new string[size];
      static public int size = 10;
      
      public IndexedNames() {
         for (int i = 0; i < size; i++)
         namelist[i] = "N. A.";
      }
      public string this[int index] {
         get {
            string tmp;
         
            if( index >= 0 && index <= size-1 ) {
               tmp = namelist[index];
            } else {
               tmp = "";
            }
            
            return ( tmp );
         }
         set {
            if( index >= 0 && index <= size-1 ) {
               namelist[index] = value;
            }
         }
      }
      static void Main(string[] args) {
         IndexedNames names = new IndexedNames();
         names[0] = "Zara";
         names[1] = "Riz";
         names[2] = "Nuha";
         names[3] = "Asif";
         names[4] = "Davinder";
         names[5] = "Sunil";
         names[6] = "Rubic";
         
         for ( int i = 0; i < IndexedNames.size; i++ ) {
            Console.WriteLine(names[i]);
         }
         Console.ReadKey();
      }
   }
}
```

```cs
public class TempRecord
{
    // Array of temperature values
    float[] temps = new float[10]
    {
        56.2F, 56.7F, 56.5F, 56.9F, 58.8F,
        61.3F, 65.9F, 62.1F, 59.2F, 57.5F
    };

    // To enable client code to validate input
    // when accessing your indexer.
    public int Length => temps.Length;
    
    // Indexer declaration.
    // If index is out of range, the temps array will throw the exception.
    public float this[int index]
    {
        get => temps[index];
        set => temps[index] = value;
    }
}
```
```cs
class Program
{
    static void Main()
    {
        var tempRecord = new TempRecord();

        // Use the indexer's set accessor
        tempRecord[3] = 58.3F;
        tempRecord[5] = 60.1F;

        // Use the indexer's get accessor
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Element #{i} = {tempRecord[i]}");
        }

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
    /* Output:
        Element #0 = 56.2
        Element #1 = 56.7
        Element #2 = 56.5
        Element #3 = 58.3
        Element #4 = 58.8
        Element #5 = 60.1
        Element #6 = 65.9
        Element #7 = 62.1
        Element #8 = 59.2
        Element #9 = 57.5
    */
}
```

### Indexers in Interfaces
Indexers can be declared on an interface.

Accessors of interface indexers differ from the accessors of class indexers in the following ways:

-   Interface accessors do not use modifiers.
-   An interface accessor typically does not have a body.

The purpose of the accessor is to indicate whether the indexer is read-write, read-only, or write-only. You may provide an implementation for an indexer defined in an interface, but this is rare. Indexers typically define an API to access data fields, and data fields cannot be defined in an interface.

```cs
public interface ISomeInterface
{
    //...
    // Indexer declaration:
    element-type this[int index]
    {
        get;
        set;
    }
}
```
Eg: 
```
// Indexer on an interface:
public interface IIndexInterface
{
    // Indexer declaration:
    int this[int index]
    {
        get;
        set;
    }
}

// Implementing the interface.
class IndexerClass : IIndexInterface
{
    private int[] arr = new int[100];
    public int this[int index]   // indexer declaration
    {
        // The arr object will throw IndexOutOfRange exception.
        get => arr[index];
        set => arr[index] = value;
    }
}

```
```cs
IndexerClass test = new IndexerClass();
System.Random rand = System.Random.Shared;
// Call the indexer to initialize its elements.
for (int i = 0; i < 10; i++)
{
    test[i] = rand.Next();
}
for (int i = 0; i < 10; i++)
{
    System.Console.WriteLine($"Element #{i} = {test[i]}");
}

/* Sample output:
    Element #0 = 360877544
    Element #1 = 327058047
    Element #2 = 1913480832
    Element #3 = 1519039937
    Element #4 = 601472233
    Element #5 = 323352310
    Element #6 = 1422639981
    Element #7 = 1797892494
    Element #8 = 875761049
    Element #9 = 393083859
*/
```

You could also use the explicit interface member implementation by using the fully qualified name of the interface member. 

```cs
string IIndexInterface.this[int index]
{
}

```




### ref
https://www.tutorialspoint.com/csharp/csharp_indexers.htm

https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/

https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/using-indexers

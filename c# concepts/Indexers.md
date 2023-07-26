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


### ref
https://www.tutorialspoint.com/csharp/csharp_indexers.htm

https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/



### Indexers

An **indexer** allows an **object to be indexed** such as an array.

**Indexers** allow **instances of a class** or **struct** to be indexed just like arrays.

The indexed value can be set or retrieved without explicitly specifying a type or instance member.


When you define an indexer for a class, this class behaves similar to a virtual array. You can then access the instance of this class using the **array access operator `[]`**.

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



### ref
https://www.tutorialspoint.com/csharp/csharp_indexers.htm

https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/



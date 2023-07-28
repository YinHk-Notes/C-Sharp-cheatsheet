## Predicate<T> Delegate
A **Predicate** is a **delegate** that accepts **one or more generic parameters** and **returns a boolean value**.

**Predicate** delegates are typically used to **perform search operations based on a set of criteria**.

**Predicates** in C# are implemented with **delegates**. The **Predicate delegate** represents the method that **defines a set of criteria** and **determines whether the specified object meets those criteria**.


```cs
public delegate bool Predicate<in T>(T obj);

```

### ref
https://www.tutorialsteacher.com/csharp/csharp-predicate

https://learn.microsoft.com/en-us/dotnet/api/system.predicate-1?view=net-7.0


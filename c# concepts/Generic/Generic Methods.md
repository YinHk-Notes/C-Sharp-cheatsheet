## Generic Methods

A method declared with the **type parameters** for its **return type** or **parameters** is called a **generic method**.

```cs
class DataStore<T>
{
    private T[] _data = new T[10];
    
    public void AddOrUpdate(int index, T item)
    {
        if(index >= 0 && index < 10)
            _data[index] = item;
    }

    public T GetData(int index)
    {
        if(index >= 0 && index < 10)
            return _data[index];
        else 
            return default(T);
    }
}

/*
    the AddorUpdate() and the GetData() methods are generic methods.
The actual data type of the item parameter will be specified at the time of
instantiating the DataStore<T> class

*/

DataStore<string> cities = new DataStore<string>();
cities.AddOrUpdate(0, "Mumbai");
cities.AddOrUpdate(1, "Chicago");
cities.AddOrUpdate(2, "London");

DataStore<int> empIds = new DataStore<int>();
empIds.AddOrUpdate(0, 50);
empIds.AddOrUpdate(1, 65);
empIds.AddOrUpdate(2, 89);
```

A non-generic class can include generic methods by specifying a type parameter in angle brackets with the method name
```cs
class Printer
{
    public void Print<T>(T data)
    {
        Console.WriteLine(data);
    }
}

Printer printer = new Printer();
printer.Print<int>(100);
printer.Print(200); // type infer from the specified value
printer.Print<string>("Hello");
printer.Print("World!"); // type infer from the specified value



```

### ref 
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-methods

## Dynamic type 
The dynamic type is a **`static`** type, but an object of type dynamic **bypasses `static` type checking**
In C# 4.0 (.NET 4.5) introduced a new type called **`dynamic`** that **avoids compile-time type checking**.

A `dynamic` type **escapes type checking at compile-time**; instead, it **resolves type at run time**.

eg:
```cs
dynamic MyDynamicVar = 1;
```

```cs
class Program
{
    static void Main(string[] args)
    {
        dynamic stud = new Student();

        stud.DisplayStudentInfo(1, "Bill");// run-time error, no compile-time error
        stud.DisplayStudentInfo("1");// run-time error, no compile-time error
        stud.FakeMethod();// run-time error, no compile-time error
    }
}

public class Student
{
    public void DisplayStudentInfo(int id)
    {
    }
  ```

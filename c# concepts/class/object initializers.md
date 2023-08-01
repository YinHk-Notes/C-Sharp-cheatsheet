## Object initializers
Object initializers let you assign values to any accessible **fields or properties** of an object at creation time **without having to invoke a constructor followed by lines of assignment statements**.

The object initializer syntax enables you to specify arguments for a constructor or omit the arguments (and parentheses syntax).

Object initializer is a new way to initialize an object of a **class or collection**. Object initializers allow you to assign values to the fields or properties at the time of creating an object without invoking a constructor.


Eg:
```cs
public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Student std = new Student() { StudentID = 1, 
                                      StudentName = "Bill", 
                                      Age = 20, 
                                      Address = "New York"   
                                    };
    }
}


```
```cs
IList<Student> studentList = new List<Student>() { 
                    new Student() { StudentID = 1, StudentName = "John"} ,
                    new Student() { StudentID = 2, StudentName = "Steve"} ,
                    new Student() { StudentID = 3, StudentName = "Bill"} ,
                    new Student() { StudentID = 3, StudentName = "Bill"} ,
                    new Student() { StudentID = 4, StudentName = "Ram" } ,
                    new Student() { StudentID = 5, StudentName = "Ron" } 
                };
```



- Initializer syntax makes a code more readable, easy to add elements into the collection.
- Useful in multi-threading.


### ref
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers

https://www.tutorialsteacher.com/csharp/csharp-object-initializer




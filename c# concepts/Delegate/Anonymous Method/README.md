## Anonymous Method in Delegate

An **anonymous method** is a method without a **name**.

Anonymous methods in C# can be defined using the **delegate** keyword and can be assigned to a variable of **`delegate` type**.

```cs
public delegate void Print(int value);

static void Main(string[] args)
{
    Print print = delegate(int val) { 
        Console.WriteLine("Inside Anonymous method. Value: {0}", val); 
    };

    print(100);
}
```


> **Anonymous methods** can also be passed to a method that accepts the **delegate** as a parameter.

```cs
public delegate void Print(int value);

class Program
{
    public static void PrintHelperMethod(Print printDel,int val)
    { 
        val += 10;
        printDel(val);
    }

    static void Main(string[] args)
    {
        PrintHelperMethod(delegate(int val) { Console.WriteLine("Anonymous method: {0}", val); }, 100);
    }
}
```



> **Anonymous methods** can be used as **event handlers**.

```cs
saveButton.Click += delegate(Object o, EventArgs e)
{ 
    System.Windows.Forms.MessageBox.Show("Save Successfully!"); 
};
```





- **Anonymous** method can be defined using the **delegate** keyword
- **Anonymous** method must be assigned to a delegate.
- **Anonymous** method can access outer variables or functions.
- **Anonymous** method can be passed as a parameter.
- **Anonymou**s method can be used as **event handlers**.


### Named vs. Anonymous Methods
A delegate can be associated with a named method. When you instantiate a delegate by using a named method

Delegates constructed with a named method can encapsulate either a static method or an instance method.

Name method in **delegate**:
```cs
// Declare a delegate.
delegate void Del(int x);

// Define a named method.
void DoWork(int k) { /* ... */ }

// Instantiate the delegate using the method as a parameter.
Del d = obj.DoWork;
```

The **delegate** operator creates an **anonymous method** that can be converted to a **delegate type**. 



### ref 
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/delegates-with-named-vs-anonymous-methods

https://www.tutorialsteacher.com/csharp/csharp-anonymous-method




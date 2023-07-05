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



### ref 
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/delegates-with-named-vs-anonymous-methods

https://www.tutorialsteacher.com/csharp/csharp-anonymous-method




## Action Delegate
C# includes built-in generic delegate types **`Func`** and **`Action`**, so that you **don't need to define custom delegates manually** in most cases (**No need to declare delegate**).

**Action** is a delegate type defined in the System namespace. An Action type **delegate** is the same as **`Func`** delegate except that the **Action delegate doesn't return a value**. 
In other words, an Action delegate can be **used with a method that has a **`void`** return type**.


- **Action delegate** is same as **`func`** **delegate** except that it **does not return anything**. Return type must be **`void`**.
- **Action delegate** can have **0 to 16** **input parameters**.
  ```cs
    public delegate void Action<in T1,in T2,in T3,in T4,in T5,in T6,in T7,in T8,in T9,in T10,in T11,in T12,in T13,in T14,in T15,in T16>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16);

  ```
- **Action delegate** can be used with **anonymous methods** or **lambda expressions**.


Example:

C# Delegate:
```cs
public delegate void Print(int val);

static void ConsolePrint(int i)
{
    Console.WriteLine(i);
}

static void Main(string[] args)
{           
    Print prnt = ConsolePrint;
    prnt(10);
}

```

Switch normal delegate to **Action delegate**:
```cs
static void ConsolePrint(int i)
{
    Console.WriteLine(i);
}

static void Main(string[] args)
{
    Action<int> printActionDel = ConsolePrint;
    printActionDel(10);
}

```

> **Note**: We can initialize an Action delegate using the **`new`** keyword or by directly assigning a method:

```cs
Action<int> printActionDel = ConsolePrint;

//Or

Action<int> printActionDel = new Action<int>(ConsolePrint);
```


> **Note**: An **Anonymous method** can also be assigned to an **Action delegate**.

```cs
static void Main(string[] args)
{
    Action<int> printActionDel = delegate(int i)
                                {
                                    Console.WriteLine(i);
                                };

    printActionDel(10);
}
```

> Note: A **Lambda expression** also can be used with an **Action delegate**.

```cs

static void Main(string[] args)
{

    Action<int> printActionDel = i => Console.WriteLine(i);
       
    printActionDel(10);
}

```






### ref 
https://www.tutorialsteacher.com/csharp/csharp-action-delegate

https://learn.microsoft.com/en-us/dotnet/api/system.action-1?view=net-7.0

## Multiple generic types

You can specify **more than one parameter type**. To do this, in the <> operator, after the first generic type, enter a comma and another generic type.

eg:
```cs
public class Exercise<T, V>
{

}
```

```cs
public class Exercise<T, V>
{
    private T t;
    private V v;

    public void SetTValue(T value)
    {
        t = value;
    }

    public T GetTValue()
    {
        return t;
    }

    public void SetVValue(V value)
    {
        v = value;
    }
    public V GetVValue()
    {
        return v;
    }

    public  void Show(T tValue, V vValue)
    {
        Console.WriteLine(L"First:  {0}\nSecond: {1}", tValue, vValue);
    }
}

```
```cs
class Program
{
    static int Main()
    {
        Exercise<int, int>; IntTypes = new Exercise<int, int>;();
        IntTypes.SetTValue(246);
        IntTypes.SetVValue(6088);
        IntTypes.Show(IntTypes.GetTValue(), IntTypes.GetVValue());

        Exercise<double, double>; DoubleTypes = new Exercise<double, double>;();
        DoubleTypes.SetTValue(355.65);
        DoubleTypes.SetVValue(1785.426);
        DoubleTypes.Show(DoubleTypes.GetTValue(), DoubleTypes.GetVValue());

        Exercise<short, decimal>; Disparate = new Exercise<short, decimal>;();
        DoubleTypes.SetTValue(42);
        DoubleTypes.SetVValue(245580.35);
        DoubleTypes.Show(DoubleTypes.GetTValue(), DoubleTypes.GetVValue());
        
        return 0;
    }
}
```

### ref 
https://www.functionx.com/csharp1/topics/generics4.htm



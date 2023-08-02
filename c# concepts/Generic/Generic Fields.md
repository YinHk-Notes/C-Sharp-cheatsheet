## Generic Fields

A generic class can include generic fields. However, **it cannot be initialized**!.

```cs
class DataStore<T>
{
    public T data;
}
```

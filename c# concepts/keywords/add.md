## `add`

The `add` contextual keyword is used to define a custom event accessor that is invoked when client code subscribes to your event. If you supply a custom `add` accessor

you **must also supply a `remove` accessor**.

```cs
class Events : IDrawingObject
{
    event EventHandler PreDrawEvent;

    event EventHandler IDrawingObject.OnDraw
    {
        add => PreDrawEvent += value;
        remove => PreDrawEvent -= value;
    }
}
```

### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/add


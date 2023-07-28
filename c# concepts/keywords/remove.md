## `remove`

The `remove` contextual keyword is used to define a custom event accessor that is invoked when client code unsubscribes from your event.

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
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/remove


## Event

An **event** is a notification sent by an object to signal the occurrence of an action.

### Declare an Event

An event can be declared in two steps:

1.  Declare a **delegate**.
2.  Declare a variable of the delegate with **`event`** keyword.

```cs
public delegate void Notify();  // delegate
                    
public class ProcessBusinessLogic
{
    public event Notify ProcessCompleted; // event

}
```

### ref 
https://www.tutorialsteacher.com/csharp/csharp-event

https://learn.microsoft.com/en-us/dotnet/standard/events/

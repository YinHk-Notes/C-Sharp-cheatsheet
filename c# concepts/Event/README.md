## Event

An **event** is a notification sent by an object to signal the occurrence of an action.

**Events** are user actions such as key press, clicks, mouse movements, etc., or some occurrence such as system generated notifications. Applications need to respond to events when they occur. 

> The **`event`** keyword is used to declare an **event** in a **publisher class**.
> Declare the event using the **`event`** keyword


### Publisher class 
The **events** are **declared and raise**d in a class and associated with the **event handlers using delegates** within the same class or some other class. The class containing the event is used to **publish the event**. This is called the **"publisher class"**.

Some other class that **accepts this event** is called the **"subscriber class"**. Events use the **publisher-subscriber model**.

A **publisher** is an object that contains the **definition of the event** and the **delegate**. The event-delegate association is also defined in this object. A **publisher class** object **invokes the event** and it is **notified to other objects**.

A **subscriber** is an object that **accepts the event** and **provides an event handler**. The delegate in the publisher class **invokes the method (event handler) of the subscriber class**.

Eg:
```cs
public class SampleEventArgs
{
    public SampleEventArgs(string text) { Text = text; }
    public string Text { get; } // readonly
}

public class Publisher
{
    // Declare the delegate (if using non-generic pattern).
    public delegate void SampleEventHandler(object sender, SampleEventArgs e);

    // Declare the event.
    public event SampleEventHandler SampleEvent;

    // Wrap the event in a protected virtual method
    // to enable derived classes to raise the event.
    protected virtual void RaiseSampleEvent()
    {
        // Raise the event in a thread-safe manner using the ?. operator.
        SampleEvent?.Invoke(this, new SampleEventArgs("Hello"));
    }
}


````

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


### event Action<>
```cs
public event Action<bool, int, Blah> DiagnosticsEvent;
```

### ref 
https://www.tutorialsteacher.com/csharp/csharp-event

https://learn.microsoft.com/en-us/dotnet/standard/events/

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/event

https://medium.com/nerd-for-tech/c-delegates-actions-events-summary-please-8fab0244a40a

https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/events/

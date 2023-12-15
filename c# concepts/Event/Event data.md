## Event data

Event data is **Data** that is **associated with an event**


**Data** that is **associated with an event** can be provided through an **event data** class. **.NET** provides many event data classes that you can use in your applications. 

Most events **send some data** to the **subscribers**. The **`EventArgs`** class is the base class for all the event data classes.

**`EventArgs`** is also the class you use when an event doesn't have any data associated with it. When you create an event that is only meant to notify other classes that something happened and doesn't need to pass any data, include the **`EventArgs`** class as the second parameter in the delegate.  You can pass the **`EventArgs.Empty`** value when no data is provided. The **`EventHandler`** delegate includes the **`EventArgs`** class as a parameter.

When you want to create a customized event data class, create a class that derives from **`EventArgs`**, and then provide any members needed to pass data that is related to the event. 

**.NET** includes many **built-in event data** classes.

For example, the **`SerialDataReceivedEventArgs`** class is the event data class for the **`SerialPort.DataReceived event`**. **.NET** follows a naming pattern of ending all event data classes with **`EventArgs`**. You determine which event data class is associated with an event by looking at the delegate for the event. 

For example, the **`SerialDataReceivedEventHandler`** delegate includes the **`SerialDataReceivedEventArgs`** class as one of its parameters.


### Passing an Event Data

You can Use **`EventHandler<TEventArgs>`** delegate to pass data to the handler. A method that will handle an event when the event provides data.

```cs
class Program
{
    public static void Main()
    {
        ProcessBusinessLogic bl = new ProcessBusinessLogic();
        bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
        bl.StartProcess();
    }

    // event handler
    public static void bl_ProcessCompleted(object sender, bool IsSuccessful)
    {
        Console.WriteLine("Process " + (IsSuccessful? "Completed Successfully": "failed"));
    }
}

public class ProcessBusinessLogic
{
    // declaring an event using built-in EventHandler
    public event EventHandler<bool> ProcessCompleted; 

    public void StartProcess()
    {
        try
        {
            Console.WriteLine("Process Started!");
			
            // some code here..

            OnProcessCompleted(true);
        }
        catch(Exception ex)
        {
            OnProcessCompleted(false);
        }
    }

    protected virtual void OnProcessCompleted(bool IsSuccessful)
    {
        ProcessCompleted?.Invoke(this, IsSuccessful);
    }
}

```

### Passing more than one Event Data
If you want to pass more than one value as event data, then create a class deriving from the **`EventArgs`** base class

eg: 

```cs
class ProcessEventArgs : EventArgs
{
    public bool IsSuccessful { get; set; }
    public DateTime CompletionTime { get; set; }
}

```


Full example for Passing Custom EventArgs:

```cs
class Program
{
    public static void Main()
    {
        ProcessBusinessLogic bl = new ProcessBusinessLogic();
        bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
        bl.StartProcess();
    }

    // event handler
    public static void bl_ProcessCompleted(object sender, ProcessEventArgs e)
    {
        Console.WriteLine("Process " + (e.IsSuccessful? "Completed Successfully": "failed"));
        Console.WriteLine("Completion Time: " + e.CompletionTime.ToLongDateString());
    }
}

public class ProcessBusinessLogic
{
    // declaring an event using built-in EventHandler
    public event EventHandler<ProcessEventArgs> ProcessCompleted; 

    public void StartProcess()
    {
        var data = new ProcessEventArgs();
		
        try
        {
            Console.WriteLine("Process Started!");
			
            // some code here..
            
            data.IsSuccessful = true;
            data.CompletionTime = DateTime.Now;
            OnProcessCompleted(data);
        }
        catch(Exception ex)
        {
            data.IsSuccessful = false;
            data.CompletionTime = DateTime.Now;
            OnProcessCompleted(data);
        }
    }

    protected virtual void OnProcessCompleted(ProcessEventArgs e)
    {
        ProcessCompleted?.Invoke(this, e);
    }
}
```



### ref
https://learn.microsoft.com/en-us/dotnet/standard/events/

https://learn.microsoft.com/en-us/dotnet/api/system.eventargs?view=net-8.0


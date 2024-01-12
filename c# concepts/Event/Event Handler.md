## Event Handler

**Event hander** use in **subscriber** class, define an event handler and subscribe to an event.

- To respond to an event, you define an event handler method in the event receiver.
- This method **must match the signature of the delegate** for the event you're handling.
- In the event handler, you perform the actions that are required when the event is raised,
- To receive notifications when the event occurs, your event handler method must subscribe to the event.

#### Built-in EventHandler Delegate
**.NET** Framework includes **built-in delegate** types **`EventHandler`** and **`EventHandler<TEventArgs>`** 
for the most common events.  Use these build-in delegates in subscriber class to raise event without declaring custom delegate. 

- Use the **`EventHandler`** delegate for all events that do **not include event data**.
- Use **`EventHandler<TEventArgs>`** delegate for events that **include data** to be sent to handlers

Typically, any **`event`** should include two parameters: 
- The source of the **`event`** (The instance **raises the event**)
- **`event`** data

> The **`EventHandler`** delegate is a **predefined delegate** that specifically represents an event handler method for an **`event`** that does not generate data.

> If your event does **generate data**, you **must** use the generic **`EventHandler<TEventArgs>`** delegate class

The standard signature of an event handler delegate defines a method that **does not return a value**. This method's first parameter is of **type Object** and **refers to the instance** that **raises the event**. Its second parameter is derived from type **`EventArgs`** and **holds the event data**. If the **`event`** **does not generate event data**, the second parameter is simply the value of the **`EventArgs.Empty`** field. Otherwise, the second parameter - **`TEventArgs`** is a type derived from **`EventArgs`** and supplies any fields or properties needed to **hold the event data**.


**`EventHandler` Delegate**

```cs
public delegate void EventHandler(object? sender, EventArgs e);
```

- **sender Object**: The source of the event.

- **e EventArgs**: An object that contains no event data.

> You can pass the **`EventArgs.Empty`** value when **no data is provided**. The **`EventHandler`** delegate includes the **`EventArgs`** class as a parameter.


**`EventHandler<TEventArgs>` Delegate**

```cs
public delegate void EventHandler<TEventArgs>(object? sender, TEventArgs e);
```

- **sender Object**: The source of the event.
- **e TEventArgs**: An object that contains the event data.

```cs
using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter(new Random().Next(10));
            c.ThresholdReached += c_ThresholdReached;

            Console.WriteLine("press 'a' key to increase total");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                c.Add(1);
            }
        }

        static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine("The threshold of {0} was reached at {1}.", e.Threshold,  e.TimeReached);
            Environment.Exit(0);
        }
    }

    class Counter
    {
        private int threshold;
        private int total;

        public Counter(int passedThreshold)
        {
            threshold = passedThreshold;
        }

        public void Add(int x)
        {
            total += x;
            if (total >= threshold)
            {
                ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
                args.Threshold = threshold;
                args.TimeReached = DateTime.Now;
                OnThresholdReached(args);
            }
        }

        protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
        {
            EventHandler<ThresholdReachedEventArgs> handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;
    }

    public class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }
}
```



### ref 
https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler?view=net-8.0

https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1?view=net-8.0

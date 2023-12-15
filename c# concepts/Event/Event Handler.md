## Event Handler

Event hander use in subscriber class, define an event handler and subscribe to an event.

- To respond to an event, you define an event handler method in the event receiver.
- This method **must match the signature of the delegate** for the event you're handling.
- In the event handler, you perform the actions that are required when the event is raised,
- To receive notifications when the event occurs, your event handler method must subscribe to the event.

#### Built-in EventHandler Delegate
**.NET** Framework includes built-in delegate types **`EventHandler`** and **`EventHandler<TEventArgs>`** 
for the most common events. 


- Use the **`EventHandler`** delegate for all events that do not include event data.
- Use **`EventHandler<TEventArgs>`** delegate for events that include data to be sent to handlers

Typically, any **`event`** should include two parameters: 
- The source of the **`event`**
- **`event`** data




### ref 
https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler?view=net-8.0

https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1?view=net-8.0

## Event data

Data that is associated with an event can be provided through an event data class. .NET provides many event data classes that you can use in your applications. For example, the [SerialDataReceivedEventArgs](chrome-extension://pcmpcfapbekmbjjkdalcgopdkipoggdi/en-us/dotnet/api/system.io.ports.serialdatareceivedeventargs) class is the event data class for the [SerialPort.DataReceived](chrome-extension://pcmpcfapbekmbjjkdalcgopdkipoggdi/en-us/dotnet/api/system.io.ports.serialport.datareceived#system-io-ports-serialport-datareceived) event. .NET follows a naming pattern of ending all event data classes with `EventArgs`. You determine which event data class is associated with an event by looking at the delegate for the event. For example, the [SerialDataReceivedEventHandler](chrome-extension://pcmpcfapbekmbjjkdalcgopdkipoggdi/en-us/dotnet/api/system.io.ports.serialdatareceivedeventhandler) delegate includes the [SerialDataReceivedEventArgs](chrome-extension://pcmpcfapbekmbjjkdalcgopdkipoggdi/en-us/dotnet/api/system.io.ports.serialdatareceivedeventargs) class as one of its parameters.





### ref
https://learn.microsoft.com/en-us/dotnet/standard/events/

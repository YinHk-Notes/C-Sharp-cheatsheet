class Script
{ 
	static void Main(string[] args)
	{
		//event
		Publisher pub = new Publisher();
		Subscriber sub = new Subscriber(1, pub);
		pub.OnAlert();

		//EventHandler delegate
		Subscriber sub2 = new Subscriber(2, pub);
		pub.InvokeEvent();

		//EventHabdler<TEventArgs> 
		Subscriber sub3 = new Subscriber(3, pub);
		MyEventArgs eventArgs = new MyEventArgs() { Number = 1, Text = "hello world" };
		pub.InvokeEventWithdata(eventArgs);
	}
}
  
class Publisher
{
	//C# event
	public delegate void Alert();
	public event Alert alert;

	//EventHandler 
	public event EventHandler messageLog;

	//EventHandler<TEventArgs>
	public event EventHandler<MyEventArgs> eventDataLog;

	//raising an event here
	public void OnAlert()
	{
		alert?.Invoke(); //invoke delegate
	}

	//EvenHandler delegate
	public void InvokeEvent() => OnCall();
	protected virtual void OnCall() => messageLog?.Invoke(this, EventArgs.Empty);


	//EventHandler<TEventArgs> delegate
	public void InvokeEventWithdata(MyEventArgs args) => OnMessage(args);
	protected virtual void OnMessage(MyEventArgs args) => eventDataLog?.Invoke(this, args);
}

class Subscriber
{
	public Subscriber(int id, Publisher p)
	{

		if (id == 1) p.alert += AlertHandler;
		else if (id == 2) p.messageLog += MessageHandler;
		else if (id == 3) p.eventDataLog += EventDataHandler;
	}

	public void AlertHandler()
	{
		Console.Beep(3000, 1000);
		Console.WriteLine("This is an alert!");
	}

	public void MessageHandler(object sender, EventArgs e)
	{
		Console.Beep(8000, 1000);
		Console.WriteLine("This is a message");
	}

	public void EventDataHandler(object sender, MyEventArgs e)
	{
		Console.Beep(1000, 1000);
		Console.WriteLine($"There is {e.Number} text from sender." + " " + $"Text: {e.Text}");
	}
}

class MyEventArgs : EventArgs
{
	public int Number { get; set; }
	public string Text { get; set; }
}



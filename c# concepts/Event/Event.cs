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
	}
}
  
class Publisher
{
	//C# event
	public delegate void Alert();
	public event Alert alert;

	//EventHandler 
	public event EventHandler messageLog;

	//raising an event here
	public void OnAlert()
	{
		alert?.Invoke(); //invoke delegate
	}

	//EvenHandler delegate

	public void InvokeEvent() => OnCall();
	protected virtual void OnCall()
	{
		messageLog?.Invoke(this, EventArgs.Empty);
	}


}

class Subscriber
{
	public Subscriber(int id, Publisher p)
	{

		if (id == 1) p.alert += AlertHandler;
		else if (id == 2) p.messageLog += MessageHandler;
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
}

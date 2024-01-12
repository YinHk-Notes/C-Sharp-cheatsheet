class Script
{ 
	static void Main(string[] args)
	{
		//event
		Publisher pub = new Publisher();
		Subscriber sub = new Subscriber(pub);
		pub.onAlert();
	}
}
  
class Publisher
{
	//C# event
	public delegate void Alert();

	public event Alert alert;

	//raising an event here
	public void onAlert()
	{
		alert?.Invoke(); //invoke delegate
	}
}

class Subscriber
{
	public Subscriber(Publisher p) => p.alert += eventHandler;

	public void eventHandler()
	{
		Console.Beep(3000, 1000);
		Console.WriteLine("This is an alert!");
	}
}


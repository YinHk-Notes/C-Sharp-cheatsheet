using System;
using System.Collections;
using System.Collections.Generic;

class Script
{
	
	static void Main(string[] args)
	{
		Script script = new Script();
    
		//delegate 
		MessageDelegate del = MyDelegate.Message;
		del.Invoke("This is a simple example of delegate");
		//Multicast delegate
		del += MyDelegate.AnotherMessage;
		del.Invoke("delegate");
		//Anonymous method in delegate
		MessageDelegate del2 = delegate (string message)
		{
			Console.WriteLine($"{message}");
		};
		del2.Invoke("This anonymous");
	}
}

class MyDelegate
{
	//a delegate method
	public static void Message(string message)
	{
		Console.WriteLine($"{message}");
	}

	public static void AnotherMessage(string message)
	{
		Console.WriteLine($"Another {message}");
	}

}











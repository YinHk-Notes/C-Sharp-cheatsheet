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
		
		//Action delegate - without care about declaration of delegate
		Action<string> del3 = MyDelegate.Message;
		del3.Invoke("This is from Action delegate");

		//Function delegate - without care about declaration of delegate
		Func<int, string> del4 = MyDelegate.NumberToString;
		string number = del4.Invoke(100);
		Console.WriteLine(number);
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











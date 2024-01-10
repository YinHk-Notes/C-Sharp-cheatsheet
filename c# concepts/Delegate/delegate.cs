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

	}
}

class MyDelegate
{
	//a delegate method
	public static void Message(string message)
	{
		Console.WriteLine($"{message}");
	}

}











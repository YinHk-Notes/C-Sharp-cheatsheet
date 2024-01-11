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

		//Predicate delegate
		Predicate<int> predicate = MyDelegate.FindMultiples;
		List<int> list = new List<int>() { 1, 3, 5, 7, 9, 11, 13, 15 };
		int multiple = list.Find(predicate);
		Console.WriteLine(multiple);
		List<int> multiples = list.FindAll(predicate);
		foreach (var i in multiples)
		{
			Console.WriteLine(i);
		}

		//Compariosn delegate
		Comparison<int> compare = MyDelegate.CompareNumbers;
		var numbers = new List<int> { -1, 20, 3, 9, 11, -3, 99, 150, 2, 0, 21, 1 };
		numbers.Sort(compare);

		foreach (var i in numbers)
		{
			Console.WriteLine(i);
		}
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

	public static string NumberToString(int num)
	{
		string str = num.ToString();
		return "The number is:" + str;
	}
	
	//Check whether the integer is multiple of 3 
	public static bool FindMultiples(int element)
	{
		return element % 3 == 0;
	}

	public static int CompareNumbers(int x, int y)
	{
		if (x - y > 0) return 1;
		else if (x - y < 0) return -1;
		else return 0;
	}

}











// public static class Console
// Inheritance: Object -> Console
// Represents the standard input, output, and error streams for console applications. 
// This class cannot be inherited.
// https://learn.microsoft.com/en-us/dotnet/api/system.console?view=net-8.0

using System;

// Writes the specified data, followed by the current line terminator, to the standard output stream.
Console.WriteLine();

// Writes the text representation of the specified value or values to the standard output stream
Console.Write();

/*
  The difference between Write(…) and WriteLine(…) is that the Write(…) method prints on the console what it is provided between the parentheses but does nothing in addition while the method WriteLine(…) means directly “write line”. 
  This method does what the Write(…) one does but in addition goes to a new line.
  
  eg: 
  Console.WriteLine("I love");
  Console.Write("this ");
  Console.Write("Book!");
  
  output
  I love
  this Book!  //same line
 */    

// Clears the console buffer and corresponding console window of display information
Console.Clear();

// Read the next character from the standard input stream, or a negative one (-1) if there are currently no more characters to be read
Console.Read();
/*
 eg:
  int x;
        Console.WriteLine("Enter your Character to get Decimal number");
  
        // using the method
        x = Console.Read();
        Console.WriteLine(x);
*/

// Read the next line of characters from the standard input stream
Console.ReadLine();

/* 
eg:
public static void Main()
{
        int age;
        string name;
 
        Console.WriteLine("Enter your name: ");
         
        // using the method
        // typecasting not needed
        // as ReadLine returns string
        name = Console.ReadLine();
         
        Console.WriteLine("Enter your age: ");
         
        // Converted string to int
        age = Convert.ToInt32(Console.ReadLine());
         
        if (age >= 18)
        {
            Console.WriteLine("Hello " + name + "!"
                        + " You can vote");
        }
        else {
            Console.WriteLine("Hello " + name + "!"
                + " Sorry you can't vote");
        }
    }
}
*/



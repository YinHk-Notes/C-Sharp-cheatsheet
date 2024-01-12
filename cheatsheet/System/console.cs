// public static class Console
// Inheritance: Object -> Console
// Represents the standard input, output, and error streams for console applications. 
// This class cannot be inherited.
// https://learn.microsoft.com/en-us/dotnet/api/system.console?view=net-8.0

using System;

//Properties

//Gets or sets the background color of the console
public static ConsoleColor BackgroundColor { get; set; }

//Gets or sets the height of the cursor within a character cell.
public static int CursorSize { get; set; }

//Gets or sets a value indicating whether the cursor is visible.
public static bool CursorVisible { get; set; }

//Gets the standard error output stream
public static System.IO.TextWriter Error { get; }

//Gets the standard input stream
public static System.IO.TextReader In { get; }

//Gets the standard output stream
public static System.IO.TextWriter Out { get; }


// Methods

//Plays the sound of a beep through the console speaker.
[System.Runtime.Versioning.SupportedOSPlatform("windows")]
public static void Beep (int frequency, int duration);

//Clears the console buffer and corresponding console window of display information
public static void Clear ();

//Reads the next character from the standard input stream
public static int Read ();

//Obtains the next character or function key pressed by the user. The pressed key is displayed in the console window.
public static ConsoleKeyInfo ReadKey ();

//Reads the next line of characters from the standard input stream
public static string? ReadLine ();

//Sets the foreground and background console colors to their defaults
public static void ResetColor ();

//Sets the Error property to the specified TextWriter object
public static void SetError (System.IO.TextWriter newError);

//eg:
Console.Error.WriteLine();

//Sets the In property to the specified TextReader object
public static void SetIn (System.IO.TextReader newIn);

//Sets the Out property to target the TextWriter object
public static void SetOut (System.IO.TextWriter newOut);


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



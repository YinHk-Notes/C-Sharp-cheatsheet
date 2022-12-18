// public static class Console
// Inheritance: Object -> Console
// Represents the standard input, output, and error streams for console applications. 
// This class cannot be inherited.

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


## XML Documentation comments

C# source files can have structured comments that produce API documentation for the types defined in those files. The C# compiler produces an _XML_ file that contains structured data representing the comments and the API signatures. Other tools can process that XML output to create human-readable documentation in the form of web pages or PDF files, for example.

This process provides many advantages for you to add API documentation in your code:

-   The C# compiler combines the structure of the C# code with the text of the comments into a single XML document.
-   The C# compiler verifies that the comments match the API signatures for relevant tags.
-   Tools that process the XML documentation files can define XML elements and attributes specific to those tools.

Tools like Visual Studio provide IntelliSense for many common XML elements used in documentation comments.

This article covers these topics:

-   Documentation comments and XML file generation
-   Tags validated by the C# compiler and Visual Studio
-   Format of the generated XML file

### Create XML documentation output

You create documentation for your code by writing special comment fields indicated by triple slashes. The comment fields include XML elements that describe the code block that follows the comments. For example:

```cs
/// <summary>
/// This class performs an important function.
/// </summary>
public class MyClass { }
```

`///` Single-line delimiter: The documentation examples and C# project templates use this form. If there's white space following the delimiter, it isn't included in the XML output.


### ref 

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/

https://medium.com/@lexitrainerph/c-xml-documentation-an-in-depth-guide-from-essentials-to-mastery-f5bb137fad0c




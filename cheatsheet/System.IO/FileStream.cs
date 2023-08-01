//FileStream
//Provides a Stream for a file, supporting both synchronous and asynchronous read and write operations.
//C# FileStream class provides a stream for file operation. It can be used to perform synchronous and asynchronous read and write operations. 
//By the help of FileStream class, we can easily read and write data into file.
//https://learn.microsoft.com/en-us/dotnet/api/system.io.filestream?view=net-7.0#methods

using System.IO;

public class FileStream : System.IO.Stream


//constructors
public FileStream (Microsoft.Win32.SafeHandles.SafeFileHandle handle, System.IO.FileAccess access);
public FileStream (Microsoft.Win32.SafeHandles.SafeFileHandle handle, System.IO.FileAccess access, int bufferSize);
public FileStream (Microsoft.Win32.SafeHandles.SafeFileHandle handle, System.IO.FileAccess access, int bufferSize, bool isAsync);
public FileStream (string path, System.IO.FileMode mode);
public FileStream (string path, System.IO.FileMode mode, System.IO.FileAccess access);
public FileStream (string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share);
public FileStream (string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share, int bufferSize);
public FileStream (string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share, int bufferSize, bool useAsync);
public FileStream (string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share, int bufferSize, System.IO.FileOptions options);
public FileStream (string path, System.IO.FileStreamOptions options);


//Properties
public override bool CanRead { get; }   //Gets a value that indicates whether the current stream supports reading.
public override bool CanSeek { get; }   //Gets a value that indicates whether the current stream supports seeking.
public virtual bool CanTimeout { get; } //Gets a value that determines whether the current stream can time out.
public override bool CanWrite { get; }  //Gets a value that indicates whether the current stream supports writing.
public virtual bool IsAsync { get; }    //Gets a value that indicates whether the FileStream was opened asynchronously or synchronously.
public override long Length { get; }    //Gets the length in bytes of the stream.
public virtual string Name { get; }     //Gets the absolute path of the file opened in the FileStream.
public override long Position { get; set; }   //Gets or sets the current position of this stream.
public virtual int ReadTimeout { get; set; }  //Gets or sets a value, in milliseconds, that determines how long the stream will attempt to read before timing out.
public virtual Microsoft.Win32.SafeHandles.SafeFileHandle SafeFileHandle { get; } //Gets a SafeFileHandle object that represents the operating system file handle for the file
public virtual int WriteTimeout { get; set; }  //Gets or sets a value, in milliseconds, that determines how long the stream will attempt to write before timing out.





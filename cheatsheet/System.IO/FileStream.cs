//FileStream
//Provides a Stream for a file, supporting both synchronous and asynchronous read and write operations.
//C# FileStream class provides a stream for file operation. It can be used to perform synchronous and asynchronous read and write operations. 
//By the help of FileStream class, we can easily read and write data into file.
//https://learn.microsoft.com/en-us/dotnet/api/system.io.filestream?view=net-7.0#methods

using System.IO;

public class FileStream : System.IO.Stream


//Constructors
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





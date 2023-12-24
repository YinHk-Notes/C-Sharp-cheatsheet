### Convert JSON String to Object in C#

#### Class Structure for JSON String
```cs
public class Department{
    public int DeptId { get; set; }
    public string DepartmentName { get; set; }
}
```

#### Convert JSON String to Object in C#

.NET Core 3.0 and later versions include the built-in class `JsonSerializer` in the `System.Text.Json` namespace that provides functionality for serializing and deserializing from JSON.

The .NET 4.x framework does not provide any built-in `JsonSerializer` class that converts objects to JSON. You have to install the NuGet package `Microsoft.Extensions.Configuration.Json` in your project to include the `System.Text.Json.JsonSerializer` to your project which can be used to convert objects to JSON and vice-versa.

```cs
string jsonData = "{\"DeptId\": 101, \"DepartmentName\": \"IT\"}";

Department deptObj = JsonSerializer.Deserialize<Department>(jsonData);

Console.WriteLine("Department Id: {0}", deptObj.DeptId);
Console.WriteLine("Department Name: {0}", deptObj.DepartmentName);
```

#### Convert an Object to JSON in C#

.NET 5 framework provides the built-in `JsonSerializer` class in the `System.Text.Json` namespace to convert C# objects to JSON and vice-versa.

The .NET 4.x framework does not provide any built-in `JsonSerializer` class that converts objects to JSON. You have to install the NuGet package `Microsoft.Extensions.Configuration.Json` in your project to include the `System.Text.Json.JsonSerializer` to your project which can be used to convert objects to JSON and vice-versa.

Use the `JsonSerializer` class.Serialize method

```cs

using System;
using System.Text.Json;

namespace ObjectToJSONConversion
{
    public class Department
    {
        public int DeptId { get; set; }
        public string DepartmentName { get; set; }
    }

    class Program
    {
        public static void Main()
        {
            Department dept= new Department() { DeptId = 101, DepartmentName= "IT" };
            string strJson = JsonSerializer.Serialize<Department>(dept);
            Console.WriteLine(strJson);
        }
    }
}

```


### ref 
https://www.tutorialsteacher.com/articles/convert-json-string-to-object-in-csharp

https://www.tutorialsteacher.com/articles/convert-object-to-json-in-csharp

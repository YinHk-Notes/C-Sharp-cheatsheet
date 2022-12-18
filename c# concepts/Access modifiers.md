## Access modifiers

**Access modifiers** are keywords used to specify the declared accessibility of a member or a type. It determine the access Levels of the code. This section introduces the five access modifiers:

- `public`
- `protected`
- `internal`
- `private`
- `file`

|Modifier|Description|
|-|-|
|`public`|	The code is accessible for all classes. Access is not restricted.|
|`private`|The code is only accessible within the same class, cannot be accessed from any other class.|
|`protected`|	The code is accessible within the same class, or in a class that is inherited from that class. You will learn more about inheritance in a later chapter. Access is limited to the containing class or types derived from the containing class.|
|`internal`|	The code is only accessible within its own assembly, but not from another assembly. Access is limited to the current assembly. Used to limit the access to the elements of the class only to files from the same assembly, i.e. the same project in Visual Studio. When we create several projects in Visual Studio, the classes from will be compiled in different assemblies.|
|`protected internal`| Access is limited to the current assembly or types derived from the containing class.|
|`private protected`|Access is limited to the containing class or types derived from the containing class within the current assembly.|

|Members|Default|Allowed declared accessibility|
|-|-|-|
|`enum`|`public`|None|
|`class`|`private`|`public` `protected` `internal` `private` `protected internal` `private protected`|
|`interface`|`public`|`public` `protected` `internal` `private*` `protected internal` `private protected`|

### Assembly
`.NET` **assemblies** are collections of compiled types (classes and other types) and resources



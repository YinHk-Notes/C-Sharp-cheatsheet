## Object class


This is the ultimate base class of all .NET classes; it is the root of the type hierarchy.


```cs
public class Object

```


### Constructor

```cs
public Object ();
```


### Methods
|Method|Description|
|-|-|
| `Equals(Object)` | Determines whether the specified object is equal to the current object. |
| `Equals(Object, Object)` | Determines whether the specified object instances are considered equal. |
| `Finalize()` | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. |
| `GetHashCode()` | Serves as the default hash function. |
| `GetType()` | Gets the Type of the current instance. |
| `MemberwiseClone()` | Creates a shallow copy of the current Object. |
| `ReferenceEquals(Object, Object)` | Determines whether the specified Object instances are the same instance. |
| `ToString()` | Returns a string that represents the current object. |


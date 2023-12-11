## Boxing and Unboxing
Value type stores the value itself, whereas the reference type stores the address of the value where it is stored. 
Sometimes you often need to convert value types to reference types or vice-versa. reference types stored on heap where it contains the address of the value and value type is just an actual value stored on the stack.

convert them from one type to another, this conversion processes are called **boxing and unboxing**.



### Boxing
the process of **converting a value type to reference type**.  It wraps the value inside a `System.Object` instance and stores it on the managed heap.

```cs
int i = 123;
// Boxing copies the value of i into object o
object o = i;
```

### Unboxing 
Unboxing is the reverse of boxing. the process of **converting a reference type to value type**. Unboxing extract the value from the reference type and assign it to a value type. Unboxing extracts the value type from the object.

```cs
o = 123;
i = (int)o;  // unboxing
```

> Boxing is implicit; unboxing is explicit.


The casting of a boxed value is not permitted. The following will throw an exception:
```cs
int i = 10;
object o = i; // boxing
double d = (double)o; // runtime exception
```
First do unboxing and then do casting is no problem

```cs
int i = 10;
object o = i; // boxing
double d = (double)(int)o; // valid
```




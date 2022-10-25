## interface

An interface **defines a contract**. Any **class** or **struct** that implements that contract **must** provide an implementation of the members defined in the interface. An interface **may define a default implementation for members**. It **may also define static members** in order to provide a single implementation for common functionality.

An interface is a **completely "abstract class",** which can **only contain abstract methods** and **properties** (with empty bodies)

An interface can contain **declarations of methods, properties, indexers, and events**. However, it **cannot contain fields, auto-implemented properties**.

```cs
interface ISampleInterface
{
    void SampleMethod();
}

class ImplementationClass : ISampleInterface
{
    // Explicit interface member implementation:
    void ISampleInterface.SampleMethod()
    {
        // Method implementation.
    }
    static void Main()
    {
        // Declare an interface instance.
        ISampleInterface obj = new ImplementationClass();

        // Call the member.
        obj.SampleMethod();
    }
}
```

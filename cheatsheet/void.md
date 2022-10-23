## void
use void as the return type of a method (or a local function) to specify that the method doesn't return a value(**`void` means no value return**)

Eg: 
```cs
public static void Display(IEnumerable<int> numbers){
    if (numbers is null){
        return;
    }
    Console.WriteLine(string.Join(" ", numbers));
}
```





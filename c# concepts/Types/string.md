## string

In C#, you can combine two `char` values into a `string` using the following methods:

#### 1. **Using String Concatenation**
You can concatenate two `char` values by converting them to a `string` and adding them together:

```cs
char char1 = 'a';
char char2 = 'b';
string result = char1.ToString() + char2.ToString();
Console.WriteLine(result);  // Output: "ab"

```

#### 2. **Using String Interpolation**

String interpolation makes the code concise:

```cs
char char1 = 'a';
char char2 = 'b';
string result = $"{char1}{char2}";
Console.WriteLine(result);  // Output: "ab"

```

#### 3. **Using `new string()` Constructor**

The `string` constructor can create a string directly from an array of characters:

```cs
char char1 = 'a';
char char2 = 'b';
string result = new string(new char[] { char1, char2 });
Console.WriteLine(result);  // Output: "ab"

```

#### 4. **Using `string.Concat`**

The `string.Concat` method combines multiple values into a single string:

```cs
char char1 = 'a';
char char2 = 'b';
string result = string.Concat(char1, char2);
Console.WriteLine(result);  // Output: "ab"

```

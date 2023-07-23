## Reference variables

Reference variables - `ref`.

A reference variable is a variable that refers to another variable, which is called the referent.


When you assign a value to a reference variable, that value is assigned to the referent. When you read the value of a reference variable, the referent's value is returned.


```cs
ref int alias = ref variable;
```

Eg:
```cs
int a = 1;
ref int alias = ref a;
Console.WriteLine($"(a, alias) is ({a}, {alias})");  // output: (a, alias) is (1, 1)

a = 2;
Console.WriteLine($"(a, alias) is ({a}, {alias})");  // output: (a, alias) is (2, 2)

alias = 3;
Console.WriteLine($"(a, alias) is ({a}, {alias})");  // output: (a, alias) is (3, 3)
```








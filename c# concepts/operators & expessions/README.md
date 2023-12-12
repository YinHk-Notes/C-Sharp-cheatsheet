## C# operators and expressions

### Arithmetic Operators
| Operator | Description | Example |
| --- | --- | --- |
| + | Adds two operands | A + B = 30 |
| - | Subtracts second operand from the first | A - B = -10 |
| * | Multiplies both operands | A * B = 200 |
| / | Divides numerator by de-numerator | B / A = 2 |
| % | Modulus Operator and remainder of after an integer division | B % A = 0 |
| ++ | Increment operator increases integer value by one | A++ = 11 |
| -- | Decrement operator decreases integer value by one | A-- = 9 |

### Relational Operators

| Operator | Description | Example |
| --- | --- | --- |
| == | Checks if the values of two operands are equal or not, if yes then condition becomes true. | (A == B) is not true. |
| != | Checks if the values of two operands are equal or not, if values are not equal then condition becomes true. | (A != B) is true. |
| > | Checks if the value of left operand is greater than the value of right operand, if yes then condition becomes true. | (A > B) is not true. |
| < | Checks if the value of left operand is less than the value of right operand, if yes then condition becomes true. | (A < B) is true. |
| >= | Checks if the value of left operand is greater than or equal to the value of right operand, if yes then condition becomes true. | (A >= B) is not true. |
| <= | Checks if the value of left operand is less than or equal to the value of right operand, if yes then condition becomes true. | (A <= B) is true. |

### Boolean logical operators

| Operator | Description | Example |
| --- | --- | --- |
| `&&` | Called Logical AND operator. If both the operands are non zero then condition becomes true. | (A && B) is false. |
| `ll` | Called Logical OR Operator. If any of the two operands is non zero then condition becomes true. | (A ll B) is true. |
| `!` | Called Logical NOT Operator. Use to reverses the logical state of its operand. If a condition is true then Logical NOT operator will make false. | !(A && B) is true. |
| `^` | Logical exclusive OR operator.  | t ^ t = f, t ^ f = t, f ^ t = t, f ^ f = f |


### Bitwise operators
Bitwise operator works on bits and perform bit by bit operation. The truth tables for `&`, `|`, and `^` are as follows:

| p | q | p & q | p l q | p ^ q |
| --- | --- | --- | --- | --- |
| 0 | 0 | 0 | 0 | 0 |
| 0 | 1 | 0 | 1 | 1 |
| 1 | 1 | 1 | 1 | 0 |
| 1 | 0 | 0 | 1 | 1 |

Assume if A = 60; and B = 13; then in the binary format they are as follows −

A = 0011 1100

B = 0000 1101

A&B = 0000 1100

A|B = 0011 1101

A^B = 0011 0001

~A  = 1100 0011

| Operator | Description | Example |
| --- | --- | --- |
| & | Binary AND Operator copies a bit to the result if it exists in both operands. | (A & B) = 12, which is 0000 1100 |
| l | Binary OR Operator copies a bit if it exists in either operand. | (A l B) = 61, which is 0011 1101 |
| ^ | Binary XOR Operator copies the bit if it is set in one operand but not both. | (A ^ B) = 49, which is 0011 0001 |
| ~ | Binary Ones Complement Operator is unary and has the effect of 'flipping' bits. | (~A ) = -61, which is 1100 0011 in 2's complement due to a signed binary number. |
| << | Binary Left Shift Operator. The left operands value is moved left by the number of bits specified by the right operand. | A << 2 = 240, which is 1111 0000 |
| >> | Binary Right Shift Operator. The left operands value is moved right by the number of bits specified by the right operand. | A >> 2 = 15, which is 0000 1111 |

```cs
//Left shift
uint x = 0b_1100_1001_0000_0000_0000_0000_0001_0001;
uint y = x << 4;
// Before: 11001001000000000000000000010001
// After:  10010000000000000000000100010000


//Right shift
uint x = 0b_1001;
uint y = x >> 2;
// Before: 1001
// After:  0010
```


### Assignment Operators
| Operator | Description | Example |
| --- | --- | --- |
| = | Simple assignment operator, Assigns values from right side operands to left side operand | C = A + B assigns value of A + B into C |
| += | Add AND assignment operator, It adds right operand to the left operand and assign the result to left operand | C += A is equivalent to C = C + A |
| -= | Subtract AND assignment operator, It subtracts right operand from the left operand and assign the result to left operand | C -= A is equivalent to C = C - A |
| *= | Multiply AND assignment operator, It multiplies right operand with the left operand and assign the result to left operand | C *= A is equivalent to C = C * A |
| /= | Divide AND assignment operator, It divides left operand with the right operand and assign the result to left operand | C /= A is equivalent to C = C / A |
| %= | Modulus AND assignment operator, It takes modulus using two operands and assign the result to left operand | C %= A is equivalent to C = C % A |
| <<= | Left shift AND assignment operator | C <<= 2 is same as C = C << 2 |
| >>= | Right shift AND assignment operator | C >>= 2 is same as C = C >> 2 |
| &= | Bitwise AND assignment operator | C &= 2 is same as C = C & 2 |
| ^= | bitwise exclusive OR and assignment operator | C ^= 2 is same as C = C ^ 2 |
| l= | bitwise inclusive OR and assignment operator | C l= 2 is same as C = C l 2 |

### Member access operators

| Operator | Description | Example |
| --- | --- | --- |
|`.`|to access a member of a namespace or a type|`using System.Collections.Generic;`|
|`[]`|to access an array element or a type indexer|`int[] fib = new int[10];`|
|`?.`|to perform a member or element access operation only if an operand is non-null. If a evaluates to null, the result of `a?.x` is null. If a evaluates to non-null, the result of `a?.x`|`a?.x` |
|`?[]`|to perform a member or element access operation only if an operand is non-null. If a evaluates to null, the result of `a?.[x]` is null. If a evaluates to non-null, the result of `a?.[x]`|`a?.[x]`|
|`()`|Use parentheses, (), to call a method or invoke a delegate.| `callback()` |
|`^`|^ (index from end): to indicate that the element position is from the end of a sequence. For a sequence of length length, `^n` points to the element with offset length - n from the start of a sequence. For example, `^1` points to the last element of a sequence and `^length` points to the first element of a sequence.| var lines = new List<string> { "one", "two", "three", "four" }; string prelast = lines[^2]; //output: three|
|`..`|specifies the start and end of a range of indices as its operands. The left-hand operand is an inclusive start of a range. The right-hand operand is an exclusive end of a range. `a.. is equivalent to a..^0`, `..b is equivalent to 0..b`, `.. is equivalent to 0..^0`|int[] numbers = new[] { 0, 10, 20, 30, 40, 50 }; int amountToDrop = numbers.Length / 2; int[] rightHalf = numbers[amountToDrop..]; // 30 40 50 |
  

| Range operator expression | Description |
| --- | --- |
| `..` | All values in the collection. |
| `..end` | Values from the start to the end exclusively. |
| `start..` | Values from the start inclusively to the end. |
| `start..end` | Values from the start inclusively to the end exclusively. |
| `^start..` | Values from the start inclusively to the end counting from the end. |
| `..^end` | Values from the start to the end exclusively counting from the end. |
| `start..^end` | Values from start inclusively to end exclusively counting from the end. |
| `^start..^end` | Values from start inclusively to end exclusively both counting from the end. |  
  
  
### `sizeof(type)` 
The `sizeof()` operator returns the number of bytes occupied by a variable of a given type.

### `typeof()`
Returns the type of a class.

### `?:`
Known as the **ternary conditional operator**. evaluates a Boolean expression and returns the result of one of the two expressions, depending on whether the Boolean expression evaluates to true or false.
```cs
 condition ? expressionA : expressionB //if true => expressionA, otherwise expressionB
```
### `??` and `??=`
`??` **returns the value** of its left-hand operand if it isn't null; otherwise, it evaluates the right-hand operand and returns its result. The `??` operator doesn't evaluate its right-hand operand if the left-hand operand evaluates to non-null.
```cs
int? a = null;
Console.WriteLine((a ?? 3)); // expected: 3 since a is null 
```
`??=` **assigns the value** of its right-hand operand to its left-hand operand only if the left-hand operand evaluates to **`null`**. The `??=` operator doesn't evaluate its right-hand operand if the left-hand operand evaluates to non-null.  
  
```cs
// if a is null then assign 0 to a
a ??= 0
Console.WriteLine(a);  //0
```
  
### Lambda expressions
use a lambda expression to create an anonymous function. Use the **lambda declaration operator** `=>` to separate the lambda's parameter list from its body.

```cs
(parameters) => expression  
//or
(parameters) => { sequence-of-statements }
```
  
eg:
```cs
Func<double, double> square = static x => x * x;
```
  
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
  
### `=>`
The `=>` token is supported in two forms: as the **lambda operator** and as a separator of a member name and the member implementation in an **expression body definition**. 

### `::`
The namespace alias operator.  Use the namespace alias qualifier :: to access a member of an aliased namespace. You can use the `::` qualifier only between two identifiers. The left-hand identifier can be one of a namespace alias, an extern alias, or the global alias. 



https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/


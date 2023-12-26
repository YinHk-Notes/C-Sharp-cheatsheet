## `yield`

Use the `yield` statement in an iterator to provide the **next value or signal** the end of an iteration.

The yield statement has the two following forms:
- `yield return`: \
  to provide the next value in iteration.
  ```cs
        foreach (int i in ProduceEvenNumbers(9))
        {
            Console.Write(i);
            Console.Write(" ");
        }
        // Output: 0 2 4 6 8

        IEnumerable<int> ProduceEvenNumbers(int upto)
        {
            for (int i = 0; i <= upto; i += 2)
            {
                yield return i;
            }
        }
  ```
- `yield break`: \
  to explicitly signal the end of iteration.
  ```cs

          Console.WriteLine(string.Join(" ", TakeWhilePositive(new[] { 2, 3, 4, 5, -1, 3, 4})));
          // Output: 2 3 4 5

          Console.WriteLine(string.Join(" ", TakeWhilePositive(new[] { 9, 8, 7 })));
          // Output: 9 8 7

          IEnumerable<int> TakeWhilePositive(IEnumerable<int> numbers)
          {
                foreach (int n in numbers)
                {
                    if (n > 0)
                    {
                          yield return n;
                    }
                    else
                    {
                          yield break;
                    }
                }
           }
  ```
  

  


### ref
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/yield

https://www.codingame.com/playgrounds/5806/what-is-yield-return-in-c


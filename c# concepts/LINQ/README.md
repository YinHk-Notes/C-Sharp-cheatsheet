## Language Integrated Query (LINQ)

**Language-Integrated Query (LINQ)** is the name for a set of technologies based on the integration of query capabilities directly into the C# language. 


The complete operation includes creating a data source, defining the query expression, and executing the query in a `foreach` statement.


```cs
// Specify the data source.
int[] scores = { 97, 92, 81, 60 };

// Define the query expression.
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    select score;

// Execute the query.
foreach (int i in scoreQuery)
{
    Console.Write(i + " ");
}

// Output: 97 92 81
```

All LINQ query operations consist of three distinct actions:

1.  Obtain the data source.
    
2.  Create the query.
    
3.  Execute the query.

```cs
class IntroToLINQ
{
    static void Main()
    {
        // The Three Parts of a LINQ Query:
        // 1. Data source.
        int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

        // 2. Query creation.
        // numQuery is an IEnumerable<int>
        var numQuery =
            from num in numbers
            where (num % 2) == 0
            select num;

        // 3. Query execution.
        foreach (int num in numQuery)
        {
            Console.Write("{0,1} ", num);
        }
    }
}
```


### ref 
https://learn.microsoft.com/en-us/dotnet/csharp/linq/

https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries



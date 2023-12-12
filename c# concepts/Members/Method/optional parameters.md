## Optional parameters

Normally by default, all parameters specify in a method are required. 

But in C# 4.0, the concept of optional parameters was introduced that allows developers to declare parameters as optional.

if these arguments are not passed, they will be ommitted from the execution. Optional parameters are not mandatory.

For example, there is a method called `AddNumber(int firstNumber, int secondNumber)` which takes two parameters and returns the sum of two parameters. 
By default, it is mandatory to pass both parameter values when we call the method. However Optional Parameters allow us not to pass these values.

It can be implemented in the following ways:

1. Using Default Values
   It is the common way to implement Optional Parameters. Here we need to set the default values of the parameters in the method definition.
   ```cs
       
       namespace ConsoleApp2
       {
          public class MyDemo
          {
              public int AddNumber(int firstNumber, int secondNumber = 0)
              {
                  return firstNumber + secondNumber;
              }


              public void MainMethod()
              {
                  AddNumber(12);
              }
          }
       }
   ```

2. Using OptionalAttribute `[Optional]`

   > **Note**: But require to import **`System.Runtime.InteropServices`** namespace.
   ```cs
       using System.Runtime.InteropServices;

      namespace ConsoleApp2
      {
          public class MyDemo
          {
              public int AddNumber(int firstNumber, [Optional] int secondNumber)
              {
                  return firstNumber + secondNumber;
              }

              public void MainMethod()
              {
                  AddNumber(12);
              }
          }
      }
   ```
4. Using Method Overloading

    ```cs
        namespace ConsoleApp2
        {
            public class MyDemo
            {
                public int AddNumber(int firstNumber)
                {
                    return firstNumber;
                }

                public int AddNumber(int firstNumber, int secondNumber)
                {
                    return firstNumber + secondNumber;
                }

                public void MainMethod()
                {
                    AddNumber(12);
                    AddNumber(12, 13);
                }
            }
          }

    ```

5. Using **`Params`** Keyword \
   Using **`params`**, we can pass a number of parameters to a method and implement optional parameters concept.

   There are some restrictions using the params keyword:
   - You can only use the `params` keyword for one parameter in your method declaration.
   - `Params` **must be always the last parameter** in method.

   ```cs

       public class MyDemo
       {
          public int AddNumber(int firstNumber, params int[] numbers)
          {
             int temp = 0;
             foreach (int tempNum in numbers)
             {
                temp += tempNum;
             }
             return temp + firstNumber;
          }

          public void MainMethod()
          {
              AddNumber(12); // Result: 12
              AddNumber(12, 13); // Result: 25
              AddNumber(12, 13, 14); // Result: 39
          }
        }
   ```



### ref
https://www.c-sharpcorner.com/UploadFile/manas1/named-and-optional-parameter-in-C-Sharp/



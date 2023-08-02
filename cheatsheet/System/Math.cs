//Math
//Provides constants and static methods for trigonometric, logarithmic, and other common mathematical functions.

using System;

public static class Math

//Fields
public const double E = 2.7182818284590451;  // Represents the natural logarithmic base, specified by the constant, e.
public const double PI = 3.1415926535897931; 
public const double Tau = 6.2831853071795862; // Represents the number of radians in one turn, specified by the constant, τ.

//Methods
// ALl are static methods, no need creating object of this class. Access these methods diectly through the class

// Returns the absolute value
Math.ads(num);

// Returns the smallest integral value that is greater than or equal to the specified num
Math.Ceiling(num);

// Returns the largest integral value less than or equal to the specified number
Math.Floor(num);

// Returns value clamped to the inclusive range of min and max.
Math.Clamp(num, min, max);

// Returns a value with the magnitude of x and the sign of y.
Math.CopySign(x, y);

// Returns e raised to the specified power.
Math.Exp(num); 

// Returns the natural (base e) logarithm of a specified number
Math.Log(number);

// Returns the base 10 logarithm of a specified number.
Math.Log10(number);

// Returns the larger number in comparsion
Math.Max(num1, num2);

// Returns the smaller number in comparsion
Math.Min(num1, num2);

// Returns a specified number raised to the specified power, x^y
Math.Pow(x, y);   

// Rounds a number to the nearest integral value, and rounds midpoint values to the nearest even number.
Math.Round(num);

//Returns an integer that indicates the sign of the number
// -1	value is less than zero.
// 0	value is equal to zero.
// 1	value is greater than zero.
Math.Sign(num);

// return the integral part of a specified number(decimal or double).
Math.Truncate(num);




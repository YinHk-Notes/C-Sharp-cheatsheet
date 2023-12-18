//IComparer
//Exposes a method that compares two objects.

using System.Collections;

public interface IComparer;


//Methods

// Compares two objects and returns a value indicating whether one is less than, equal to, or greater than the other.
// A signed integer that indicates the relative values of x and y:
// - If less than 0, x is less than y.
// - If 0, x equals y.
// - If greater than 0, x is greater than y.
public int Compare (object? x, object? y);


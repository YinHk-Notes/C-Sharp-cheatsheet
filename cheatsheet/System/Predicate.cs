//Represents the method that defines a set of criteria and determines whether the specified object meets those criteria.

public delegate bool Predicate<in T>(T obj);   //obj: The object to compare against the criteria defined within the method represented by this delegate.


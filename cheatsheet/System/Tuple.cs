//Tuple
//Provides static methods for creating tuple objects.
//https://learn.microsoft.com/en-us/dotnet/api/system.tuple.create?view=net-7.0#system-tuple-create-1(-0)

using System;


public static class Tuple

public class Tuple<T1> : IComparable, System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.Runtime.CompilerServices.ITuple


//Methods
var tuple1 = Tuple.Create(item1);
var tuple2 = Tuple.Create(item1, item2);
...
var tuple8 = Tuple.Create(item1, item2, item3, item4, item5, item6, item7, item8);


or

public static Tuple<T1> Create<T1> (T1 item1);
public static Tuple<T1,T2> Create<T1,T2> (T1 item1, T2 item2);
public static Tuple<T1,T2,T3> Create<T1,T2,T3> (T1 item1, T2 item2, T3 item3);
public static Tuple<T1,T2,T3,T4> Create<T1,T2,T3,T4> (T1 item1, T2 item2, T3 item3, T4 item4);
public static Tuple<T1,T2,T3,T4,T5> Create<T1,T2,T3,T4,T5> (T1 item1, T2 item2, T3 item3, T4 item4, T5 item5);
public static Tuple<T1,T2,T3,T4,T5,T6> Create<T1,T2,T3,T4,T5,T6> (T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6);
public static Tuple<T1,T2,T3,T4,T5,T6,T7> Create<T1,T2,T3,T4,T5,T6,T7> (T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7);
public static Tuple<T1,T2,T3,T4,T5,T6,T7,Tuple<T8>> Create<T1,T2,T3,T4,T5,T6,T7,T8> (T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8);




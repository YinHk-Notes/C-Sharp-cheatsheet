//Represents a collection of key/value pairs that are organized based on the hash code of the key.
//Inheritance: Object => Hashtable
//Derived: System.Configuration.SettingsAttributeDictionary, System.Configuration.SettingsContext, System.Data.PropertyCollection, System.Printing.IndexedProperties.PrintPropertyDictionary
//Implements: ICollection, IDictionary, IEnumerable, ICloneable, IDeserializationCallback, ISerializable

using System.Collections;

public class Hashtable : ICloneable, System.Collections.IDictionary, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable

//Declare Hashtable
Hashtable ht = new Hashtable();
Hashtable ht = new Hashtable(int capacity, float loadFactor, System.Collections.IEqualityComparer? equalityComparer);
Hashtable ht = new Hashtable(int capacity, float loadFactor);


//Properties





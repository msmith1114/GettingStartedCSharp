// Object Programming
// Classes

// Defining a class
public class OurClass
{

}

// Creating an object (instance) of a class
OurClass ourObject = new OurClass();

// or the short-form method
OurClass ourObject2 = new();

// Use methods and funmctions in a class
public class OurSecondClass
{
    public void ExampleMethod()
    {
        Console.WriteLine("This is an example method");
    }

    public int ExampleFunction()
    {
        return 42;
    }
}

// let's make an instance of OurSecondClass
OurSecondClass ourSecondObject = new(); //Using short-form method
ourSecondObject.ExampleMethod(); // Calling the method

int result = ourSecondObject.ExampleFunction(); // Calling the function and storing the return value

// Console is also a class IE:
Console.WriteLine("This is a method in the console class");
/*------------------------------------------------------------------------*/
// Objects are reference types in C#
// Up until now we've been working with value types (int, string, bool, etc)
// Except for collections (array, list, etc) which are reference types

OurClass object1 = new OurClass(); // new reference
OurClass object2 = new OurClass(); // new reference
OurClass object3 = object1; // same reference as object1

Console.WriteLine("object 1 == object2:");
Console.WriteLine(object1 == object2); // false, different references
Console.WriteLine("object 1 == object3:");
Console.WriteLine(object1 == object3); // true, same reference

// Collections are the same
List<int> myNumbers1 = new List<int> { 1, 2, 3 };
List<int> myNumbers2 = new List<int> { 1, 2, 3 };

Console.WriteLine("myNumbers1 == myNumbers2:");
Console.WriteLine(myNumbers1 == myNumbers2); // false, different references

void ChangeValue(int value)
{
    value = 99; // This only changes the local copy of value
}

int myValue = 5;
Console.WriteLine($"Before ChangeValue: {myValue}");
Console.WriteLine(myValue); // 5
ChangeValue(myValue);
Console.WriteLine($"After ChangeValue: {myValue}");
Console.WriteLine(myValue); // Still 5

void ChangeReference(List<string> words)
{
    words.Add("from"); // This changes the original list because lists are reference types
    words.Add("Dev");
    words.Add("Me!");

    //words = new List<string>(); // This only changes the local copy of the reference so it's pointing to a new list
    // If this statement was ABOVE the Add methods, the original list would remain unchanged
    // since we are now pointing to a new list in the method scope

}

List<string> myWords = new List<string> { "Hello", "world" };
Console.WriteLine("Before ChangeReference:");
Console.WriteLine(string.Join(" ", myWords)); // Hello world
ChangeReference(myWords);
Console.WriteLine("After ChangeReference:");
Console.WriteLine(string.Join(" ", myWords)); // Hello world from Me!
/*------------------------------------------------------------------------*/
// Fields & Properties
// Fields are variables that belong to a class

class Person
{
    private string _name; // field (private by convention), _ is used to define a field typically

    public void SomeMe()
    {
        this._name = "John"; // this refers to the current instance of the class
    }
}

// we can also give a field a value on declaration
class Person2
{
    private string _name = "Jane"; // default value
}

// What does private mean?
// "private" is an access modifier
// We saw public before
// Private specifies that the field can only be accessed within the class it is defined in
// Generally common practice is to make fields private and use properties to access them

Person2 john = new Person2();
//john._name = "John"; // This will cause a compile error because _name is private
// We would need to use a method (getter/setter) to access or modify the field

class Person3
{
    private string _name = "Jimmy"; // field
    // Getter method to access the field
    public string GetName()
    {
        return _name;
    }
    // Setter method to modify the field
    public void SetName(string name)
    {
        _name = name;
    }
}

Person3 person3 = new Person3();
Console.WriteLine(person3.GetName()); // Jimmy
person3.SetName("Jack");
Console.WriteLine(person3.GetName()); // Jack

class Person4
{
    private string _name = "Tim";

    public string Name
    {
        get { return _name; } // Getter
    }

    public string Name2 => _name; // Expression-bodied property (read-only) Shorthand of the above

    public string Name3 { get; } = "Tom"; // Auto-property with initializer (read-only)

    public string MutableName
    {
        get { return _name; } // Getter
        set { _name = value; } // Setter
    }
}

Person4 person4 = new Person4();
//Console.WriteLine(person4._name); // Does not compile, _name is private
Console.WriteLine(person4.Name); // Tim
Console.WriteLine(person4.Name2); // Tim
Console.WriteLine(person4.Name3); // Tom

// Setting the name
Console.WriteLine("Setting the name...");
person4.MutableName = "Tony"; // Using the setter to change the name
Console.WriteLine(person4.MutableName); // Tony
// Now _name is changed to Tony
Console.WriteLine(person4.Name); // Tony
Console.WriteLine(person4.Name2); // Tony
Console.WriteLine(person4.Name3); // Tom (remains unchanged since it's read-only)
/*------------------------------------------------------------------------*/
// Static vs Instance Members
// Static is a modifier that makes a member belong to a type instead of an instance of the type

public static class MyStaticClass
{
    public static void MyStaticMethod()
    {
        Console.WriteLine("This is a static method");
    }
}

// This won't work
MyStaticClass myStaticClass = new MyStaticClass(); // Error

// static classes cannot have instance members, so anything inside must also be static
MyStaticClass.MyStaticMethod(); // Correct way to call a static method

// on non-static classes you can have both static and instance members
class MyNonStaticClass
{
    public string MyInstanceProperty { get; set; } = "Instance Property";

    public static string MyStaticProperty { get; set; } = "Static Property";

    public static void MyStaticMethod()
    {
        Console.WriteLine($"The static property value is: {MyStaticProperty}");
        //Console.WriteLine($"The instance property value is: {MyInstanceProperty}");
        // This won't work because MyInstanceProperty is not static
    }

    public void MyInstanceMethod()
    {
        Console.WriteLine($"The instance property value is: {MyInstanceProperty}");
        Console.WriteLine($"The static property value is: {MyStaticProperty}"); // This works because static members can be accessed from instance members
    }
}

MyNonStaticClass myNonStaticClass1 = new MyNonStaticClass();
MyNonStaticClass myNonStaticClass2 = new MyNonStaticClass();

Console.WriteLine("Before mutating properties on MyNonStaticClass instances:");
myNonStaticClass1.MyInstanceMethod();
myNonStaticClass2.MyInstanceMethod();
MyNonStaticClass.MyStaticMethod(); // Calling static method


// Lets mutate and see what happens
myNonStaticClass1.MyInstanceProperty = "Dev";
myNonStaticClass2.MyInstanceProperty = "Leader";
MyNonStaticClass.MyStaticProperty = "Matt!"; // Mutating static property

Console.WriteLine("After mutating properties on MyNonStaticClass instances:");
myNonStaticClass1.MyInstanceMethod(); // Prints "Dev"
myNonStaticClass2.MyInstanceMethod(); // Prints "Leader"
MyNonStaticClass.MyStaticMethod(); // Prints "Matt!"

/*------------------------------------------------------------------------*/
// Constructors

// this still has a constructor even if we don't define one an "implicit" default constructor
class ImplicitConstuctor
{

}

// a parameterless constructor is called a "default" constructor
class ExplicitConstructor
{
    public ExplicitConstructor()
    {
        Console.WriteLine("This is the explicit constructor");
    }
}
// Here is how to call it
ExplicitConstructor explicitConstructor = new ExplicitConstructor(); // Calls the constructor and will print the WriteLine

// here is one that takes a value
class ConstructorWithParameter
{
    public ConstructorWithParameter(string message)
    {
        Console.WriteLine($"This is the constructor with a parameter with the message of {message}");
    }
}

// Here is how to call it
ConstructorWithParameter constructorWithParameter = new ConstructorWithParameter("Hello from Dev!");


// this is a class with multiple constructors "chained" called constructor overloading
// together using : this() syntax
class MultipleConstructors
{
    // If we create an instance without a message it will call this constructor
    public MultipleConstructors()
        : this("This is the default message") // calls the constructor below with a default message
    {

    }
    // Or if we create an instance with a message it will call this constructor instead
    public MultipleConstructors(string message)
    {
        Console.WriteLine($"This is the constructor with a parameter with the message of {message}");
    }
}

// general we use constructors to initialize fields or properties when an object is created
class OurCollectionOfWords
{
    private List<string> _words;
    // Constructor to initialize the collection
    // Could also do:
    // private List<string> _words = new List<string>();
    // Both ways work but constructors are more flexible for complex initialization
    // And while being more verbose , are more explicit and clear in intent
    public OurCollectionOfWords()
    {
        // initialize the list when an object is created
        _words = new List<string>();
    }
    // Method to add a word to the collection
    public void AddWord(string word)
    {
        _words.Add(word);
    }
    // Method to display all words in the collection
    public void DisplayWords()
    {
        Console.WriteLine(string.Join(", ", _words));
        // or a foreach loop
        //foreach (var word in _words) { Console.WriteLine(word); }
    }
}

// Using the OurCollectionOfWords class
OurCollectionOfWords myWordsCollection = new OurCollectionOfWords();
myWordsCollection.AddWord("Hello");
myWordsCollection.AddWord("World!");
myWordsCollection.DisplayWords(); // Outputs: Hello, World!

// build on previous example with a constructor that takes an initial list of words
class OurCollectionOfWords2
{
    private List<string> _words;
    // Constructor to initialize the collection with an optional initial list of words
    public OurCollectionOfWords2(List<string>? initialWords = null)
    {
        // If initialWords is provided, use it; otherwise, initialize an empty list
        _words = initialWords ?? new List<string>();
    }
    public void AddWord(string word)
    {
        _words.Add(word);
    }
    public void DisplayWords()
    {
        Console.WriteLine(string.Join(", ", _words));
    }
}

// Using the OurCollectionOfWords2 class with initial words
OurCollectionOfWords2 myWordsCollectionWithInitial = new OurCollectionOfWords2(new List<string> { "Initial", "Words" });
myWordsCollectionWithInitial.AddWord("Added");
myWordsCollectionWithInitial.DisplayWords(); // Outputs: Initial, Words, Added
// or without initial words:
OurCollectionOfWords2 myWordsCollectionWithoutInitial = new OurCollectionOfWords2();
myWordsCollectionWithoutInitial.AddWord("Only");
myWordsCollectionWithoutInitial.AddWord("Added");
myWordsCollectionWithoutInitial.DisplayWords(); // Outputs: Only, Added

// we can have static constructors too
// will run the FIRST time the class is accessed in ANY way
class StaticConstructor
{
    static StaticConstructor()
    {
        Console.WriteLine("This is the static constructor");
    }
}

var t1 = new StaticConstructor(); // Calls the static constructor WriteLine
var t2 = new StaticConstructor(); // Does NOT call the static constructor again

// use private constructors to prevent instantiation from outside the class
class PrivateConstructor
{
    public PrivateConstructor(int value)
        : this()
    {
        Console.WriteLine($"This is the public constructor with a parameter of {value}");
    }

    private PrivateConstructor() // private constructor
    {
        Console.WriteLine("This is the private constructor, nobody can call this from outside");
    }
}

// Here is how to call it
PrivateConstructor privateConstructor = new PrivateConstructor(42); // Calls the public constructor which in turn calls the private constructor first
                                                                    // PrivateConstructor privateConstructor2 = new PrivateConstructor(); // Error, private constructor cannot be called from outside the class
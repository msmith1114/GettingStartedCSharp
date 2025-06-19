//Collections:

// Arrays
// Arrays are zero based
// Arrays are fixed in size
// We can get and Set values in an array

// Declaring an array
int[] numbers = new int[3];

// [][][] <--- Starts off blank

// Setting values in an array
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;


// Getting values from an array
int firstNumber = numbers[0];
int secondNumber = numbers[1];

// Declare and initilize an array
int[] number2 = new int[]
{
    5,
    6,
    7,
    8,
};

// Getting length of an array
int lengthNum = numbers.Length;
// Or print it like this
Console.WriteLine($"Array length of numbers is {numbers.Length}");


// Lists
// Lists are zero based
// lists are dynamic in size
// we can get/set/add/remove/insert values from a list
// we can clear a list
// we can sort a list

// Declaring a list
List<string> words = new List<string>();

// Adding values to a list (adds to end of list)
words.Add("one");
words.Add("two");
words.Add("three");

// getting values from a list (same as array)
string firstWord = words[0];
string secondWord = words[1];
string thirdWord = words[2];

// Can override a value
words[0] = "overwritten";

// declaring and initializing a list
List<int> listNumbers = new List<int>
{
    5,
    6,
    7,
    8,
};

// Getting length of a list
int count = listNumbers.Count;

// removing values (removes the specific value NOT the index
listNumbers.Remove(5);
listNumbers.Remove(6);

// inserting a value (at a specific index, moves the rest of the values down) (value, index)
listNumbers.Insert(0, 1);
listNumbers.Insert(1, 2);

// clear a list
listNumbers.Clear();

// sorting a list
words.Sort();

// Dictionaries
// dynamic in size
// store key/value pairs
// set/add/remove/clear values
// check if dictionary contains a key
// keys are unique
// values do not need to be unique
// dictionary keys do NOT need to be integers

// Declaring a dictionary
Dictionary<string, int> wordsToNumbers = new Dictionary<string, int>();
Dictionary<int, string> numberToWords = new Dictionary<int, string>();
Dictionary<string, int> shorthand = new();

// adding entries to a dictionary (key, value)
wordsToNumbers.Add("one", 1);
wordsToNumbers.Add("two", 2);
wordsToNumbers.Add("three", 3);

// Looks like this in memory
//["one"] = 1
//["two"] = 2
//["three"] = 3

// How we get values
int one = wordsToNumbers["one"];
int two = wordsToNumbers["two"];
int three = wordsToNumbers["three"];

// set values
wordsToNumbers["one"] = 111; // changes value of key "one" to 11
wordsToNumbers["two"] = 222; // changes value of key "two" to 22

// Looks like this in memory after updates
//["one"] = 111
//["two"] = 222
//["three"] = 3

// Declaring and initializing a dictionary
Dictionary<int, string> numbersToWords2 = new Dictionary<int, string>
{
    {1, "one"},
    {2, "two"},
    {3, "three"},
};

// Or using shorthand
Dictionary<string, int> wordsToNumbers2 = new()
{
    {"one", 1},
    {"two", 2},
    {"three", 3},
};

// getting count of entries in a dictionary
int countDict = numbersToWords2.Count; // countDict is 3 (pairs)

// Removing a value (by key)
numbersToWords2.Remove(1); // removes the entry with key 1
numbersToWords2.Remove(2); // removes the entry with key 2

// Now looks like this in memory
//[3] = "three"

// Clearing a dictionary
numbersToWords2.Clear(); // removes all entries

// Checking if a dictionary contains a key
bool contains = numbersToWords2.ContainsKey(3); // True

// try and get a value
bool contains2 = numbersToWords2.TryGetValue(
    3,
    out string? value); // True, value is "three"

// Error if we add something that already exists
// numbersToWords2.Add(3, "new; // Error, key 3 already exists

// We can override it like this
wordsToNumbers2["three"] = 333; // changes value of key "three" to 333
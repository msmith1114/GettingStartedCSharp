//Basic Value Types:

// String
// Declare a string variable
string myString;
string my_string;
string MyString;

// Assign a value to the string variable
myString = "Hello, World!";

// Declare and assign a string variable in one line
string coolString = "Hello, World!";

// Reassign a new value to the string variable
coolString = "Goodbye, World!";

// We can concatenate strings
string firstName = "John"; 
string lastName = "Doe";
string fullName = firstName + " " + lastName; // "John Doe"

// WriteLine the string
Console.WriteLine(fullName); // Output: John Doe

// Read a line via Console.ReadLine
myString = Console.ReadLine(); // User input will be stored in myString

// Use length to show length
Console.WriteLine(myString.Length);

// Get individual characters using index
Console.WriteLine(myString[0]); 

Console.WriteLine(myString); // Output the user input

// Declare single character variable
char myChar = 'a'; //Note '' instead of "" for single characters

Console.WriteLine(myChar); // Output: a

/*------------------------------------------------------------------------*/
// Integer
int myInt; // Declare an integer variable
int my_int; // Another way to declare an integer variable
int MyInt; // Yet another way to declare an integer variable

// We can assign a value to the integer variable    
myInt = 5;

// Declare and assign an integer variable in one line
int newInt = 10;

// We can reassign integers
myInt = 15;
// or
myInt = newInt; // myInt now equals 10

/// We can do math
int sum = 5 + 10;
int difference = 10 - 5;
int product = 5 * 10;
int quotient = 5/10; //Note: This will result in 0 because both are integers and it performs integer division

Console.WriteLine(sum); // Output: 15   
Console.WriteLine(difference); // Output: 5
Console.WriteLine(product); // Output: 50
Console.WriteLine(quotient); // Output: 0
Console.WriteLine($"Sum: {sum}, Difference: {difference}, Product: {product}, Quotient: {quotient}"); // Output: Sum: 15, Difference: 5, Product: 50, Quotient: 0
                                                                                                      // $ lets string interpolation to include variables in a string

/*------------------------------------------------------------------------*/
// Floats and Doubles (Float = 32bits/4Bytes, Double = 64bits/8Bytes)
float myFloat; // Declare a float variable  
float my_float; // Another way to declare a float variable
float MyFloat; // Yet another way to declare a float variable   

// Declare a double variable
double myDouble; // Declare a double variable
double my_double; // Another way to declare a double variable       

// Assign a value to the float variable
myFloat = 5.5f; // Note the 'f' at the end to indicate it's a float
myDouble = 10.5; // No 'f' needed for double

// Reassign a new value to the float variable
myFloat = 15.5f; // Reassigning a new value to myFloat
myDouble = 20.5; // Reassigning a new value to myDouble

// We can do math with floats and doubles   
float sumFloat = 5.5f + 10.5f;
float differenceFloat = 10.5f - 5.5f;
float productFloat = 5.5f * 10.5f;  
float quotientFloat = 5.5f / 10.5f; // Note: This will result in a float value  

// Results of our float operations
Console.WriteLine(sumFloat); // Output: 16.0    
Console.WriteLine(differenceFloat); // Output: 5.0
Console.WriteLine(productFloat); // Output: 57.75
Console.WriteLine(quotientFloat); // Output: 0.5238095

/*------------------------------------------------------------------------*/
// Boolean
bool myBool; // Declare a boolean variable
bool my_bool; // Another way to declare a boolean variable  

// Assign a value to the boolean variable
myBool = true; // Assigning true to myBool
myBool = false; // Reassigning false to myBool

// Declare and assign a boolean variable in one line
bool isTrue = true;

// Boolean operations
bool trueAndFalse = true && false; // Logical AND
bool falseAndTrue = false && true; // Logical AND
bool trueAndTrue = true && true; // Logical AND

bool trueOrFalse = true || false; // Logical OR
bool trueOrTrue = true || true; // Logical OR
bool falseOrFalse = false || false;

bool notTrue = !true; // Logical NOT
bool notFalse = !false; // Logical NOT

// Results of boolean operations with string interpolation
Console.WriteLine($"true AND false: {trueAndFalse}"); // Output: false
Console.WriteLine($"false and true: {falseAndTrue}"); // Output: false
Console.WriteLine($"true AND true: {trueAndTrue}"); // Output: true

Console.WriteLine($"true OR false: {trueOrFalse}"); // Output: true
Console.WriteLine($"true OR true: {trueOrTrue}"); // Output: true
Console.WriteLine($"false OR false: {falseOrFalse}"); // Output: false

Console.WriteLine($"NOT true: {notTrue}"); // Output: false
Console.WriteLine($"NOT false: {notFalse}"); // Output: true

/*------------------------------------------------------------------------*/
// DateTime
DateTime myDateTime; // Declare a DateTime variable

DateOnly myDateOnly; // Declare a DateOnly variable

TimeOnly myTimeOnly; // Declare a TimeOnly variable

// Assign a value to these variables
myDateTime = DateTime.Now; // Current date and time
myDateOnly = new DateOnly(2024, 1, 1); // Specific date (Year, Month, Day)
myTimeOnly = new TimeOnly(13, 30, 10); // Specific time ((24)Hour, Minute, Second)

// We can re-assign values
myDateTime = DateTime.Now; // Reassigning current date and time
myDateOnly = new DateOnly(2024, 12, 31); // Reassigning to a different date
myTimeOnly = new TimeOnly(14, 45, 0); // Reassigning to a different time


// Dealing with TimeZones
DateTime dateTimeFromCombination = new DateTime(myDateOnly, myTimeOnly); // Combine DateOnly and TimeOnly into DateTime

// Printthe values
Console.WriteLine($"DateTime: {myDateTime}"); // Output: Current date and time
Console.WriteLine($"DateOnly: {myDateOnly}"); // Output: 12/31/2024
Console.WriteLine($"TimeOnly: {myTimeOnly}"); // Output: 2:45:00 
Console.WriteLine($"Combined DateTime: {dateTimeFromCombination}"); // Output: 12/31/2024 2:45:00 PM

/*------------------------------------------------------------------------*/
// Casting and Parsing
// Casting is converting one type to another
// Parsing is converting a string to a specific type

// Impliciliy casting (widening conversion)
int castInt = 5;
double castDouble = castInt; // Implicitly casting int to double
Console.WriteLine($"Implicit cast from int to double: {castDouble}"); // Output: 5.0

// Explicitly casting (narrowing conversion)
castDouble = 5.5;
castInt = (int)castDouble; // Explicitly casting double to int
Console.WriteLine($"Explicit cast from double to int: {castDouble}"); // Output: 5

// We cannot cast a string directly to an int or double
string castString = "10";
// castInt = (int)castString; // This will cause a compile error

// We can use parsing to convert a string to an int or double
castInt = int.Parse(castString); // Parsing string to int
Console.WriteLine($"Parsed int from string: {castInt}"); // Output: 10

// And now with Doubles
castString = "10.5";
castDouble = double.Parse(castString); // Parsing string to double
Console.WriteLine($"Parsed double from string: {castDouble}"); // Output: 10.5
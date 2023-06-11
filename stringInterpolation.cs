string firstName = "Bob";
string greeting = "Hello";

string message = $"{greeting} {firstName}"; // We added to string into one in a better and easier way
Console.WriteLine(message); // This will print the concatenated variables

// We can also combine a variable and a string

string message = $"Hello {firstName}";
Console.WriteLine(message); // This will print the concatenated variable and string

// We can do this with numbers too

int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version}"; // This adds a string and an integer
Console.WriteLine(message);

// We can do this in even less lines

int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}"); // This adds the string and the integer directly into the Console.WriteLine

// C# allows us to this even with strings literals

string projectName = "First-Project";
Console.WriteLine($@"c:\Output\{projectName}\Data");
var message = "Hello, World!"; // We created a new implicit variable, here the compiler will determine the value as a string
Console.WriteLine(message); // This will print the value of the variable

message = 10.9481891m; // This will give us an error, if the value of the variable started as a string it must keep being a string

var secondMessage; // Using var you must initialize the variable giving it a value
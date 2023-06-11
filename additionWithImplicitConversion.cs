int firstNumber = 12;
int secondNumber = 7;

Console.WriteLine(firstNumber + secondNumber); // Sum of two numbers

// In the last case it worked perfectly because the compiler knew that we were trying to add two numbers
// Something different happens when we try to add numbers and string using +

string firstName = "Bob";
int widgetSold = 7;

Console.WriteLine(firstName + " sold " + widgetSold + 7 + " widgets");
//In this case the compiler doesn't add the two numbers, instead it just concatenates them
// To fix this do the following

Console.WriteLine(firstName + " sold " + (widgetSold + 7) + " widgets"); // Adding a parenthesis will tell the compiler to add the two numbers, not concatenate them


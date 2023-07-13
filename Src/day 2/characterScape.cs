Console.WriteLine("Hello\nWorld!"); // \n creates a new line
Console.WriteLine("Hello\tWorld!"); // \t creates three empty characters

Console.WriteLine("Hello "World"!"); // This is an error, to add double quotes on the string you want to display do the following

Console.WriteLine("Hello \"World\"!"); // This will add double quotes on the string you want to display

// If you want to display a \, make sure that in your string you add "\\", if you don't do this the compiler will fail, look at the example below
Console.WriteLine("c:\\source\\repos");

// Prototype of the problem, if you want to know more about the problem go to https://learn.microsoft.com/es-mx/training/modules/csharp-basic-formatting/2-exercise-character-escape-sequences
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

// String literal, this will save all of the blank spaces without the need to use a "\", to make this use @
// Console.WriteLine(@"    c:\source\repos\
//         (This is where your code goes)");

Console.Write(@"c:\invoices");

// Unicode characters
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u3068\u3061\u306F World");

// To generate Japanese invoices and complete the problem do the following using Unicode characters
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3082\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");
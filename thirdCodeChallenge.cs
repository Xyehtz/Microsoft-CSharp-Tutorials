string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string englishMessage = "View English output";

Console.Write($"{englishMessage}\n\t");
Console.WriteLine($@"c:\Exercise\{projectName}\data.txt");

Console.Write($"\n{russianMessage}\n\t");
Console.WriteLine($@"c:\Exercise\{projectName}\ru-RU\data.txt");
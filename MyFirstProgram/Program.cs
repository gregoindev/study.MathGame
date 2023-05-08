//int index = 1;
//string name = "Grego";
//char initial = 'G';
//int year = 1993;
//decimal height = 1.8035m;
//bool doesLoveCode = true;



//Console.WriteLine("These are the most common data types:");
//Console.WriteLine(@$"
//1 - string - {name}
//2 - char - {initial}
//3 - int - {year}
//4 - decimal - {height}
//5 - bool - {doesLoveCode}
//");

//Console.WriteLine();

Console.WriteLine("Please type your name:");

var name = Console.ReadLine();
var date = DateTime.UtcNow;

Console.WriteLine("---------------------------");

Console.WriteLine($"Hello, {name.ToUpper()}. It's {date.DayOfWeek}. This is your math game. Enjoy!");
Console.WriteLine(@$"What game mode would you like to play? Choose from the options:\n
A - Addition
S - Subtraction
M - Multiplication 
D - Division
Q - Quit the program");

Console.WriteLine("---------------------------");

var gameSelected = Console.ReadLine();

if (gameSelected.Trim().ToLower() == "a")
{
    AdditionGame("Addition game selected");
}
else if (gameSelected.Trim().ToLower() == "s")
{
    SubtractionGame("Subtraction game selected");
}
else if (gameSelected.Trim().ToLower() == "m")
{
    MultiplicationGame("Multiplication game selected");
}
else if (gameSelected.Trim().ToLower() == "d")
{
    DivisionGame("Division game selected");
}
else if (gameSelected.Trim().ToLower() == "q")
{
    Console.WriteLine("Goodbye");
    Environment.Exit(1);
}
else {
    Console.WriteLine("Invalid input");
}

void DivisionGame(string message)
{
    Console.WriteLine(message);
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);
}

void AdditionGame(string message) {
    Console.WriteLine(message);
}
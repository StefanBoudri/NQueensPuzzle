using NQueenPuzzle;

Console.WriteLine("This is the n queens puzzle. For n is the chessboard n*n and n is the amount of queens.");
Console.WriteLine("what do you want n to be?");
string input = Console.ReadLine();

int n = int.Parse(input);

Puzzle _ = new(n);
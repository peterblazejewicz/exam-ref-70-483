public delegate int Calculate(int x, int y);
Calculate calc = (x, y) => x + y;
Console.WriteLine(calc(3, 4)); // Displays 7
calc = (x, y) => x * y;
Console.WriteLine(calc(3, 4)); // Displays 12

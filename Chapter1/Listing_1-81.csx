Func<int, int, int> func = (x, y) => x + y;

Action<int, int> action = (x, y) =>
{
    Console.WriteLine(x + y);
};
Console.WriteLine(func(3, 4)); // Displays 7
action(3, 4); // Displays 7

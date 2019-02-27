public delegate int Calculate(int x, int y);
Calculate calc =
    (x, y) =>
    {
        Console.WriteLine("Adding numbers");
        return x + y;
};
int result = calc(3, 4);
// Displays
// Adding numbers

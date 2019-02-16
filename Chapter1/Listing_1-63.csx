int i = 1;
switch (i)
{
    case 1:
        Console.WriteLine("Case 1");
        goto case 2;
    case 2:
        Console.WriteLine("Case 2");
        break;
}
// Displays
// Case 1
// Case 2

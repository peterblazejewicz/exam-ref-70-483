int[] values = { 1, 2, 3, 4, 5, 6 };
for (int index = 0; index < values.Length; index++)
{
    if (values[index] == 4) continue;
    Console.Write(values[index]);
}
// Displays
// 12356

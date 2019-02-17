public void MethodOne()
{
    Console.WriteLine("MethodOne");
}
public void MethodTwo()
{
    Console.WriteLine("MethodTwo");
}
public delegate void Del();
public void Multicast()
{
    Del d = MethodOne;
    d += MethodTwo;
    d();
}
// Displays
// MethodOne
// MethodTwo
Multicast();

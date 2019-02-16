bool x = true;
bool y = true;
void F() { Console.WriteLine("F"); }
void G() { Console.WriteLine("G"); }

if (x)
{
    if (y)
    {
        F();
    }
    else
    {
        G();
    }
}

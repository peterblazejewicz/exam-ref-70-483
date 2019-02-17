class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

var people = new List<Person>
    {
        new Person() { FirstName = "John", LastName = "Doe"},
        new Person() { FirstName = "Jane", LastName = "Doe"},
    };

List<Person>.Enumerator e = people.GetEnumerator();
try
{
    Person v;
    while (e.MoveNext())
    {
        v = e.Current;
    }
}
finally
{
    System.IDisposable d = e as System.IDisposable;
    if (d != null) d.Dispose();
}

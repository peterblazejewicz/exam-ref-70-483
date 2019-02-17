class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
void CannotChangeForeachIterationVariable()
{
    var people = new List<Person>
    {
        new Person() { FirstName = "John", LastName = "Doe"},
        new Person() { FirstName = "Jane", LastName = "Doe"},
    };
    foreach (Person p in people)
    {
        p.LastName = "Changed"; // This is allowed
        // p = new Person(); // This gives a compile error
    }
}

// CannotChangeForeachIterationVariable();

void DoSomething(TextWriter tw) { }
public delegate void ContravarianceDel(StreamWriter tw);
ContravarianceDel del = DoSomething;

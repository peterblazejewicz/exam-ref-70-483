public delegate TextWriter CovarianceDel();
public StreamWriter MethodStream() { return null; }
public StringWriter MethodString() { return null; }
CovarianceDel del;
del = MethodStream;
del = MethodString;

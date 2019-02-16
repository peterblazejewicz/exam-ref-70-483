# exam-ref-70-483

A set of C# snippets and sample code authored VSCode (so should be compatible with IDEA/VS) for MS 70-483 exam

## Sample code

All the code has been created using `dotnet` CLI tool and shuld be able to run either from any IDE or console directly

### Scripting support

Some of the listing code are writtine using C# Scripting support and they are saved directly as listing files with `.csx` extension.

In order to use C# Scripting on your machine you need to first install CI support for them:

```bash
dotnet tool install -g dotnet-script
```

To execute any of `.csx` files from command line:

```bash
dotnet script Chapter1/Listing_1-46.csx
```

### Running

To run sample listing code directly from the solution root:

```bash
dotnet run --project Chapter1/Listing_1-4
```

or switch into code directory and run directly:

```bash
cd Chapter1/Listing_1-4
dotnet run
```

### Adding a new project to existing solution

In order to create a new project and add it to solution file:

- create a new project using one of the existing `dotnet` templates:

```bash
dotnet new console -n Listing_1-33 -o Chapter1/Listing_1-33
The template "Console Application" was created successfully.

Processing post-creation actions...
Running `dotnet restore` on Chapter1/Listing_1-33/Listing_1-33.csproj...
  Restoring packages for /Users/piotrblazejewicz/git/exam-ref-70-483/Chapter1/Listing_1-33/Listing_1-33.csproj...
  Generating MSBuild file /Users/piotrblazejewicz/git/exam-ref-70-483/Chapter1/Listing_1-33/obj/Listing_1-33.csproj.nuget.g.props.
  Generating MSBuild file /Users/piotrblazejewicz/git/exam-ref-70-483/Chapter1/Listing_1-33/obj/Listing_1-33.csproj.nuget.g.targets.
  Restore completed in 253.18 ms for /Users/piotrblazejewicz/git/exam-ref-70-483/Chapter1/Listing_1-33/Listing_1-33.csproj.

Restore succeeded.
```

- add reference to newly created project into solution:

```bash
dotnet sln add Chapter1/Listing_1-33
Project `Chapter1/Listing_1-33/Listing_1-33.csproj` added to the solution.
````

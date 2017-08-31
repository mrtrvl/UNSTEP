# UNSTEP

[![Join the chat at https://gitter.im/UNSTEP/Lobby](https://badges.gitter.im/UNSTEP/Lobby.svg)](https://gitter.im/UNSTEP/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)  

[UN]ified [ST]ud[E]nt [P]ortal is one-stop shop for students to acquire all needed information, on all platforms and with any* device. From curriculum and timetables to course materials, assigned homework, due-dates, upcoming events and everything else.  

This project is brought to life as part of my **final college project** and I envision this _README_ to contain many notes, code snippets, thoughts, decisions and so on to base **my dissertation on**. Since this is a educational project, I'll always try to keep couple of issues open with `help wanted` tag of  various difficulty levels, to encourage fellow companions to jump into world of open source development with a warm welcome : )  

## List of used tools, platforms, libraries and more
C#
.NET Core 2.0  
Visual Studio 2017  
xUnit

## Coding practices and learnings I aspire to follow
- Use properties instead of fields: [Link][properties-vs-public-variables] 

### Create consistent objects 
Each and every object should start off in a complete and consistent state! 
- Define one factory function per class  
- Have no discrete parameters (no enums, booleans etc)

> "If you have an object, then it's fine" - Zoran Horvat
```csharp

private bool HasDegree { get; } // have no flags

private Teacher(bool hasDegree) 
{
   this.HasDegree = degree;
}

// If you have more than one factory function then this class is probably doing too much
public static Teacher Create() =>
    new Teacher(false);

public static Teacher CreateWithDegree() =>
    new Teacher(true);

public void CalculateSalary() 
{
    if (hasDegree) // this changes execution flow, but it is not immediately clear for the caller
    {
        // Pay more
    }
    else 
    {
        // Pay less
    }
}
```

### Avoid primitive types
Enumerations are root of all evil, because they must be guarded and is just a bomb waiting to blow up. Use a classes* with necessary factory functions instead.

\* Some edge cases: 
* Serialization requires primitive types. 
* ORM's, because they support enums natively and plain integers will be stored in database instead.

> Use enums only when situation requires, not because it is easy thing to do. 

```csharp
enum Day // just a syntatic shugar over :int
{
    Monday, // defaults to 0 if not specified explicitly
    Tuesday,
    Wednesday
    ...
}

public void DoSomething(Day day) // enum assignement verification is not done
{
    if (Enum.IsDefined(typeof(Day), day))
    {
        // do something
    }
    else 
    {
        // do something else????
    }
}
```

### CQRS - Command-Query Segregation Principle
Command (Model):  
   * Modifies the system state
   * Applies all the rules
   * Performs all the validations

Query (View Model):
   * Do not modify any system state
   * No rule checking 

### Exceptions
**Only catch an exception you can handle**

<!-- All referenced links  -->
[properties-vs-public-variables]: https://blog.codinghorror.com/properties-vs-public-variables/
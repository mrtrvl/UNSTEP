# UNSTEP

[![Join the chat at https://gitter.im/UNSTEP/Lobby](https://badges.gitter.im/UNSTEP/Lobby.svg)](https://gitter.im/UNSTEP/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)  

[UN]ified [ST]ud[E]nt [P]ortal is one-stop shop for students to acquire all needed information, on all platforms and with any* device. From curriculum and timetables to course materials, assigned homework, due-dates, upcoming events and everything else.  

This project is brought to life as part of my **final college project** and I envision this _README_ to contain many notes, code snippets, thoughts, decisions and so on to base **my dissertation on**. Since this is a educational project, I'll always try to keep couple of issues open with `help wanted` tag of  various difficulty levels, to encourage fellow companions to jump into world of open source development with a warm welcome : )  

**DISCLAIMER:**   
This is a side project as a way to explore new stacks, deployment approaches and is not bound to any pragmatic concerns. It is over-engineered specifically for a reason so that I could learn from mistakes of over-engineering, and to identify what actually worked or didn't work! Let's [shave that Yak](http://sethgodin.typepad.com/seths_blog/2005/03/dont_shave_that.html)


## Glossary
**Schedule** - A period of time which contains list of items   
**Course** - Degree or diploma program  
**Subject** - One unit of study which one can enroll as part of the course  
**Lecture** - One unit of study which is part of the subject

## List of used tools, platforms, libraries and more
C#
.NET Core 2.0  
Visual Studio 2017  
xUnit

## Coding practices and learnings I aspire to follow
- Use properties instead of fields: [Link][properties-vs-public-variables] 
- Comments should tell **why** something is being done. The code already tells what is being done. Comment the code with a higher-level view of what the code aims to ultimately achieve, with pre- and post- conditions. You need to comment on (say) peculiar implementations or checks that are necessary yet counter-intuitive, and possibly reference specification documents etc

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
Method should either modify state, or return a value, but not both!

```csharp
public void DoSomething() 
{
    // modifies state, no returning result alloved
}
```
```csharp
public IResult GetResult() 
{
    // no changes to the state allowed. Only get the result. 
}
```

Command (Model):  
   * Modifies the system state
   * Applies all the rules
   * Performs all the validations

Query (View Model):
   * Do not modify any system state
   * No rule checking 

### Exceptions
Exceptions should be used only in exceptional cases. If there is a way to recover from, or expect an exception, then it is not really an exceptional case.

>"Only catch an exception you can handle and avoid rethrowing the same exception. Caller might forget to catch an exception, but it is highly unlikely for a caller to forget to **use the returned object** it asked for" - Zoran Horvat  

Return type of a method should grasp both positive and negative outcomes.

#### Either
Either type comes from functional languages which contains two components, one indicating success, other failure. Consumer doesn't know what Either type will contain, but it must provide strategy for both scenarios either way. 

This goes over my head at the moment of writing, but I'll include this in the code with every intention to find a suitable place to see this through in the practice. 

Anyway, thanks for Zoran Horvat from Pluralsight (course)[advanced-defensive-programming-techniques] to blow my mind.. 

```csharp
Uri address = new Uri("https://something.out.there");
Either<Failed, Resource> result = Fetch(address);

string report = result
     .MapLeft(failure => $"Error fetching the resource - {failure}")
     .Reduce(resource => resource.Data);

Console.WriteLine(report);

```
<!-- All referenced links  -->
[properties-vs-public-variables]: https://blog.codinghorror.com/properties-vs-public-variables/

[advanced-defensive-programming-techniques]:(https://app.pluralsight.com/library/courses/advanced-defensive-programming-techniques/table-of-contents)
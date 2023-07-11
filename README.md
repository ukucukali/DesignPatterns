# Design Principles
## SOLID

### Single Responsibility Principle

+ Aim to make every class do only one job
+ Responsibility should be encapsulated by the class
+ Goal is to reduce complexity.
+ Lack of this principle can cause maintability issues because program will grow day by day and it will create finding things in the solution.
+ Any changes in classes risk to affect other parts of code even you aren't intend to do.

### Open/Closed Principle

+ Aim to while adding new features to code keep  existing code working
+ When you describe this principle there is very common description is that "Class­es should be open for exten­sion but closed for modification."
+ Open: class can be extended as subclass and use it whereever you needed.
+ Closed: when class is %100 percent ready to use by other classes and interface won't change in the future
+ To sum up class should be open for extention and close to be modification at the same time.


### Liskov Substitution Principle

+ Aim to generete as general as possible structures to use for wide purposes.
+ Subclasses should be compatible with the behavior of the super class.
+ Be able to overide superclasses method rather than replacing it with something entirely
+ It is most importantant in libraries and framework which are you don't have direct access to those code and change it.
+ Super class should be as general as possible. For example if there is method play() it should take instead of specific quitar class, it should take abstract instrument class to be able to reuse play methot with other instruments class which reproduced from instrument abstract class.
+ Methods return types should be matching.
+ Exception types should match with base class exception declarations.
+ if subclass changes logic or even one paramater's type behavior of a base class then it will affect its behavior and it starts to crush.

### Interface Segregation Principle

+ Aim to make interfaces well separated enough that dependent classes don't have to implement behaviour they don't need.
+ Instead of making packed and big interfaces, interfaces shoud be created more spesific and smaller because aim is that classes should implement only those methods that they are really need.
+ Making big interfaces can cause code break in classes where those unused methods even not used.
+ Classes can inherite only one super class but for interfaces there are no limits.


### Dependency Inversion Principle

+ Low-level classes do basic operations database connections, data flows etc.
+ High-level classes do complex jobs and direct low-level classes for those jobs.
+ High level classes should not depend on low-level classes. They should depend to their abstract classes.
+ This problem occures because usually low-level classes created first
---
## Pillars of OOP

### Abstraction
### Encapsulation
### Polymorphsim
### Inheritance

---

## Design Patterns

### Creational Design Patterns

Aim to increase flexibility and reuse of the existing code.

+ #### Factory Method


+ #### Abstract Factory

+ #### Builder

+ #### Prototype

+ #### Singleton

### Structural Design Patterns

+ #### Adapter

+ #### Bridge

+ #### Composite

+ #### Decorator

+ #### Facade

+ #### Flyweight

+ #### Proxy


### Behavioral Design Patterns

+ #### Chain of Responsibility

+ #### Command

+ #### Composite

+ #### Iterator

+ #### Mediator

+ #### Memento

+ #### Observer

+ #### State

+ #### Strategy

+ #### Template Method

+ #### Visitor


---

>### References
> +  Alexander Shvets - Dive Into Design Patterns
> +  Robert Martin - Agile Software Development, Principles, Patterns, and Practices

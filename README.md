# Design Principles

## SOLID

### Single Responsibility Principle

+ Aim to make every class do only one job.
+ Responsibility should be encapsulated by the class.
+ Goal is to reduce complexity.
+ Lack of this principle can cause maintainability issues because program will grow day by day and it will make find things difficult in the solution.
+ Any changes in classes risk to affect other parts of code even you aren't intended to do.

### Open/Closed Principle

+ Aim to while adding new features to code, keep existing code working.
+ When you describe this principle there is very common description is that "Classes should be open for extension but closed for modification."
+ Open: class can be extended as subclass and use it wherever you needed.
+ Closed: when class is 100 percent ready to use by other classes and interface won't change in the future.
+ To sum up class should be open for extension and close to be modification at the same time.

### Liskov Substitution Principle

+ Aim to generate as general as possible structures to use for wide purposes.
+ Subclasses should be compatible with the behavior of the super class.
+ Be able to override super classes method rather than replacing it with something entirely.
+ It is most important in libraries and framework which are you don't have direct access to those code and change it.
+ Super class should be as general as possible. For example, if there is method play () it should take instead of specific guitar class, it should take abstract instrument class to be able to reuse play method with other instruments class which reproduced from instrument abstract class.
+ Methods return types should be matching.
+ Exception types should match with base class exception declarations.
+ if subclass changes logic or even one parameter's type behavior of a base class then it will affect its behavior and it starts to crush.

### Interface Segregation Principle

+ Aim to make interfaces well separated enough that dependent classes don't have to implement behaviour they don't need.
+ Instead of making packed and big interfaces, interfaces should be created more specific and smaller because aim is that classes should implement only those methods that they are really need.
+ Making big interfaces can cause code break in classes where those unused methods even not used.
+ Classes can inherit only one super class but for interfaces there are no limits.

### Dependency Inversion Principle

+ Low-level classes do basic operations database connections, data flows etc.
+ High-level classes do complex jobs and direct low-level classes for those jobs.
+ High level classes should not depend on low-level classes. They should depend to their abstract classes.
+ This problem occurs because usually low-level classes created first.

---

## Pillars of OOP

### Abstraction

+ Abstraction involves creating abstract classes and interfaces to define the structure and behavior of objects without providing a complete implementation for their individual characteristics.
+ It allows you to represent real-world entities and their interactions in a simplified and more manageable way, so it makes code more maintainable, extensible, and easier to manage.

### Encapsulation

+ Main goal to control an object to hide parts of its state and behaviors from other objects, exposing only a limited interface to the rest of the program.
+ Private and protected keywords are used to restrict fully or partially accesses to fields or methods.
+ Interfaces are contracts about interaction between objects. That is why interfaces only care about behaviours of object so fields cannot be declared in the interfaces or protocols.

### Polymorphism

+ Main goal to enable code to be more generic, flexible, and extensible.
+ Polymorphism is closely related to inheritance. It occurs when a derived class inherits from a base class, and objects of the derived class can be used wherever objects of the base class are expected.
+ It promotes code reusability, simplification, and maintenance.
+ Treating objects of different classes as objects of a common base class, polymorphism simplifies code design and makes it easier to work with diverse types of objects in a unified manner.
+ It allows to override methods that already defined in its base class.
+ There are two types of polymorphism, compile-time polymorphism (static polymorphism) and run-time polymorphism (dynamic polymorphism).
  + Compile-time polymorphism (static polymorphism) is resolved at compile time and is achieved through method overloading. Method overloading allows multiple methods with the same name but different parameters to coexist in the same class.
  + Run-time polymorphism (Dynamic Polymorphism) is resolved at runtime and is achieved through method overriding. Method overriding occurs when a derived class provides its specific implementation of a method that is already defined in the base class.

### Inheritance

+ Main benefit of inheritance is code reuse.
+ It is applied when there is a need for another class with slightly different from the existing one.
+ Main goal is prioritize code reuse by extending existing classes and adding new functionality through inheritance of fields and methods of the superclass.

---

## Design Patterns
+ Design patterns are typical solutions to commonly occurring problems in software design.
+ They are not specific codes, but they are general concepts for solving a specific problem.
+ If pattern only applicable in one language is called "idioms", if can be implemented in various languages is called "architectural patterns".

### Creational Design Patterns

Aim to increase flexibility and reuse of the existing code.

+ #### Factory

  + Factory pattern intent to define an interface for creating objects, but it lets subclasses decide which class to instantiate.
  This promotes flexibility, as it allows for easy extension and customization of the object creation process.
  + The code that uses the factory pattern (client code) sees no difference between classes so it returns actual products from various subclasses.
    Because for the client it is important that the client will get same products and methods as actual class contains, but not what those products returned or how those methods work internally.
  + This pattern promotes loose coupling by allowing the code to depend on abstractions instead of concrete implementations.
  + This design improves modularity, adheres to principles like abstraction and encapsulation, and promotes code reusability and maintainability.
  
  ##### Applicability
  + Use the Factory when you want to;
    + Provide users of your library or framework with a way to extend its internal components.
    + Save system resources by reusing existing objects instead of rebuilding them each time.
    + Can be used when there are many similar components bind with same interface and additional components can be added in future.

+ #### Abstract Factory

  + Abstract Factory pattern intent to create families of related objects while ensuring that the objects are compatible and can work together.
  + The code that uses the abstract factory design be sure that all the created product will be compatible with each other.
  + This pattern promotes loose coupling by allowing the code to depend on abstractions instead of concrete implementations.
  + Consider implementing the Abstract Factory when you have a class with a set of Factory Methods that blur its primary responsibility.

  ##### Applicability
  + Use the Abstract Factory pattern when you want to;
    + System needs to be independent of how its objects are created, composed, and represented.
    + Can be used when there are many related products with similar component types bound with same interface and additional product can be added in future.

+ #### Builder

  + Builder pattern intent to create complex object step by step and it allows to produce different types of an object using same construction code.
  + It keeps objects hidden until they are correctly created, so it prevents to get incomplete results.

  ##### Applicability
  + Use the Builder pattern when you want to;
    + Eliminate too much overloaded constructors and build objects step by step, using only those steps that you really need.
    + Create different representations of some product which contains similar steps that differ only in the details.
    + Construct composite trees or other complex objects

+ #### Prototype
  + Prototype pattern intent to let copy existing objects without making any code dependent on their classes.
  + Also this pattern delegates the cloning process to the actual objects that are being cloned.
  + The pattern declares a common interface for all objects that support cloning. This interface lets you clone an object without coupling your code to the class of that object.
  + It allows to clone objects without coupling their concrete classes.It allows produce complex objects more conveniently.
  + It can be count as alternative to inheritance when dealing with configuration presets for complex objects.
      
  ##### Applicability
  + Use the Prototype pattern when;
    + Used code does not need to depend on the concrete classes of object that be copied.
    + there is a need to reduce the number of subclasses thar only differ in the way they initialize their respective objects.

+ #### Singleton
  + Singleton pattern ensures that a class has only one instance, while providing a global access point to this instance.
  + Ensure that a class has only one instance but at the same time violates the Single Responsibility Principle.
  + It allows us to control access to shared resources such as database or a file.
  + It allows you to access instance of an object from anywhere in the program but at the same time it protects that instance from being overwritten by another code.

  ##### Applicability
    + Use the Singleton pattern when;
      + A class in your program should have just a single instance available to all clients.
      + You need stricter control over global variables.

### Structural Design Patterns

Aim to explain how to assemble objects and classes into larger structures, while keeping these structures flexible and efficient.

+ #### Adapter
  +  Adapter pattern allows objects with incompatible interfaces to collaborate.
  +  It can convert data one way or both ways.
  +  Adapter is a class that can work with both client and service.
  +  Adapter types can be divided as:
      + Object Adapter
          + It implements one interface of an object while wraps other one.
          + All the calls go through adapter interfaces, and it translates them into wrapped service object format.
          + It can be implemented in all popular programming languages.
      + Class Adapter
          + It inherits interfaces from both objects at the same time.
          + There is no need for wrapping object, because it inherits both interface behaviors from both the client and the service.
          + The adaptation happens within the overridden methods so adapter class can be used as client class.
          + It can be implemented in programming languages that support multiple inheritance, such as C#.

  ##### Applicability
  + Use the Adapter pattern when;
      + You want to use existing class, but its interface isn't compatible with rest of your code.
      + You want to reuse several existing subclasses that lack some common functionality that can`t be added to superclass.

  ##### Benefits
  + Compatibility enables integration between incompatible interfaces.
  + Flexibility allows independent development and modification of both the legacy application and the new library.
  + Reusability the adapter can be reused with any other client requiring the target interface.

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

+ #### Template

+ #### Visitor

---

>### References
> +  Alexander Shvets - Dive Into Design Patterns
> +  Robert Martin - Agile Software Development, Principles, Patterns, and Practices
> +  Internet Searches
# C# Design Patterns


## Strategy Pattern

A **strategy** pattern is a **Behavioral** design pattern. Its main intent is to define a family of algorithms, encapsulate each one so that they are easily interchangeable. This allows the algorithm to vary independently of the client using the algorithm.


## Factory Pattern

<img src="/pictures/factory.png" title="factory"  width="800">


## Abstract Factory Pattern

**Abstract Factory** is a **creational** design pattern. The main intent of the pattern is to allow abstraction over other factory classes.

<img src="/pictures/abstract_factory.png" title="abstract factory"  width="800">


## Prototype Pattern

The **Prototype** design pattern is one of the **creational** design patterns. It is very useful in scenarios where the creation of an object can become expensive.

<img src="/pictures/prototype.png" title="prototype"  width="800">


## Builder Pattern

The **Builder** design pattern is one of the **creational** design patterns. It is used in scenarios where the creation of an object becomes complex. You want to keep the **immutability** of an object and at the same time, be able to create the object with different set of attributes on different kinds of scenarios.

<img src="/pictures/builder.png" title="builder"  width="800">


## Decorator Pattern

The **decorator** pattern is a structural design pattern. The main intent of the pattern is to attach additional responsibility to an object dynamically. It is an alternative to subclassing. It solves the problem of adding functionalities to a class without adding concrete changes to that class.

<img src="/pictures/decorator.png" title="decorator"  width="800">


## Facade Pattern

The **facade** pattern is a **structural** design pattern. The main intent of the pattern is to provide a unified interface instead of exposing a set of interfaces in a subsystem. Facade defines a high-level interface that makes the underlying services easier to use.


## Flyweight Pattern

The **flyweight** design pattern is a **structural** design pattern. The main intent of this design pattern is to use sharing to support large number of fine grained objects efficiently.

<img src="/pictures/flyweight.png" title="flyweight"  width="800">
<img src="/pictures/flyweight2.png" title="flyweight"  width="800">


## Chain Of Responsibility

The **Chain of Responsibility** pattern is a **Behavioral** design pattern. The main intent of the pattern is to avoid coupling between the sender of a request and its receiver by giving more than one object a chance to handle the request.


## Iterator

**Iterator** pattern is a **Behavioral** design pattern. The main intent of the pattern is to provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.


## Observer

The **observer** pattern is a **Behavioral** design pattern. The main intent of the pattern is to define a one-to-many dependency between objects so that when one object changes its state, all objects dependent on it are notified automatically.

<img src="/pictures/observer.png" title="observer"  width="500">


## Adapter

The **adapter** pattern is a **structural** design pattern. The main intent of the pattern is to allow two classes to work together which will not otherwise be due to incompatible contracts.

<img src="/pictures/adapter.png" title="adapter"  width="800">


## Bridge

The **bridge** pattern is a **structural** design pattern. The main intent of the pattern is to decouple an abstraction from its implementation so that they can vary independently. When using the SOLID design patterns properly, you will probably end up implementing bridge "out of the box".


## Visitor

The **visitor** pattern is a **Behavioral** design pattern. The main intent of the pattern is to represent an operation to be performed on the elements of an object structure. Visitor lets us define a new operation without changing the classes of the elements on which it operates.


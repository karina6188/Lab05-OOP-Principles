# Lab05-OOP-Principles

## About This Program
Zoo

Author: Karina Chen

## Description
This is a C# console application that 

## Getting Started
Clone this repository to your local machine.

$ git clone [https://github.com/karina6188/Lab05-OOP-Principles.git]

To run the program from Visual Studio:
Select File -> Open -> Project/Solution

Next navigate to the location you cloned the Repository.

Double click on the Lab05-OOP-Principles directory.

Then select and open lab05-oop-principles.

## To Run This Program
Open the program using Visual Studio and click "Start" button to run this program.

## Visuals

Unified Modeling Language

This drawing illustrates the inheritance layers of each class and their properties and methods. 

![Alt execution capture](/captures/UML2.JPG)

Application Execution

![Alt execution capture](/captures/app_execution2.JPG)

## Technical Documentation
Object-Oriented Programming Principles:

### Abstraction
Abstraction is used to carry information (methods, properties,...) to other classes that other classes can then redefine the information to fit their various features to make it more specific to each class.

Example:
Animal class is an abstract class that carries the IsInZoo properties to its child classes.

### Encapsulation
Encapsulation means to group related things together that contains functions and variables.

Example:
The constructor method for class Mammal.

### Inheritance
Inheritance allows you to extend the information from a parent class to a child class. Then in the child class, you can make modifications without changing the original file.

Example:
Class Salmon inherits from class Fish, so class Salmon inherits properties and methods from its parent class and also from the ancestors' classes.

### Polymorphism
Polymorphism allows you to link classes with other classes, and the classes can still functions as their original classes even when they are assigned as other classes.

Example:
Mammal tiger = new Tiger(520, 9);
tiger.Sleep();

The method Sleep() is from class Animal which is a parent class of class Mammal which is a parent class of Tiger.
Polymorphism allows you to make a new instance Tiger as a type Mammel, and allows you to call the Sleep() method from Animal class.

### Interfaces
Interfaces allows you to include behaviors from multiple sources in a class. In C#, since a class can only inherit from one class, interfaces can be used to include more functions to a class without "inheriting" from it.
There are two interfaces in this program, IFeed and IWater. IFeed is implemented to class Mammal and Fish, and IWater is implemented to class Mammal and Bird.

Example:
salmon.FeedFood();
tiger.FeedFood();
eagle.GiveWater();

These codes can be run successfully because their parent class (Fish, Bird, and Mammal) implement interfaces IFeed and IWater.

## Change Log

1.1: Set up the program and added classes into the program. - 2019 Oct 21

1.2: Add properties and methods to each class. - 2019 Oct 21

1.3: Fix bugs and override virtual properties. - 2019 Oct 21

1.4: Add unit testing to test if all the classes can run functions from their inherited classes. Pass all tests. - 2019 Oct 21

1.5: Add two interfaces to classes. - 2019 Oct 22

1.6: Add more unit testing to test interfaces. - 2019 Oct 22

1.7: Fix bugs and the program is completed. - 2019 Oct 22
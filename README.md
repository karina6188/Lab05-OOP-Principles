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

![Alt execution capture](/captures/UML.JPG)

Application Execution

![Alt execution capture](/captures/app_execution.JPG)

## Technical Documentation
Object-Oriented Programming Principles:

Abstraction
Abstraction is used to carry information (methods, properties,...) to other classes that other classes can then redefine the information to fit their various features to make it more specific to each class.

Example:
Animal class is an abstract class that carries the IsInZoo properties to its child classes.

Encapsulation
Encapsulation means to group related things together that contains functions and variables.

Example:
The constructor method for class Mammal.

Inheritance
Inheritance allows you to extend the information from a parent class to a child class. Then in the child class, you can make modifications without changing the original file.

Example:
Class Salmon inherits from class Fish, so class Salmon inherits properties and methods from its parent class and also from the ancestors' classes.

Polymorphism
Polymorphism allows you to link classes with other classes, and the classes can still functions as their original classes even when they are assigned as other classes.

Example:
Mammal tiger = new Tiger(520, 9);
tiger.Sleep();

The method Sleep() is from class Animal which is a parent class of class Mammal which is a parent class of Tiger.
Polymorphism allows you to make a new instance Tiger as a type Mammel, and allows you to call the Sleep() method from Animal class.

## Change Log

1.1: Set up the program and added classes into the program. - 2019 Oct 21

1.2: Add properties and methods to each class. - 2019 Oct 21

1.3: Fix bugs and override virtual properties. - 2019 Oct 21

1.4: Add unit testing and passes all tests. - 2019 Oct 21

1.5: Add two interfaces to classes. - 2019 Oct 22

1.6: 
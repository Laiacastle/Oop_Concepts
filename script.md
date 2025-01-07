# Index

What is an object?	

Create object	

Constructor	

Instances	

Inheritance and polimorf	

Inheritance	

Polimorf	

Encapsulation	

Access and non access modifiers	

Types of relations	

Types	


# SCENARIO

## What is an object?
An object is a representation of an entity (object) in real life; As a desk, a mouse, etc.
In IT the objects are represented by classes.
A class is a "blueprint" that defines the characteristics and behaviors of the object.
For exemple, the attributes of  a mouse can be a color, a brand, etc,  and one behavior can click.

### Create class
First we need to have our class declared as we did before. There are multiple form of declare a class, we are doing the C# type.
Create object
An object is composed by its attributes, Methods and Constructors, and to use this object we need to instantiate it.

We put public to be able to use the attribute inside this object. Then we indicate the type of our attribute, per exemple String. Now we put the name of our attribute always in UpperCamelCase. Now we have to do the getter and setter.

What is the getter and setter? Well the getter returns the value of an specific instance and the setter modify or sets an specific attribute value. Easy.

Because we are using the C# type is so much easier, we just have to put {get:set:}.

To create the behaviors or functional methods is easy, we only need to create a classic method inside the object.


### Constructor
The constructor is the method that allows us to instantiate our object.
It may be several constructors with differents number of attributes (overloading)

To create the constructor we have to create a Method with the name of the class and in the arguments we put the attributes we gave but in lowerCase, because we need to differentiate all. Inside the constructor we only need to put the name of the attribute and assign the value of the attribute in the constructor, with all the attributes we have.
As I mentioned before we can do several constructors with different numbers of attributes, so let-s do the minum logic load (the constructor that has no attributes).

### Instances
An instance is the process that allows us to save a memory space to save the attributes of our object.

To create an instance we need to go to our Main program. We have to use the “new” word and then the name of our object and we assign the object with the attributes we want.

Then to access the attributes or method of our object we only need to put ourObjetc.Name, etc.

## Inheritance and polymorphism
In inheritance we have superclasses and subclasses. The superclasser are classes with the attributes that several subclasses have in common. Per exemple we have the class tree and then we have pine and palm.

The polymorphism is the characteristic of the objects that allows implementing the same Method in several classes with a different functionality.

### Inheritance

Simple - just 1 superclass

Multiple - infinite superclasses

To create the inheritance we need to have a super class and a subclass, they are normal classes. Now in the subclass we have to put two dots and the name of the superclass (: superclass) then in our constructor we have to add the attributes of the super class as if we got it in this object. then we put base and the name of the attributes to indicate that they are the same attributes as the constructor of our superclass.

### Polymorphism
Overloading is polymorphism in compilation time. Is when we have several methods with the same name but different arguments in the class.

Overriding is polymorphism in execution time. Is when a superclass have a method and the subclasses can use that method and change the functionality, but not the return.

## Encapsulation
Encapsulation is the hiding of the design decisions or changes, for these affect the minimum at the main program.

### Access and non access modifiers

private -> the members are visible only in this class
protected -> the members are visibles for this class and its subclasses
package -> the members are visible from inside the same package

NOn

static -> Makes the attributes or methods depends of the class and not the instance. In case of the classes encapsulate typical functionalities and their are not instantiable.
abstract -> Declare the class or method but defines (nothing inside)
final -> Makes the class, attribute or method constant

Types of relations
A relation is the relation between two classes or objects. 
Types

Is-a  -> Based on inheritance. there is two types interface or class “Pine is a Tree but tree is not a pine”
Has-a -> This relation is for classes that have other classes as components or members. Is based on the composition “Tree has a leave”. This relation is of aggregation, composition or association.

Association -> A relation between several objects that instancian classes that collaborate within it.

Agregation -> An object is composed by others objects that can exist individuality.

Composition -> An object is composed by others objects but they can not exist individuality

Inheritance -> A superclass that has the attributes that all the subclasses have in common.

## Helper classes

A helper class is a aggregate of differents methods that have functions of common use.

### Interfaces
Has declared methods but they have to be implemented by other class or component.

To declare an interface we have to put interface, and declare our methods.
To use this methods in a different class we only have to put the two dots and the name of the interface (:interface).

In usual it is better to put an I before the anime of the interface

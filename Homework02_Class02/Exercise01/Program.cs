using Exercise01.Domain.Models;
using System.ComponentModel;

//Create interfaces called IAnimal, IDog, ICat
//IAnimal : Contains method PrintAnimal
//IDog - Contains method Bark
//ICat - Contains method Eat that gets parameter food of type string
//Create an abstract class Animal(you choose the properties) that implements IAnimal, with abstract method PrintAnimal
//Create class Dog that implements IDog and inherits from Animal. Implement PrintAnimal but also Bark.
//Create class Cat that implements ICat and inherits from Animal. Implement PrintAnimal but also Eat.
//Create several objects and test the method calls
//The implementation for the methods is on your choice.


Dog dog1 = new Dog("Sparky", "Labrador Retriever", 3, "Beef", "Brown");
dog1.Bark();
dog1.PrintAnimal1();
dog1.PrintAnimal();

Dog dog2 = new Dog("Max", "German Shepherd", 5, "Meat", "Black-Brown");
dog2.Bark();
dog2.PrintAnimal();
dog2.PrintAnimal1();

Dog dog3 = new Dog("Jack","Bulldog",1,"Cheese", "White");



Cat cat1 = new Cat("Poppy", "Abyssinian", 7, false, "Milk");
cat1.PrintAnimal();
cat1.PrintAnimal1();
cat1.Eat();

Cat cat2 = new Cat("Luna", "Sphynx", 4, true, "Milk");
cat2.PrintAnimal();
cat2.PrintAnimal1();
cat2.Eat();

Cat cat3 = new Cat("Bella", "Birman", 2, true, "Milk");
cat3.PrintAnimal();
cat3.PrintAnimal1();
cat3.Eat();
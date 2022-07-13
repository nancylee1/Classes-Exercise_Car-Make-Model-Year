//Exercise 1:
//Create a new C# .Net Core Console App
//Create a class named Car - make sure it is public
//In the Car class:
//Create a Make property of type string that is public
//Create a Model property of type string that is public
//Create a Year property of type int that is public
//In the Main method:
//Create a new instance of the Car class
//Set values in the properties for the object
//Print the values of each property to the Console


using ClassesExercise; 

var car1 = new Car();
car1.Make = "Hyundai";
car1.Model = "Genesis";
car1.Year = 2022;

car1.Print();

var car2 = new Car();
car2.Make = "BMW";
car2.Model = "5 Series";
car2.Year = 2021;

car2.Print();
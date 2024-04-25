using System;

class Program
{
    static void Main(string[] args)
    {
        int num = 1;
        string word = "Hello";

//Object Declaration and Instantiation (Initialization)
        Object obj1 = new Object();
        Object obj2 = new Object();
        Object obj3 = new();

        DateTime currentTime = DateTime.Now;
        System.Console.WriteLine(currentTime);

        Car car1 = new Car();
        System.Console.WriteLine(car1);

        //car1.color = "Blue";
        car1.make = "Honda";
        car1.model = "Pilot";
        car1.year = 2020;

        System.Console.WriteLine(car1.color);
        System.Console.WriteLine(car1.make);
        System.Console.WriteLine(car1.model);
        System.Console.WriteLine(car1.year);
        System.Console.WriteLine(car1.mileage);  //will default a value since not defined above

        System.Console.WriteLine("Color: " + car1.color  +  "; Year: " + car1.year);
        System.Console.WriteLine(car1.color + " " + car1.year);

        car1.Honk();  //Calls the method Honk for the car1 object
        car1.Drive(100);

        

        Car car2 = new Car();
        System.Console.WriteLine(car2);

        car2.color = "White";
        car2.make = "Nissan";
        car2.model = "Murano";
        car2.year = 2022;

        car2.Drive(50);
        
        System.Console.WriteLine("Car 1 Color: " + car1.color);
        System.Console.WriteLine("Car 1 Mileage: " + car1.mileage);

        System.Console.WriteLine("Car 2 Color: " + car2.color);
        System.Console.WriteLine("Car 2 Mileage: " + car2.mileage);

        Car car3 = car2; //car 2 and car 3 are the same car when created this way. See Mileage below where they are combined, as proof. 
        //You can change this by changing the variable for car3 to new car();.

        car3 = new Car();
        System.Console.WriteLine("Car 3 Color: " + car3.color + " " + car3.mileage);

        car3.Drive(60);
        System.Console.WriteLine("Car 2 Mileage: " + car2.mileage);
        System.Console.WriteLine("Car 3 Mileage: " + car3.mileage);

        /* Added Display info string to show all of the cars info
        */

        System.Console.WriteLine(car1.DisplayInfo());

    Car car4 = new Car();
    Car car5 = new Car("Silver"); 
    Car car6 = new Car("Yellow", "Volkswagon", "Beetle", 2005, 10000); 
    //Car car6 = new Car("", "Volkswagon", "Beetle", 2005, 10000); //if you wanted a null value for this example color. 
    //Car car6 = new Car(null, "Volkswagon", "Beetle", 0, 10000);
    Car car7 = new Car("Green", "Honda", "Accord", 2016, 15000); 

    System.Console.WriteLine(car7.color.ToUpper());
    System.Console.WriteLine(car7.DisplayInfo());

    //How to copy over one object's value to another object. 
    /*
    - No-Arg
    Car car8 = new Car();
    car8.color = car6.color;
    car8.make = car6.make;

    - Full-Arg
    Car car9 = new(car6.color; car6.make);

    - Copy ...see below for the Copy constructor
    Car 10 = new(car6);

    Bonus: //Copy Constructor   you could also name these old or new (Car new or other)
    public Car(Car car)
    {
    color = new.color
    make = new.make
    }

    */
  
    }

}


// Classes and Objects

/*
- Classes - BluePrint for an Object that will define its states and behaviors
- States - Values that we are holding/field properties
- Behaviors - anything we want the objext to do. 
- Objects - An instance of a Class - Physical entitiy created from said blueprint. 

Class Contents: 
    State - fields
        Color
        Model
        Mileage
        Year
        Num of Seats
        Num of Tires 
        works?
        owned? 
    Behaviors - methods of a class. Like a function. Anything we want the object to do. 
        Drive
        Honk
        Back up
        Drift
        Crash    
        Change the Radio
        Roll down the window
    Constructors - a special method. Builds an instance of a Class. AKA Object.
            

 //Constuctors - a special type of methos who's pupose is to help us create new objects of that class. 
 Along with any other initial set up instructions we with to provide. 

 Syntax:
 access_modifier ClassName(poential parameters)
 {
    What you want the constuctor to do while setting up your object. 
        - setting initial values is common
 }

C# will provide a "default" constructor when you do not explicitly create any constructors. 
As soon as you create even ONE constuctor, the default constructor is no longer provided. 

We can have multiple constructors - the only requirement is that
parameters have to be some new unique combination of types. 
Overloaded methods have multiple implementations with different types.

//Full-Arg Constructor - are a choice of us providing ALL the values for out fields.
*"Full" argument and "No" argument are the 2 most common constructor types. 
*/

//Properties
/* 
*/
//Scopes (static keyword as well)
//Access Modifiers

//File Input/Output

//Inheritance
//Polymorphism - overload methods / overidden 


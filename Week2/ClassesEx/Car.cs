using System.Drawing;
using System.Reflection.Metadata.Ecma335;

class Car
{
    //Fields
    public string? color;
    public string? make;
    public string? model;
    public int year;
    public int mileage;

//Access modifier ...makes a default value outside of what C# provides. 
public Car()
{
    color = "Black";
}

//public Car(string newColor)
public Car(string color)
{
//color = newColor;
this.color = color;  //this keyword is a placeholder for the object in reference (the object getting built)
}

//Full-Arg Constructor - meaning choice of us providing ALL the values for our fields.
public Car(string color, string make, string model, int year, int mileage)
{
this.color = color;
this.make = make;
this.model = model;
this.year = year;
this.mileage = mileage;
}

//Methods
public void Honk()
{
    System.Console.WriteLine("Honk Honk!");
}

public void Drive(int milesDriven)
{
    mileage += milesDriven;
    System.Console.WriteLine("The new total mileage is: " + mileage);
}

    public string DisplayInfo()   //this is the "ToString" method. You can rename it. 
    {
            string str = "";
            str += "{Color=" + color;
            str += "; Make=" + make;
            str += "; Model=" + model;
            str += "; Year=" + year;
            str += "; Mileage=" + mileage + "}";

            return str;
    }

}


using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)

    {

        House house1 = new();
        House house2 = new();
        House house3 = new();

        System.Console.WriteLine(house1);

        house1.color = "Grey";
        house1.levels = "2";
        house1.doors = "1";
        house1.windows = "9"; 

        System.Console.WriteLine("House 1 -" + " " + "Color:" + " " + house1.color +"," + " " + "Windows:" + " " + house1.windows);
        house2.color = "White";
        house2.levels = "1";
        house2.doors = "2";
        house2.windows = "5"; 

        System.Console.WriteLine("House 2 -" + " " + "Color:" + " " + house2.color+"," + " " + "Windows:" + " " + house2.windows);

        //house3.color = "White";
        house3.levels = "3";
        house3.doors = "5";
        house3.windows = "15"; 
        System.Console.WriteLine("House 3 -" + " " + "Color:" + " " + house3.color+"," + " " + "Windows:" + " " + house3.windows);

        house1.Windows();
        System.Console.WriteLine(house1);

        System.Console.WriteLine(house2.DisplayInfo());

    }
}

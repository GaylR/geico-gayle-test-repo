class House
{
    public string? color;
    public string? levels;
    public string? doors;
    public string? windows; 

    public House()
   { 
    color = "Greige";
    }

    public void Windows()
    {
        System.Console.WriteLine("Open and Shut");
        
    }

    public string DisplayInfo()
    {
        string str = "";
        str +="{Color=" + color;
        str +=";Levels=" + levels;
        str +=";Doors=" + doors;
        str +=";Windows=" + windows + "}";

        return str;
    }
}
using System;

public class Table
{
    public string brandName { get; set; }
    public string colour { get; set; }
    public decimal length { get; set; }
    public decimal breath { get; set; }
    public decimal surfaceArea { get; set; }
    public decimal height { get; set; }
    public bool isPlastic { get; set; }

    public Table(string brandName, decimal height)
    {
        this.brandName = brandName;
        this.height = height;
    }

    public Table(string brandName, string colour, bool isPlastic)
    {
        this.brandName = brandName;
        this.colour = colour;
        this.isPlastic = isPlastic;
    }

    public override string ToString()
    {
        return " Brand Name: " + brandName
                             + "\n Table Colour: " + colour
                             + "\n Table Height: " + height
                             + "\n Is Table Plastic?: " + isPlastic;
    }

}

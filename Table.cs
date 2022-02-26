﻿using System;

public class Table
{
    public string brandName { get; set; }
    public string colour { get; set; }
    public decimal length { get; set; }
    public decimal breadth { get; set; }
    public decimal height { get; set; }
    public decimal surfaceArea { get; set; }
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

    public Table(decimal length, decimal breadth, decimal height, bool isPlastic)
    {
        this.length = length;
        this.breadth = breadth;
        surfaceArea = length * breadth;
        this.height = height;
        this.isPlastic = isPlastic;
    }

    public string Print()
    {
        return " Brand Name: " + brandName
                             + "\n Colour: " + colour
                             + "\n Length: " + length
                             + "\n Breadth: " + breadth
                             + "\n Size: " + surfaceArea
                             + "\n Height: " + height
                             + "\n Is Table Plastic?: " + isPlastic;
    }

}

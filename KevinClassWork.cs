using System;

public class Table
{
    public int id { get; set; }
    public string name { get; set; }
    public string colour { get; set; }
    public decimal breadth { get; set; }
    public decimal lenght { get; set; }
    public decimal height { get; set; }
    public bool isPlastic { get; set; }

    new public Table(string name, string colour)
    {
        this.name = name;
        this.colour = colour;
    }

    new public Table(int id, string colour, bool isPlastic)
    {
        this.name = name;
        this.colour = colour;
        this.isPlastic = isPlastic;
    }

}

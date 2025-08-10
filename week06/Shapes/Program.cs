using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Creating list to hold the shapes
        List<Shape> shapes = new List<Shape>();

        //Adding shapes to the list
        shapes.Add(new Square("Red", 5));       
        shapes.Add(new Rectangle("Blue", 4, 6));   
        shapes.Add(new Circle("Green", 3));       

        //Iterating through the list and displaying color/area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} | Area: {shape.GetArea():F2}");
        }
    }
}
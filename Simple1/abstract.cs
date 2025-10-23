using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple1
{
     public abstract class Shape
    {
        public string Color { get; set; }

        public abstract double CalculateArea();


        public void Display()
        {
            Console.WriteLine($"The shape's color is {Color}.");
        }
    }

public class Circle : Shape
{
    public double Radius { get; set; }


    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}


public class Rectangle1 : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

  
    public override double CalculateArea()
    {
        return Width * Height;
    }
}
}

using System;

abstract class Shape
{
    public abstract int GetRectangleArea();
    public int Width { get; set; }
    public int Height { get; set; }
}

class Rectangle : Shape
{

    public override int GetRectangleArea()
    {
        return Width * Height;
    }
}


class Square : Shape
{
    public int Width
    {
        get { return Width; }
        set
        {
            Height = value;
            Width = value;
        }
    }
    public int Height
    {
        get { return Height; }
        set
        {
            Height = value;
            Width = value;
        }
    }

    public override int GetRectangleArea()
    {
        return Height * Width;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape rect = new Square();
            rect.Width = 5;
            rect.Height = 10;

            Console.WriteLine(rect.GetRectangleArea());
            //Відповідь 100? Що не так???
            Console.ReadKey();
        }
    }
}
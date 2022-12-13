using System;
interface IDiscount
{
    void ApplyDiscount(string discount);
    void ApplyPromocode(string promocode);

}

interface ISize
{
    void SetSize(string size);
    void SetColor(string color);
}

interface IPrice
{
    void SetPrice(double price);
}



class Coat : IPrice, IDiscount, ISize
{
    public void SetSize(string size)
    {
        Console.WriteLine($"Size is set to: {size}");
    }

    public void ApplyPromocode(string promocode)
    {
        Console.WriteLine($"Aplied promocode: {promocode}" );
    }

    public void ApplyDiscount(string discount)
    {
        Console.WriteLine($"Aplied discount: {discount}");
    }

    public void SetPrice(double price)
    {
        Console.WriteLine($"Price is set to: {price}");
    }
    public void SetColor(string color)
    {
        Console.WriteLine($"Color is set to: {color}");
    }

}
class Book : IPrice, IDiscount
{

    public void ApplyPromocode(string promocode)
    {
        Console.WriteLine($"Aplied promocode: {promocode}");
    }
    public void ApplyDiscount(string discount)
    {
        Console.WriteLine($"Aplied discount: {discount}");
    }

    public void SetPrice(double price)
    {
        Console.WriteLine($"Price is set to: {price}");
    }
}

class Program
{
    static void Main(string[] args)
    {
       
    }
}
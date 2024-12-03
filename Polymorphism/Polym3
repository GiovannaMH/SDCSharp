using System;

// Base class (or parent class)
public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

// Derived class (or child class) that overrides the Draw method
public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Program
{
    static void Main()
    {
        Shape shape = new Shape();
        Circle circle = new Circle();

        shape.Draw();  // Calls the base class method: "Drawing a shape"
        circle.Draw(); // Calls the overridden method in the derived class: "Drawing a circle"

        // Polymorphism in action
        Shape polymorphicShape = new Circle();
        polymorphicShape.Draw(); // Calls the overridden method in the derived class: "Drawing a circle"
    }
}

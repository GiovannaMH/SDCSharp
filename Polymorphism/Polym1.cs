using System;

public class Calculator
{
    // Initial Add method for two integers
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // Overloaded Add method for two strings
    public void Add(string a1, string a2)
    {
        Console.WriteLine("Adding Two String :" + a1 + a2);
    }

    // Overloaded Add method for two doubles
    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    // Overloaded Add method for three integers
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Overloaded Add method for three doubles
    public double Add(double num1, double num2, double num3)
    {
        return num1 + num2 + num3;
    }
}

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        int sumInt = calculator.Add(5, 10);
        double sumDouble = calculator.Add(3.5, 2.7);
        int sumIntThree = calculator.Add(5, 10, 15);
        double sumDoubleThree = calculator.Add(3.5, 2.7, 1.2);

        Console.WriteLine("Sum of two integers: " + sumInt); // Output: 15
        Console.WriteLine("Sum of two doubles: " + sumDouble); // Output: 6.2
        Console.WriteLine("Sum of three integers: " + sumIntThree); // Output: 30
        Console.WriteLine("Sum of three doubles: " + sumDoubleThree); // Output: 7.4


        Calculator obj = new Calculator();
        obj.Add("Apprentify ", "Training");
        Console.WriteLine(obj.Add(5, 10, 3));
         
        Console.ReadLine();

    }
}

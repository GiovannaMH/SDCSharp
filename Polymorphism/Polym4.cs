using System;

class ABase
{
    public virtual void ShowMessage()
    {
        Console.WriteLine("Message from class ABase");
    }
}

class BDerived : ABase
{
    public override void ShowMessage()
    {
        Console.WriteLine("Message from class BDerived (overridden)");
    }

    public new void ShowMessage(string additionalMessage)
    {
        Console.WriteLine("Message from class BDerived: " + additionalMessage);
    }
}

class Program
{
    static void Main()
    {
        ABase a = new ABase();
        BDerived b = new BDerived();

        a.ShowMessage(); // Calls the method from class A: "Message from class A"
        b.ShowMessage(); // Calls the overridden method in class B: "Message from class B (overridden)"

        // Using method hiding
        ((ABase)b).ShowMessage(); // Calls the method from class A: "Message from class A"

        // Using method hiding with additional parameter
        b.ShowMessage("Additional message"); // Calls the method from class B with an additional parameter: "Message from class B: Additional message"
    }
}

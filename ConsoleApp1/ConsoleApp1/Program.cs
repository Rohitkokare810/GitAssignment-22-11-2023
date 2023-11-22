using System;

// Interface 1
interface IConnectable
{
    bool Connect();
}

// Interface 2
interface IRechargeable
{
    void Charge(int minutes);
}

// Interface 3
interface IDisplayable
{
    string Display();
}

// Electronic device base class
class ElectronicDevice
{
    public string Brand { get; set; }
    public string Model { get; set; }

    public ElectronicDevice(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }
}

// Smartphone class implementing the interfaces
class Smartphone : ElectronicDevice, IConnectable, IRechargeable, IDisplayable
{
    public Smartphone(string brand, string model) : base(brand, model) { }

    public bool Connect()
    {
        // Implementation for connecting a smartphone
        Console.WriteLine($"{Brand} {Model} connected successfully.");
        return true;
    }

    public void Charge(int minutes)
    {
        // Implementation for charging a smartphone
        Console.WriteLine($"{Brand} {Model} is charging for {minutes} minutes.");
    }

    public string Display()
    {
        // Implementation for displaying smartphone information
        return $"Smartphone: {Brand} {Model}";
    }
}

// Laptop class implementing the interfaces
class Laptop : ElectronicDevice, IConnectable, IRechargeable, IDisplayable
{
    public Laptop(string brand, string model) : base(brand, model) { }

    public bool Connect()
    {
        // Implementation for connecting a laptop
        Console.WriteLine($"{Brand} {Model} connected successfully.");
        return true;
    }

    public void Charge(int minutes)
    {
        // Implementation for charging a laptop
        Console.WriteLine($"{Brand} {Model} is charging for {minutes} minutes.");
    }

    public string Display()
    {
        // Implementation for displaying laptop information
        return $"Laptop: {Brand} {Model}";
    }
}

class Program
{
    static void Main()
    {
        // Creating instances of Smartphone and Laptop
        Smartphone smartphone = new Smartphone("Samsung", "Galaxy S21");
        Laptop laptop = new Laptop("Dell", "XPS 13");

        // Connecting and displaying information for each device
        smartphone.Connect();
        smartphone.Charge(120);
        Console.WriteLine(smartphone.Display());

        Console.WriteLine(); // Separator for better readability

        laptop.Connect();
        laptop.Charge(180);
        Console.WriteLine(laptop.Display());
        Console.ReadKey();
    }
}

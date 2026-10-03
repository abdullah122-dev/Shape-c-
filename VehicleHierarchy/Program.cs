using System;

class Vehicle
{
    public string Brand { get; set; }
    public int Year { get; set; }

    public Vehicle(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }

    public virtual void Start()
    {
        Console.WriteLine($"{Brand} vehicle is starting.");
    }
}

class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car(string brand, int year, int numberOfDoors)
        : base(brand, year)
    {
        NumberOfDoors = numberOfDoors;
    }

    public override void Start()
    {
        Console.WriteLine($"Car {Brand} is starting.");
    }
}

class Bus : Vehicle
{
    public int Capacity { get; set; }

    public Bus(string brand, int year, int capacity)
        : base(brand, year)
    {
        Capacity = capacity;
    }

    public override void Start()
    {
        Console.WriteLine($"Bus {Brand} is starting.");
    }
}

class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public Motorcycle(string brand, int year, bool hasSidecar)
        : base(brand, year)
    {
        HasSidecar = hasSidecar;
    }

    public override void Start()
    {
        Console.WriteLine($"Motorcycle {Brand} is starting.");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car("Toyota", 2022, 4);
        Bus bus = new Bus("Mercedes", 2020, 50);
        Motorcycle motorcycle = new Motorcycle("Honda", 2023, false);

        car.Start();
        bus.Start();
        motorcycle.Start();
    }
}

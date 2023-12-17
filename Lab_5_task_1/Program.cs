using System;
using System.Collections.Generic;

namespace Lab_5_task_1
{
abstract class Vehicle
{
    public int Speed { get; set; }
    public int Capacity { get; set; }

    public abstract void Move();

}

class Human
{

    public int Speed { get; set; }

    public void Move()
    {
        Console.WriteLine("Human is walking.");
    }
}

class Car : Vehicle
{
    public Car()
    {
        Speed = 60;
        Capacity = 5;
    }

    public override void Move()
    {
        Console.WriteLine("Car is driving.");
    }
}

class Bus : Vehicle
{
    public Bus()
    {
        Speed = 40;
        Capacity = 30;
    }

    public override void Move()
    {
        Console.WriteLine("Bus is moving.");
    }
}

class Train : Vehicle
{
    public Train()
    {
        Speed = 100;
        Capacity = 200;
    }

    public override void Move()
    {
        Console.WriteLine("Train is moving on tracks.");
    }
}

class TransportNetwork
{
    private List<Vehicle> vehicles;

    public TransportNetwork()
    {
        vehicles = new List<Vehicle>();
    }

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void MoveAllVehicles()
    {
        foreach (var vehicle in vehicles)
        {
            vehicle.Move();
        }
    }
}

class Route
{
    public string StartPoint { get; set; }
    public string EndPoint { get; set; }

    public Route(string startPoint, string endPoint)
    {
        StartPoint = startPoint;
        EndPoint = endPoint;
    }
}

class ExtendedTransportNetwork : TransportNetwork
{
    public void CalculateOptimalRoute(Route route)
    {
        Console.WriteLine($"Calculating optimal route from {route.StartPoint} to {route.EndPoint}.");
    }

    public void BoardPassengers(int numberOfPassengers)
    {
        Console.WriteLine($"Boarding {numberOfPassengers} passengers.");
    }

    public void DisembarkPassengers(int numberOfPassengers)
    {
        Console.WriteLine($"Disembarking {numberOfPassengers} passengers.");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Минко Ярослав");

        Car car = new Car();
        Bus bus = new Bus();
        Train train = new Train();
        Human person = new Human();

        ExtendedTransportNetwork transportNetwork = new ExtendedTransportNetwork();
        transportNetwork.AddVehicle(car);
        transportNetwork.AddVehicle(bus);
        transportNetwork.AddVehicle(train);

        transportNetwork.MoveAllVehicles();

        Route route = new Route("City A", "City B");
        transportNetwork.CalculateOptimalRoute(route);
        transportNetwork.BoardPassengers(20);
        transportNetwork.MoveAllVehicles();
        transportNetwork.DisembarkPassengers(15);
    }
}

}
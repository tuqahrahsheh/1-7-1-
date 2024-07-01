using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1_7__1_
{
    internal class Program
    {
        static void Main(string[] args) { 
       // Create an instance of Car
        Car myCar = new Car("Toyota", 2022, "SUV", 15000., "Rav4", "ABC123", "Blue");

        // Test Car methods
        Console.WriteLine("Car Details:");
        Console.WriteLine(myCar.GetCarInfo());
        myCar.StartEngine();
        Console.WriteLine(myCar.GetCarInfo());
        myCar.StopEngine();
        Console.WriteLine(myCar.GetCarInfo());

        Console.WriteLine();

        // Create an instance of BMW
        BMW myBMW = new BMW("BMW", 2023, "Sedan", 55000.00m, "M3", "XYZ456", "Black", "M Series");

        // Test BMW methods
        Console.WriteLine("BMW Details:");
        Console.WriteLine(myBMW.GetCarInfo());
        myBMW.StartEngine();
        Console.WriteLine(myBMW.GetCarInfo());
        myBMW.StopEngine();
        Console.WriteLine(myBMW.GetCarInfo());
     {


            // Create an instance of Car
            Car myCars = new Car("Toyota", 2022, "SUV", 15000, "Rav4", "ABC123", "Blue");

            // Access and print car details
            Console.WriteLine("Car Details:");
            Console.WriteLine($"Make: {myCars.Make}");
            Console.WriteLine($"Year: {myCars.Year}");
            Console.WriteLine($"Type: {myCars.Type}");
            Console.WriteLine($"Price: ${myCars.Price}");
            Console.WriteLine($"Model: {myCars.Model}");
            Console.WriteLine($"Pallet No: {myCars.PalletNo}");
            Console.WriteLine($"Color: {myCars.Color}");

            Console.ReadKey();
        }
    }
    }

    // Car.cs

    public class Car
    {
        // Fields
        private string make;
        private int year;
        private string type;
        private decimal price;
        private string model;
        private string palletNo;
        private string color;
        protected bool isEngineRunning;

        // Constructor
        public Car(string make, int year, string type, decimal price, string model, string palletNo, string color)
        {
            this.make = make;
            this.year = year;
            this.type = type;
            this.price = price;
            this.model = model;
            this.palletNo = palletNo;
            this.color = color;
            this.isEngineRunning = false;
        }
        public void StartEngine()
        {
            isEngineRunning = true;
            Console.WriteLine($"{make} {model} Engine started.");
        }

        // Method to stop the engine
        public void StopEngine()
        {
            isEngineRunning = false;
            Console.WriteLine($"{make} {model} Engine stopped.");
        }

        // Method to get full information about the car
        public virtual string GetCarInfo()
        {
            return $"Make: {make}, Year: {year}, Type: {type}, Price: ${price}, Model: {model}, Pallet No: {palletNo}, Color: {color}, Engine Running: {(isEngineRunning ? "Yes" : "No")}";
        }


        // Properties (optional, if you want to access fields externally)
        public string Make { get { return make; } }
        public int Year { get { return year; } }
        public string Type { get { return type; } }
        public decimal Price { get { return price; } }
        public string Model { get { return model; } }
        public string PalletNo { get { return palletNo; } }
        public string Color { get { return color; } }

        // task 2
        public Car(string Make, int Year, double Price, string Model, string Pallet, string Color)
        {
            make = Make;
            year = Year;
            Price = (double)price;
            model = Model;
            palletNo = Pallet;
            color = Color;
        }

    


    }
    // BMW.cs

    public class BMW : Car
    {
        private string series;

        // Constructor with parameters including base class fields
        public BMW(string make, int year, string type, decimal price, string model, string palletNo, string color, string series)
            : base(make, year, type, price, model, palletNo, color)
        {
            this.series = series;
        }

        // Method to get full information about the BMW
        public override string GetCarInfo()
        {
            return $"Make: {Make}, Year: {Year}, Type: {Type}, Price: ${Price}, Model: {Model}, Series: {series}, Pallet No: {PalletNo}, Color: {Color}, Engine Running: {(isEngineRunning ? "Yes" : "No")}";
        }
    }
}

using System;
using System.Collections;
using Module2_Exercise3.Core.Extensions;
using Module2_Exercise3.InterfaceExample;
using Module2_Exercise3.PolymorphismExample;

namespace Module2_Exercise3;

public class Vehicle
{
    public int Year { get; set; }
}

public class SortVehicleAscending : IComparer
{
    // Vehicle 2023 | Vehicle 2022 | Vehicle 2021

    // 1 1 2 3 4 5 6 7 8 9
    public int Compare(object x, object y)
    {
        var left = x as Vehicle;

        if (left is null)
        {
            throw new ArgumentException();
        }
        
        var right = y as Vehicle;

        if (right is null)
        {
            throw new ArgumentException();
        }

        if (left.Year > right.Year)
        {
            return 1; // Should change items.
        }

        if (left.Year < right.Year)
        {
            return -1;
        }

        return 0;  //The same.
    }
}

internal sealed class Program
{
    public static void Main(string[] args)
    {
        IMove move = new Byke();

        var countC = StringExtensions.CharCount("aaaaabbbbccc", 'c'); // Invoke Static method
        "aaaaabbbbccc".CharCount('c'); // Invoked as Extension method

        var vehicles = new[] { new Vehicle { Year = 2023 }, new Vehicle { Year = 2021 } };

        Array.Sort(vehicles, new SortVehicleAscending());

        var randomDay = new Random().Next(1, 7);

        CoffeeMachine coffeeMachine = null;
        IMove moveble = null;

        if (randomDay % 2 == 0)
        {
            coffeeMachine = new LateCoffeeMachine(new Milk { Type = "Coconut" });
            moveble = new Byke();
        }
        else
        {
            coffeeMachine = new EspressoCoffeeMachine();
            moveble = new Car();
        }

        var late = coffeeMachine as LateCoffeeMachine;

        if (late != null)
        {
            Console.WriteLine(late.Milk.Type);
        }

        coffeeMachine.GeneralCoffeeInfo();
    }
}

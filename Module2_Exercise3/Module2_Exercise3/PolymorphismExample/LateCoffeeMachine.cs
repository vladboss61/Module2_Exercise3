using System;

namespace Module2_Exercise3.PolymorphismExample;

internal sealed class LateCoffeeMachine : CoffeeMachine
{
    public Milk Milk { get; set; }

    public LateCoffeeMachine(Milk milk) : base(State.Started)
    {
        Milk = milk;
    }   

    public override Coffee Prepare()
    {
        return new Coffee { Name = "Late" };
    }

    public override void GeneralCoffeeInfo()
    {
        base.GeneralCoffeeInfo();
        Console.WriteLine($"Additionally with Milk: {Milk.Type}.");
    }
}

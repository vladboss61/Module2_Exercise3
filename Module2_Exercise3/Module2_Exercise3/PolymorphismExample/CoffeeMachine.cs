using System;
using Module2_Exercise3.InterfaceExample;

namespace Module2_Exercise3.PolymorphismExample;

public enum State
{
    Started,
    Stopped,
    Working
}

internal abstract class CoffeeMachine
{
    private readonly State _state;

    protected CoffeeMachine(State state)
    {
        _state = state;
    }

    public abstract Coffee Prepare();

    public virtual void GeneralCoffeeInfo()
    {
        Coffee coffee = Prepare();

        Console.WriteLine($"You have prepared the Coffee {coffee.Name} with current State: {_state}.");
    }
}

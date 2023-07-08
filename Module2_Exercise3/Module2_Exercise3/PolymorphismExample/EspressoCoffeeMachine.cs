namespace Module2_Exercise3.PolymorphismExample;

internal class EspressoCoffeeMachine : CoffeeMachine
{
    public EspressoCoffeeMachine() : base(State.Stopped)
    {
    }

    public sealed override Coffee Prepare()
    {
        return new Coffee { Name = "Espresso" };
    }
}

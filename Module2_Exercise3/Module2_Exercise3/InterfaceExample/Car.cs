using System;

namespace Module2_Exercise3.InterfaceExample;

internal class Car : ISpeed, IMove
{
    public double Speed { get; } = 75.5;

    public void Move(Point start, Point end)
    {
        Console.WriteLine($"Move Car with speed: {Speed}");

        var infoStart = Speed * start.X;
        var infoEnd = Speed * end.X;
    }
}

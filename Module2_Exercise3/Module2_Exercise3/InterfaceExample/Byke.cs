using System;

namespace Module2_Exercise3.InterfaceExample;

interface IMonster
{
    public int Id { get; set; }

    public int CalculateNumbers(int x, int y);

    public int PrepareDish();
}

internal class Byke : ISpeed, IMove
{
    public double Speed { get; } = 30;

    public void Move(Point start, Point end)
    {
        Console.WriteLine($"Byke moves with Speed {Speed}");

        var infoBykeStart = Speed + start.X / 2.0;
        var infoBykeEnd = Speed + end.X / 2.0;
    }
}

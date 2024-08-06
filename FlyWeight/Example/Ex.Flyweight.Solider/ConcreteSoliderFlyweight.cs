using Ex.Flyweight.Solider;

internal class ConcreteSoliderFlyweight : SoliderFlyweight
{
    public ConcreteSoliderFlyweight(string soliderType) : base(soliderType)
    {
    }

    public override void Render(int x, int y, int z, int number)
    {
        //Show solider in special location

        Console.WriteLine($"Solider Type ==> {SoliderType} "
            +$"Show in location => x:{x} y:{y} z:{z}"
            +$"number: {number}");
    }
}
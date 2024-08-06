
using Ex.Flyweight.Solider;

public class SoliderFactory
{
    private static Dictionary<string,SoliderFlyweight> _flyweights=
        new Dictionary<string,SoliderFlyweight>();

    public SoliderFlyweight GetSolider(string soliderType)
    {
        SoliderFlyweight flyweight = null;

        _flyweights.TryGetValue(soliderType, out flyweight);

        if (flyweight is null)
            _flyweights.Add(soliderType, new ConcreteSoliderFlyweight(soliderType));

        return _flyweights[soliderType];
    }
}
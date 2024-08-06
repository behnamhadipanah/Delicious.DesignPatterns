public class FlyweightFactory
{
    private Dictionary<string, Flyweight> _flyweights = new Dictionary<string, Flyweight>();

    public Flyweight GetFlyweight(string key)
    {
        Flyweight flyweight = null;

        _flyweights.TryGetValue(key, out flyweight);

        if (flyweight is null)
            _flyweights.Add(key, new ConcreteFlyweight(key));

        return _flyweights[key];
    }
}
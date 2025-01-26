using System;

namespace Iterator_Pattern.Iterators;

public class ConcreteIterator : IIterator
{

    private ConcreteAggregate _aggregate;
    int current = 0;

    public ConcreteIterator(ConcreteAggregate aggregate)
    {
        _aggregate = aggregate;
    }
    public object CurrentItem()
    {
        return _aggregate[current];
    }

    public object First()
    {
        return _aggregate[0];
    }

    public bool IsDone()
    {
        return current >= _aggregate.Count;
    }

    public object Next()
    {
        if (current < _aggregate.Count - 1)
        {
            return _aggregate[++current];
        }
        return null;
    }
}

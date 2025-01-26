using System.Runtime.CompilerServices;

namespace Iterator_Pattern.Iterators;

public class ConcreteAggregate : Aggregate
{
    List<object> items;
    public ConcreteAggregate()
    {
        items = new List<object>();
    }
    public override IIterator CreateIterator()
    {
        return new ConcreteIterator(this);
    }

    public int Count { get { return items.Count; } }

    public object this[int index]
    {
        get { return items[index]; }
        set { items.Insert(index, value); }
    }
}
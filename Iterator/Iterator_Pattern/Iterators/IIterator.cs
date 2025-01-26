using System;

namespace Iterator_Pattern.Iterators;

public interface IIterator
{
    object First();
    object Next();
    bool IsDone();
    object CurrentItem();
}

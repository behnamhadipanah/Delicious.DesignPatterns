using Ex.Strategy.Sort.App.Entites;

namespace Ex.Strategy.Sort.App.Comparers;

public class UserByIdComparer : IComparer<User>
{
    public int Compare(User x, User y)
    {
        if (ReferenceEquals(x, y)) return 0;
        if (ReferenceEquals(null, y)) return 1;
        if (ReferenceEquals(null, x)) return -1;
        return x.Id.CompareTo(y.Id);
    }
}
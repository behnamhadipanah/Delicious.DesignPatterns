using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex.Strategy.Sort.App.Entites;

namespace Ex.Strategy.Sort.App.Comparers
{
    public class UserByCreditComparer:IComparer<User>
    {
        public int Compare(User x, User y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (ReferenceEquals(null, y)) return 1;
            if (ReferenceEquals(null, x)) return -1;
            return x.Credit.CompareTo(y.Credit);
        }
    }
}

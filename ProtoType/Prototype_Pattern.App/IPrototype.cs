using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern.App
{
    public interface IPrototype
    {
        IPrototype Clone();
    }
}
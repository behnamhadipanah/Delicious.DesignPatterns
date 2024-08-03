using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Composite.Computer
{
    public interface IComponent
    {
        string Name { get; set; }
        int Price { get; set; }
        int DisplayPrice();

    }
}

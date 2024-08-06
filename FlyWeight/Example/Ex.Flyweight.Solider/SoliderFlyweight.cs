using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Flyweight.Solider
{
    public abstract class SoliderFlyweight
    {
        public string SoliderType { get; set; }
        public abstract void Render(int x, int y, int z, int number);
        //  int x , int y, int z ,int number ==> extrinsicState

        protected SoliderFlyweight(string soliderType)
        {
            SoliderType = soliderType;
        }
    }
}

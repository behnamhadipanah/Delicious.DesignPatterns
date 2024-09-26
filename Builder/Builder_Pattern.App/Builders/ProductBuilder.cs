using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Builder_Pattern.App.Entities;

namespace Builder_Pattern.App.Builders
{
    public abstract class ProductBuilder
    {
        protected Product _product;

        public ProductBuilder()
        {
            _product = new Product();
        }

        public abstract void BuildPart1();
        public abstract void BuildPart2();

        public virtual Product GetResult()
        {
            return _product;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.App.Builders
{
    public class Director
    {
        private ProductBuilder _builder;

        public void SetBuilder(ProductBuilder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.BuildPart1();
            _builder.BuildPart2();
        }
    }
}

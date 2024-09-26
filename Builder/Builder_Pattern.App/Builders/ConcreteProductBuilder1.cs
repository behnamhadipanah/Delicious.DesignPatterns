using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder_Pattern.App.Entities;

namespace Builder_Pattern.App.Builders
{
    public class ConcreteProductBuilder1:ProductBuilder
    {
        public override void BuildPart1()
        {
            _product.Part1 = "Part-1";
        }

        public override void BuildPart2()
        {
            _product.Part2 = "Part-2";

        }

        public override Product GetResult()
        {
            _product.Name = "Product 1";
            Console.WriteLine($"{_product.Name} created");
            return base.GetResult();
        }
    }
}

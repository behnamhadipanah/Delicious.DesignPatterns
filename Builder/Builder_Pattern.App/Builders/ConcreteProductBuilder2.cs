using Builder_Pattern.App.Entities;

namespace Builder_Pattern.App.Builders;

public class ConcreteProductBuilder2 : ProductBuilder
{
    public override void BuildPart1()
    {
        _product.Part1 = "x Part-1";
    }

    public override void BuildPart2()
    {
        _product.Part2 = "x Part-2";

    }

    public override Product GetResult()
    {
        _product.Name = "Product 2";
        Console.WriteLine($"{_product.Name} created");
        return base.GetResult();
    }
}
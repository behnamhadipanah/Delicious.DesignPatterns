// See https://aka.ms/new-console-template for more information

using Builder_Pattern.App.Builders;

Console.WriteLine("Hello, World!");

var director = new Director();

var builder1 = new ConcreteProductBuilder1();
var builder2 = new ConcreteProductBuilder2();

director.SetBuilder(builder1);
director.Construct();
var product1 = builder1.GetResult();
product1.DisplayInfo();

director.SetBuilder(builder2);
director.Construct();
var product2 = builder2.GetResult();
product2.DisplayInfo();

Console.ReadKey();
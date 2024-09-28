// See https://aka.ms/new-console-template for more information

using Strategy_Pattern.App.ConcreteStrategies;

Console.WriteLine("Hello, World!");

Context context=new Context(new ConcreteStrategyA());

context = new Context(new ConcreteStrategyB());

Console.ReadKey();
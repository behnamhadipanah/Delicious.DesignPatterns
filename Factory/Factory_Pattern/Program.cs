// See https://aka.ms/new-console-template for more information

using Factory_Pattern;

Console.WriteLine("Hello, World!");


var creatorFactory = new ConcreteCreatorFactory(); 

Product product=creatorFactory.FactoryMethod(0);

product.Execute();

product=creatorFactory.FactoryMethod(100);

product.Execute();


product = creatorFactory.FactoryMethod(-1);

product.Execute();

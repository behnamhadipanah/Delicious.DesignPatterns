// See https://aka.ms/new-console-template for more information

using Decorator_Pattern;

Console.WriteLine("Hello, Decorator!");


var concreteComponent = new ConcreteComponent();

var concreteDecorator = new ConcreteDecorator(concreteComponent);
concreteDecorator.operation();

Console.ReadLine();
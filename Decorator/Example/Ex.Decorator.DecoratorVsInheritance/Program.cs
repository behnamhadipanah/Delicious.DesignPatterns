// See https://aka.ms/new-console-template for more information

using Ex.Decorator.DecoratorVsInheritance;

Console.WriteLine("Hello, World!");


var borderWindowDecoretor = new BorderWindowDecoretor(new WindowDecoretor());
borderWindowDecoretor.Build();
Console.ReadKey();

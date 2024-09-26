// See https://aka.ms/new-console-template for more information

using AbstractFactory_Pattern.App.AbstractFactories;

Console.WriteLine("Hello, World!");


IAbstractFactory abstractFactory1=new ConcreteFactory1();
var productA = abstractFactory1.CreateProductA();
var productB = abstractFactory1.CreateProductB();

productA.Execute();
productB.Execute();

IAbstractFactory abstractFactory2 = new ConcreteFactory2();
productA = abstractFactory2.CreateProductA();
productB = abstractFactory2.CreateProductB();

productA.Execute();
productB.Execute();


Console.ReadKey();
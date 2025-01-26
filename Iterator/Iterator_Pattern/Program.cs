// See https://aka.ms/new-console-template for more information
using Iterator_Pattern.Iterators;

Console.WriteLine("Hello, World!");

ConcreteAggregate myList = new ConcreteAggregate();

myList[0] = "item 1";
myList[1] = "item 2";
myList[2] = "item 3";
myList[3] = "item 4";
myList[4] = "item 5";

IIterator iterator = myList.CreateIterator();
object item = iterator.First();

while (item is not null)
{
    System.Console.WriteLine($"item: {item} ");
    item = iterator.Next();
}

System.Console.Read();
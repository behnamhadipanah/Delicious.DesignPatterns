// See https://aka.ms/new-console-template for more information
using Memento_Pattern;

Console.WriteLine("Hello, World!");


Originator originator = new Originator();

originator.State = "Blue";

Caretaker caretaker = new Caretaker();

caretaker.Memento=originator.CreateMemento();

originator.State = "Green";
originator.State = "Yellow";
originator.State = "DarkRed";

originator.SetMemento(caretaker.Memento);

Console.ReadKey();



// See https://aka.ms/new-console-template for more information

using Adapter_Pattern_ClassAdapter.App;

Console.WriteLine("Hello, World!");


ITarget target = new Adapter();

target.Operation();

Console.ReadKey();

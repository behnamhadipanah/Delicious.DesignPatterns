// See https://aka.ms/new-console-template for more information

using Singleton_Pattern.App;

Console.WriteLine("Hello, World!");


//Singleton singleton=new Singleton();

var singleton1 = Singleton.GetInstance();
var singleton2 = Singleton.GetInstance();

Console.WriteLine(singleton1==singleton2);
Console.ReadKey();

// See https://aka.ms/new-console-template for more information

using Ex.State.ConsoleApp.Orders;
using Ex.State.ConsoleApp.Orders.ConcreteStates;

Console.WriteLine("Hello, World!");


Order order=new Order(new WaitingToSendState());

order.Send();
order.Delivered();

Console.WriteLine();
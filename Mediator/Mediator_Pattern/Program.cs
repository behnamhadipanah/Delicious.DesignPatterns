// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


ConcreteColleague1 colleague1 = new ConcreteColleague1();
ConcreteColleague2 colleague2 = new ConcreteColleague2();

ConcreteMediator mediator=new ConcreteMediator(colleague1 , colleague2);

colleague1.SetMediator(mediator);
colleague2.SetMediator(mediator);

colleague1.Send("Hello");
colleague2.Send("Hi");

Console.ReadKey();
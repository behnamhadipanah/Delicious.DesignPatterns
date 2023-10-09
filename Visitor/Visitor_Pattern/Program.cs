// See https://aka.ms/new-console-template for more information
using Visitor_Pattern;
using Visitor_Pattern.ConcreteElements;
using Visitor_Pattern.Visitors;

Console.WriteLine("Hello, World!");


ConcreteElementA concreteElementA1 = new ConcreteElementA("ElementA1");
ConcreteElementA concreteElementA2 = new ConcreteElementA("ElementA2");
ConcreteElementA concreteElementA3 = new ConcreteElementA("ElementA3");
ConcreteElementA concreteElementA4 = new ConcreteElementA("ElementA4");
ConcreteElementA concreteElementA5 = new ConcreteElementA("ElementA5");


ConcreteElementB concreteElementB1 = new ConcreteElementB(1);
ConcreteElementB concreteElementB2 = new ConcreteElementB(2);
ConcreteElementB concreteElementB3 = new ConcreteElementB(3);


ObjectStructure objectStructure = new ObjectStructure();
objectStructure.Add(concreteElementA1);
objectStructure.Add(concreteElementA2);
objectStructure.Add(concreteElementA3);
objectStructure.Add(concreteElementA4);
objectStructure.Add(concreteElementA5);
objectStructure.Add(concreteElementB1);
objectStructure.Add(concreteElementB2);
objectStructure.Add(concreteElementB3);

var visitor = new ConcreteVisitor();
objectStructure.Accept(visitor);
Console.ReadKey();
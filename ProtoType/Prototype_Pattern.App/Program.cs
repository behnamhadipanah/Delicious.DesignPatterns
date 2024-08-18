// See https://aka.ms/new-console-template for more information

using Prototype_Pattern.App;

Console.WriteLine("Hello, World!");


ConcretePrototype1 service1= new ConcretePrototype1(1500,"test");


ConcretePrototype1 service2 = (ConcretePrototype1)service1.Clone();


Console.WriteLine(service1.Property1);
Console.WriteLine(service2.Property1);

Console.WriteLine(service1==service2);



ConcretePrototype2 serviceComplex1= new ConcretePrototype2(service1);


var serviceComplex2 = (ConcretePrototype2)serviceComplex1.Clone();


Console.WriteLine(serviceComplex1.MyApplicationService.Property1);
Console.WriteLine(serviceComplex2.MyApplicationService.Property1);

Console.WriteLine(serviceComplex1 == serviceComplex2);


Console.ReadKey();




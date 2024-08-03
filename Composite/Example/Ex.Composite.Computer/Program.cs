// See https://aka.ms/new-console-template for more information

using Ex.Composite.Computer;

Console.WriteLine("Hello, World!");


IComponent hardDisk = new Leaf("Hard Disk", 100000);
IComponent ram = new Leaf("RAM", 100000);
IComponent cpu = new Leaf("CPU", 200000);
IComponent mouse = new Leaf("Mouse", 50000);
IComponent keyboard = new Leaf("Keyboard", 50000);
IComponent monitor = new Leaf("Monitor", 400000);

Composite mainBoard = new Composite("MainBoard", 100000);
Composite caseBox = new Composite("Case", 70000);
Composite peripherals = new Composite("Peripherals", 0);
Composite computer = new Composite("Computer", 0);



mainBoard.AddComponents(new List<IComponent>() { cpu, ram });
peripherals.AddComponents(new List<IComponent>() { mouse, keyboard });

caseBox.AddComponents(new List<IComponent>() { mainBoard, hardDisk });
computer.AddComponents(new List<IComponent>() { caseBox, monitor, peripherals });


computer.DisplayPrice();

Console.ReadKey();


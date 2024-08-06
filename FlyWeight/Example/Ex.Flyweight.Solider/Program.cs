using Ex.Flyweight.Solider;

//List<SoliderFlyweight> soliders=new List<SoliderFlyweight>();

//for (int i = 0; i < 100000; i++)
//{
//    var temp = new ConcreteSoliderFlyweight("Sarbaz");
//    temp.Render(10,50,10,i);
//    soliders.Add(temp);
//}


SoliderFactory factory=new SoliderFactory();
for (int i = 0; i < 100000; i++)
{
    var temp = factory.GetSolider("Sarbaz");
        temp.Render(10,50,10,i);
}

Console.ReadKey();
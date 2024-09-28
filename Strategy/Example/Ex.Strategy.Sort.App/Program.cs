// See https://aka.ms/new-console-template for more information

using Ex.Strategy.Sort.App.Comparers;
using Ex.Strategy.Sort.App.Entites;

Console.WriteLine("Hello, World!");

Console.WriteLine("Before Sort");
var users=new User[]
{
    new User(101,"A","AA",5000),
    new User(105,"B","BB",8000),
    new User(103,"c","CC",1000)

};
foreach (var user in users)
{
    user.DisplayUser();
}



//Array.Sort(users,new UserByCreditComparer());
Array.Sort(users,new UserByIdComparer());

Console.WriteLine("after Sort");
foreach (var user in users)
{
    user.DisplayUser();
}

Console.ReadKey();
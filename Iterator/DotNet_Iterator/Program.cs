// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


List<string> myList = new List<string>();
myList.Add("item1");
myList.Add("item2");
myList.Add("item3");
myList.Add("item4");
myList.Add("item5");
myList.Add("item6");

Queue<string> queue = new Queue<string>();
Dictionary<int, string> dic = new Dictionary<int, string>();

Stack<string> stack = new Stack<string>();

var item = myList.GetEnumerator();
while (item.MoveNext())
{
    System.Console.WriteLine(item.Current);
}
Console.Read();

//use Yeild ==> Create countable set
MyDataCollection myDatas = new MyDataCollection();
myDatas.Add(1, "test1");
myDatas.Add(2, "test2");

var enumrator = myDatas.GetEnumerator();
while (enumrator.MoveNext())
{
    System.Console.WriteLine($"Id: {enumrator.Current.Id} Text: {enumrator.Current.Text}");
}

foreach (var currentItem in myDatas)
{
    System.Console.WriteLine($"Id: {currentItem.Id} Text: {currentItem.Text}");

}

Console.Read();

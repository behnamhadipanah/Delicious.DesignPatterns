// See https://aka.ms/new-console-template for more information
using System.Collections;

public class MyDataCollection : IEnumerable<MyData>
{

    private List<MyData> myDatas;
    public MyDataCollection()
    {
        myDatas = new List<MyData>();
    }
    public void Add(int id, string text)
    {
        myDatas.Add(new MyData { Id = id, Text = text });
    }

    public IEnumerator<MyData> GetEnumerator()
    {
        foreach (var item in myDatas)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

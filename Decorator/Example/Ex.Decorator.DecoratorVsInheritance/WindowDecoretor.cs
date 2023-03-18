using System.Drawing;

namespace Ex.Decorator.DecoratorVsInheritance;


public class WindowDecoretor
{
    public void Build()
    {
        Console.WriteLine("Build Window");
    }
}

public class BorderWindowDecoretor : WindowDecoretor
{
    private readonly WindowDecoretor _windowDecoretor;

    public BorderWindowDecoretor(WindowDecoretor windowDecoretor)
    {
        _windowDecoretor = windowDecoretor;
    }
    public void Build()
    {
        AddBorderToWindow();
        _windowDecoretor.Build();
    }

    private void AddBorderToWindow()
    {
        Console.WriteLine("Border Added!!!!!!");
    }
    



}
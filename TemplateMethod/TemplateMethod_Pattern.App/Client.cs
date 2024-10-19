namespace TemplateMethod_Pattern.App;

public class Client
{
    public static void Run(AbstractClass abstractClass)
    {
        abstractClass.TemplateMethod();
    }
}
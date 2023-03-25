using Facade_Pattern.Package1;
using Facade_Pattern.Package2;
using Facade_Pattern.Package3;

namespace Facade_Pattern;

public class Facade
{

    public void DoSomething()
    {
        var c1 = new Class1();
        var c2 = new Class2();
        var c3 = new Class3();

        c1.Action1();
        c2.Action2();
        c3.Action3();

        c1.Finish();
    }
}
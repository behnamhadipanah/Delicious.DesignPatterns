namespace Ex.Decorator.DecoratorVsInheritance;

public class WindowInheritance
{

}

#region Windows

public class GlassWindow : WindowInheritance
{

}

public class ColoredWindow : WindowInheritance
{

}

public class BlackAndWhiteWindow : WindowInheritance
{

}

#endregion


#region BorderWindow
public class BorderGlassWindow:GlassWindow{

}

public class BorderColoredWindow : ColoredWindow
{

}
public class BorderBlackAndWhiteWindow : BlackAndWhiteWindow
{

}

public class BorderWindow : WindowInheritance
{

}

#endregion

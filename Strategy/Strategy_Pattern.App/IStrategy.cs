using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy_Pattern.App;

namespace Strategy_Pattern.App
{
    public interface IStrategy
    {
        void AlgorithmInterface();
    }
}

public class Context
{
    private IStrategy _strategy;

    public Context(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void ContextInterface()
    {
        _strategy.AlgorithmInterface(); 
    }
}
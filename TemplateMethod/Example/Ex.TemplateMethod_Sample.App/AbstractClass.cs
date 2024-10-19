using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.TemplateMethod_Sample.App
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            Console.WriteLine("AbstractClass.TemplateMethod() => Start()");

            Hook1();
            BaseOperation1();
            RequiredOperation1();
            RequiredOperation2();
            BaseOperation2();
            Hook2();

            Console.WriteLine("AbstractClass.TemplateMethod() => End()");

        }

        protected void BaseOperation1()
        {
            Console.WriteLine("AbstractClass.BaseOperation1() => Run()");

        }

        protected void BaseOperation2()
        {
            Console.WriteLine("AbstractClass.BaseOperation2() => Run()");

        }

        // implement by subclass
        protected abstract void RequiredOperation1();
        protected abstract void RequiredOperation2();

        // not required implement by subclass
        protected virtual void Hook1(){ }
        protected virtual void Hook2() { }
    }
}
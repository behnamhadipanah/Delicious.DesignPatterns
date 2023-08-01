using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    public class Proxy : ISubject
    {
        private RealSubject _realSubject;
        public void DoAction()
        {

            GetRealSubject().DoAction();
            //_realSubject.DoAction();
            
        }

        protected RealSubject GetRealSubject()
        {
            if (_realSubject is null)
                _realSubject = new RealSubject();

            return _realSubject;
        }
    }
}

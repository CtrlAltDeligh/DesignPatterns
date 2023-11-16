using System;

namespace StructuralDesign
{
    public class Proxy:ISubject
    {
        private RealSubject _realSubject; //private field declaration of type RealSubject
        public void Request()
        {
            if (_realSubject == null)
            {
               _realSubject =  new RealSubject();
            }

            Console.WriteLine("Proxy: Logging the request.");
            _realSubject.Request();
            Console.WriteLine("Proxy: Request handled");
        }
    }
}
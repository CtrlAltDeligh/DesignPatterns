using System;

namespace StructuralDesign
{
    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("Real Subject: Handling the request");
        }
    }
}
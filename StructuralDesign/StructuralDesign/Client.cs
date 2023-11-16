
//Virtual Proxy
namespace StructuralDesign
{
    /*
     The Proxy design pattern is a structural design pattern that provides 
     a surrogate or placeholder for another object to control access to it 1. 
     The proxy pattern is used when we
      want to create a wrapper to cover the
       main object’s complexity from the client 1
     */
    public class Client
    {
        static void Main(string[] args)
        {
            ISubject proxy = new Proxy();
            proxy.Request();
        }
    }
}
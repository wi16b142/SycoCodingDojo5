using ResourceProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ResourceProviderHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("starting resource provider service...");
            ServiceHost host = new ServiceHost(typeof(ResourceProviderService));
            host.Open();
            Console.WriteLine("resource provider service started.");
            Console.ReadLine();
        }
    }
}

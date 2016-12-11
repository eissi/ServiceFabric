using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using defaultproxy;
using Microsoft.ServiceFabric.Services.Remoting.Client;

namespace consoleclient
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculatorClient = ServiceProxy.Create<ICalculatorService>(new Uri("fabric:/communicationstack/defaultproxy"));

            string message = calculatorClient.HelloWorldAsync().Result;

            var result = calculatorClient.Add(1, 2).Result;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

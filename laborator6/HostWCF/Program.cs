using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using ObjectWCF;

namespace HostWCF
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Lansare Server...");
            ServiceHost host = new ServiceHost(typeof(PostComment),
                new Uri("http://localhost:8000/PC"));
            foreach (ServiceEndpoint endpoint in host.Description.Endpoints)
            {
                Console.WriteLine($"A (address): {endpoint.Address}\n" +
                    $"B (binding): {endpoint.Binding.Name}\n" +
                    $"C (contract): {endpoint.Contract.Name}\n");
            }

            host.Open();
            Console.WriteLine("Server in executei. Asteapta conexiuni");
            Console.WriteLine("Enter to stop server");
            Console.Read();

            host.Close();



        }
    }
}

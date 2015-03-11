using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFMetaServer {
    class Program {
        static void Main(string[] args) {
            using (ServiceHost host = new ServiceHost(typeof(Service1))) {
                host.Open();
                Console.WriteLine("Server is running at :");
                if (host.Description.Endpoints != null) {
                    var endPoints = host.Description.Endpoints;
                    foreach (var endPoint in endPoints) {
                        Console.WriteLine(endPoint.Address);
                    }
                }
                Console.WriteLine("Press Enter to close.");
                Console.ReadLine();
            }
        }
    }
}

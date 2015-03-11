using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Service.Services;

namespace Service {
    class Program {
        static void Main(string[] args) {

            using (ServiceHost host = new ServiceHost(typeof(WCFEmployeeService))) {
                host.Open();
                Console.WriteLine("Server is open.");
                Console.WriteLine("Press enter to close.");
                Console.ReadLine();
            }
        }
    }
}

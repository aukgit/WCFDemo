using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Client {
    class Program {
        static void Main(string[] args) {
            ChannelFactory<IWCFEmployeeService> factory =
                new ChannelFactory<IWCFEmployeeService>("EmployeeServiceEndpoint");
            IWCFEmployeeService proxy = factory.CreateChannel();

            List<string> employeeList = proxy.EmployeeNames();

            Console.WriteLine("Client reading names from server:");


            foreach (var employeeName in employeeList) {
                Console.WriteLine(employeeName);
            }

            Console.ReadLine();
        }
    }
}

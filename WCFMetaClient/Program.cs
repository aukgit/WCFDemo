using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFMetaClient.ServiceReference2;

namespace WCFMetaClient {
    class Program {
        static void PrintEmployees(List<string> employees) {
            int i = 0;
            foreach (var employee in employees) {
                Console.WriteLine(++i + ". " + employee);
            }
        }
        static void Main(string[] args) {

            Console.WriteLine("Press Enter to retrieve data from server to client.");
            Console.ReadLine();
            EmployeeServiceClient proxy = new EmployeeServiceClient("EmployeeServiceEndpoint");
            var employees = proxy.GetEmployees();

            Console.WriteLine("Printing employees from client application:");
            PrintEmployees(employees);

            //Console.WriteLine("Get Employee by Id(int):");
            //var id = int.Parse(Console.ReadLine());
            //var employee = proxy.GetEmployee(id);
            //Console.WriteLine(employee.FirstName + "[id : " + employee.EmployeeID + "]");

            Console.WriteLine("Enter to close.");
            Console.ReadLine();
        }

    }
}

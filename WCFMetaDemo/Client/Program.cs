using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.EmployeeServiceClient;

namespace Client {
    class Program {

        static void PrintEmployees(List<Employee> employees) {
            int i = 0;
            foreach (var employee in employees) {
                Console.WriteLine(++i + ". " + employee.FirstName + "[id : " + employee.EmployeeID + "]");
            }
        }
        static void Main(string[] args) {

            Console.WriteLine("Press Enter to retrieve data from server to client.");
            Console.ReadLine();
            EmployeeServiceClient.EmployeeServiceClient proxy = new EmployeeServiceClient.EmployeeServiceClient();
            var employees = proxy.GetEmployees();

            Console.WriteLine("Printing employees from client application:");
            PrintEmployees(employees);

            Console.WriteLine("Get Employee by Id(int):");
            var id = int.Parse(Console.ReadLine());
            var employee = proxy.GetEmployee(id);
            Console.WriteLine(employee.FirstName + "[id : " + employee.EmployeeID + "]");

            Console.WriteLine("Enter to close.");
            Console.ReadLine();
        }
    }
}

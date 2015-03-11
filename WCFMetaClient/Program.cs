using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFMetaClient.ServiceReference1;

namespace WCFMetaClient {
    class Program {
        static void Main(string[] args) {
            Service1Client proxyClient = new Service1Client();
            Console.WriteLine(proxyClient.GetMessage());
            Console.ReadKey();

        }
    }
}

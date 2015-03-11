using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Server.DataArchitecture;

namespace Server.Services {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService {
        [OperationContract]
        List<Employee> GetEmployees();

        [OperationContract]
        Employee GetEmployee(int id);
    }
}

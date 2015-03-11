using System.Collections.Generic;
using System.ServiceModel;

namespace Interfaces {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWCFEmployeeService" in both code and config file together.
    [ServiceContract]
    public interface IWCFEmployeeService {
        [OperationContract]
        List<string> EmployeeNames();
    }
}

using System.ServiceModel;

namespace ProductInterfaces {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWCFEmployeeService" in both code and config file together.
    [ServiceContract]
    public interface IWCFEmployeeService {
        [OperationContract]
        void DoWork();
    }
}

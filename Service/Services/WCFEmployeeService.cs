using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Interfaces;
using Service.DataArchitechture;

namespace Service.Services {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFEmployeeService" in both code and config file together.
    public class WCFEmployeeService : IWCFEmployeeService {
        NorthwindEntities db = new NorthwindEntities();
        public List<string> EmployeeNames() {
            return db.Employees.Select(n => n.FirstName).ToList();
        }
    }
}

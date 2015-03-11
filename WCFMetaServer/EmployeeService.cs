using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFMetaServer {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in both code and config file together.
    public class EmployeeService : IEmployeeService {
        NorthwindEntities db = new NorthwindEntities();
        public List<string> GetEmployees() {
            return db.Employees.Select(n=> n.FirstName).Take(10).ToList();
        }

        public string GetEmployee(int id) {
            return db.Employees.Find(id).FirstName;
        }
    }
}

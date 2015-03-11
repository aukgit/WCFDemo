using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Server.DataArchitecture;

namespace Server.Services {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in both code and config file together.
    public class EmployeeService : IEmployeeService {
        NorthwindEntities db = new NorthwindEntities();
        public List<Employee> GetEmployees() {
            return db.Employees.ToList();
        }

        public Employee GetEmployee(int id) {
            return db.Employees.Find(id);
        }
    }
}

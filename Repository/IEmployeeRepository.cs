using DSCC_CW1_7244_1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSCC_CW1_7244_1.Repository
{
    public interface IEmployeeRepository
    {
        void InsertEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
        Employee GetEmployeeById(int Id);  //for getting emp
        IEnumerable<Employee> GetEmployees(); //returning emp
    }
}

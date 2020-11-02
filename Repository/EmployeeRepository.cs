using DSCC_CW1_7244_1.DBContexts;
using DSCC_CW1_7244_1.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSCC_CW1_7244_1.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _dbContext;
        public EmployeeRepository(EmployeeContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteEmployee(int employeeId)
        {
            var employee = _dbContext.Employees.Find(employeeId);
            _dbContext.Employees.Remove(employee);
            Save();
        }
        public Employee GetEmployeeById(int employeeId)
        {
            var emp = _dbContext.Employees.Find(employeeId);
            _dbContext.Entry(emp).Reference(s => s.EmployeeDepartment).Load();
            return emp;
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _dbContext.Employees.Include(s => s.EmployeeDepartment).ToList();
        }
        public void InsertEmployee(Employee employee)
        {
            _dbContext.Add(employee);
            Save();
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }

        

        public void UpdateEmployee(Employee employee)
        {
            _dbContext.Entry(employee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }
    }
}

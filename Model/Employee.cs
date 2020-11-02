using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSCC_CW1_7244_1.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public Department EmployeeDepartment { get; set; }
    }
}

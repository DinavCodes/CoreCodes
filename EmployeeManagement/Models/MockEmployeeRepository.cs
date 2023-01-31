using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id=1,Name="Dinav",Email="dev1@gmail.com",Department="CSE"},
                new Employee(){Id=2,Name="Jack",Email="dev2@gmail.com",Department="MECH"},
                new Employee(){Id=3,Name="Jill",Email="dev3@gmail.com",Department="CIVIL"}
            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreTutorialJourney.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Mary", Department = "HR", Email = "mary@gmail.com" },
                new Employee() { Id = 2, Name = "John", Department = "IT", Email = "john@gmail.com" },
                new Employee() { Id = 3, Name = "Sam", Department = "IT", Email = "sam@gmail.com" },
            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return this._employeeList.FirstOrDefault(emp => emp.Id == id);
        }
    }
}

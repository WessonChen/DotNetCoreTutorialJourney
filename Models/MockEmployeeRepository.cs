using System.Collections.Generic;
using System.Linq;

namespace DotNetCoreTutorialJourney.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Mary", Department = Dept.HR, Email = "mary@gmail.com" },
                new Employee() { Id = 2, Name = "John", Department = Dept.IT, Email = "john@gmail.com" },
                new Employee() { Id = 3, Name = "Sam", Department = Dept.IT, Email = "sam@gmail.com" },
            };
        }

        public void AddEmployee(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
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
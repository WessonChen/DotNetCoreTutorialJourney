using System.Collections.Generic;

namespace DotNetCoreTutorialJourney.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);

        IEnumerable<Employee> GetAllEmployee();

        void AddEmployee(Employee employee);
    }
}
﻿using System.Collections.Generic;

namespace DotNetCoreTutorialJourney.Models
{
    public interface IEmployeeRepository
    {
        Employee AddEmployee(Employee employee);
        Employee DeleteEmployee(int id);
        IEnumerable<Employee> GetAllEmployee();
        Employee GetEmployee(int id);
        Employee UpdateEmployee(Employee employeeChanges);
    }
}
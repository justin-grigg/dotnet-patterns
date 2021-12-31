using System;

namespace FactoryLib
{
    public class EmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int id)
        {
            var emp = new Employee()
            {
                Id = id,
                Name = "Pranaya",
                Department = "IT",
                Salary = 10000
            };

            return emp;
        }
    }
}

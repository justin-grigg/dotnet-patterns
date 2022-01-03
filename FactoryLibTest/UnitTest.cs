using System;
using Xunit;
using FactoryLib;

namespace FactoryLibTest
{
    public class UnitTest
    {
        [Fact]
        public void EmployeeDetails_Test()
        {
            var bl = new EmployeeBusinessLogic();
            var empDetails = bl.GetEmployeeDetails(1);
            Console.WriteLine();
            Console.WriteLine($"Employee details:");
            Console.WriteLine($"id: {empDetails.Id} department {empDetails.Department} salary {empDetails.Salary}");
        }

        [Fact]
        public void EmployeeService_Constructor_Injection_Test()
        {
            var bl = new EmployeeBusinessLogic(new EmployeeDataAccess());
            var empDetails = bl.GetEmployeeDetails(1);
            Console.WriteLine();
            Console.WriteLine($"Employee details:");
            Console.WriteLine($"id: {empDetails.Id} department {empDetails.Department} salary {empDetails.Salary}");
        }

        [Fact]
        public void EmployeeService_Property_Injection_Test()
        {
            var bl = new EmployeeBusinessLogic();
            bl.EmployeeDataAccess = new EmployeeDataAccess();
            var empDetails = bl.GetEmployeeDetails(1);
            Console.WriteLine();
            Console.WriteLine($"Employee details:");
            Console.WriteLine($"id: {empDetails.Id} department {empDetails.Department} salary {empDetails.Salary}");
        }

        [Fact]
        public void EmployeeService_Method_Injection_Test()
        {
            var bl = new EmployeeBusinessLogic();
            bl.SetEmployeeDataAccess(new EmployeeDataAccess());
            var empDetails = bl.GetEmployeeDetails(1);
            Console.WriteLine();
            Console.WriteLine($"Employee details:");
            Console.WriteLine($"id: {empDetails.Id} department {empDetails.Department} salary {empDetails.Salary}");
        }
    }
}

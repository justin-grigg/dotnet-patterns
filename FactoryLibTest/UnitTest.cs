using System;
using Xunit;
using FactoryLib;

namespace FactoryLibTest
{
    public class UnitTest
    {
        [Fact]
        public void EmployeeDetailsTest()
        {
            var bl = new EmployeeBusinessLogic();
            var empDetails = bl.GetEmployeeDetails(1);
            Console.WriteLine();
            Console.WriteLine($"Employee details:");
            Console.WriteLine($"id: {empDetails.Id} department {empDetails.Department} salary {empDetails.Salary}");
        }
    }
}

using System;
using FactoryLib.Interface;
namespace FactoryLib
{
    public class EmployeeBusinessLogic
    {
        private IEmployeeDataAccess _EmployeeDataAccess;

        public EmployeeBusinessLogic()
        {
            _EmployeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
        }

        public Employee GetEmployeeDetails(int id)
        {
            return _EmployeeDataAccess.GetEmployeeDetails(id);
        }
    }
}

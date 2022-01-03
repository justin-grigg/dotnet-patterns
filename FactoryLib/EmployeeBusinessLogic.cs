using System;
using FactoryLib.Interface;
namespace FactoryLib
{
    public class EmployeeBusinessLogic
    {
        private IEmployeeDataAccess _EmployeeDataAccess;

        public IEmployeeDataAccess EmployeeDataAccess{ get; set; }

        public EmployeeBusinessLogic()
        {
            _EmployeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
        }

        public EmployeeBusinessLogic(IEmployeeDataAccess dataAccess)
        {
            _EmployeeDataAccess = dataAccess;
        }

        public void SetEmployeeDataAccess(IEmployeeDataAccess dataAccess)
        {
            this.EmployeeDataAccess = dataAccess;
        }

        public Employee GetEmployeeDetails(int id)
        {
            var emp = _EmployeeDataAccess == null ? this.EmployeeDataAccess : _EmployeeDataAccess;
            return emp.GetEmployeeDetails(id);
        }
    }
}

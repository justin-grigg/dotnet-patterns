﻿using System;

namespace FactoryLib
{
    public class EmployeeBusinessLogic
    {
        private EmployeeDataAccess _EmployeeDataAccess;

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

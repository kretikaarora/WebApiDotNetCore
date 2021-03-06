﻿using BusinessLayer.Interfaces;
using CommaonLayer.ContextModel;
using CommaonLayer.RequestModel;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class EmployeeBL : IEmployeeBL
    {
        private IEmployeeRL employeeRL;

        public EmployeeBL(IEmployeeRL employeeRL)
        {
            this.employeeRL = employeeRL;
        }

        public bool Delete(int EmpId)
        {
            try
            {
                return this.employeeRL.Delete(EmpId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool EditEmployee(UpdateModel updatedEmployee, int EmpId)
        {
            try
            {
                return this.employeeRL.EditEmployee(updatedEmployee, EmpId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<CompanyEmployee> GetAllEmployee()
        {
            try
            {
                return this.employeeRL.GetAllEmployee();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool RegisterEmployee(RegisterModel employee)
        {
            try
            {
                return this.employeeRL.RegisterEmployee(employee);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
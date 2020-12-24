using CommaonLayer.ContextModel;
using CommaonLayer.RequestModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IEmployeeBL
    {
        bool RegisterEmployee(RegisterModel employee);

        bool Delete(int EmpId);

        bool EditEmployee(UpdateModel updatedEmployee, int EmpId);

        List<CompanyEmployee> GetAllEmployee();
    }
}
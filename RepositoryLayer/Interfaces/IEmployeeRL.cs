using CommaonLayer.ContextModel;
using CommaonLayer.RequestModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interfaces
{
    public interface IEmployeeRL
    {
        bool RegisterEmployee(RegisterModel employee);

        bool Delete(int EmpId);

        bool EditEmployee(UpdateModel updatedEmployee, int EmpId);

        List<CompanyEmployee> GetAllEmployee();
    }
}
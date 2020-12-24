using CommaonLayer.ContextModel;
using CommaonLayer.RequestModel;
using CommaonLayer.ResponseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interfaces
{
    public interface IAdminRL
    {
        bool RegisterAdmin(RegisterModel admin);
        List<EmployeeModel> GetAllEmployee();
        EmployeeModel AdminLogin(AdminLogin login);
        EmployeeModel EmployeeLogin(AdminLogin login);
    }
}
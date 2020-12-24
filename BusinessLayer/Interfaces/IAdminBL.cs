using CommaonLayer.RequestModel;
using CommaonLayer.ResponseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IAdminBL
    {
        bool RegisterAdmin(RegisterModel admin);

        List<EmployeeModel> GetAllEmployee();

        EmployeeModel AdminLogin(AdminLogin login);
        EmployeeModel EmployeeLogin(AdminLogin login);
    }
}
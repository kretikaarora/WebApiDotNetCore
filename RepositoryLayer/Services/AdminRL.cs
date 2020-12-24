using CommaonLayer.ContextModel;
using CommaonLayer.RequestModel;
using CommaonLayer.ResponseModel;
using RepositoryLayer.DBContextFiles;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace RepositoryLayer.Services
{
    public class AdminRL : IAdminRL
    {
        private readonly EmployeeContext context;

        public AdminRL(EmployeeContext context)
        {
            this.context = context;
        }

        public EmployeeModel AdminLogin(AdminLogin login)
        {
            try
            {
                return this.context.Employees.Where(x =>
                                                 x.Email == login.Email && x.Password == login.Password
                                                 && x.Role == "Admin")
                                    .Select(o => new EmployeeModel
                                    {
                                        EmployeeId = o.EmployeeId,
                                        Email = o.Email,
                                        FirstName = o.FirstName,
                                        LastName = o.LastName,
                                        PhoneNumber = o.PhoneNumber,
                                        CreatedDateTime = o.CreatedDateTime,
                                        Role = o.Role,
                                        ModifiedDateTime = o.ModifiedDateTime
                                    }).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public EmployeeModel EmployeeLogin(AdminLogin login)
        {
            try
            {
                return this.context.Employees.Where(x =>
                                                 x.Email == login.Email && x.Password == login.Password
                                                 && x.Role == "Employee")
                                    .Select(o => new EmployeeModel
                                    {
                                        EmployeeId = o.EmployeeId,
                                        Email = o.Email,
                                        FirstName = o.FirstName,
                                        LastName = o.LastName,
                                        PhoneNumber = o.PhoneNumber,
                                        CreatedDateTime = o.CreatedDateTime,
                                        Role = o.Role,
                                        ModifiedDateTime = o.ModifiedDateTime
                                    }).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<EmployeeModel> GetAllEmployee()
        {
            try
            {
                return this.context.Employees.Where(x => x.Role == "Employee")
                    .Select(o => new EmployeeModel
                    {
                        EmployeeId = o.EmployeeId,
                        Email = o.Email,
                        FirstName = o.FirstName,
                        LastName = o.LastName,
                        PhoneNumber = o.PhoneNumber,
                        CreatedDateTime = o.CreatedDateTime,
                        Role = o.Role,
                        ModifiedDateTime = o.ModifiedDateTime
                    })
                    .ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool RegisterAdmin(RegisterModel admin)
        {
            try
            {
                CompanyEmployee adminObject = new CompanyEmployee()
                {
                    FirstName = admin.FirstName,
                    LastName = admin.LastName,
                    Email = admin.Email,
                    Password = admin.Password,
                    PhoneNumber = admin.PhoneNumber,
                    Role = "Admin",
                    CreatedDateTime = DateTime.UtcNow,
                    ModifiedDateTime = null
                };

                this.context.Employees.Add(adminObject);
                int result = this.context.SaveChanges();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
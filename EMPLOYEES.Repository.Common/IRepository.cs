using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EMPLOYEES.DAL.DataModel;
using EMPLOYEES.Model;

namespace EMPLOYEES.Repository.Common
{
  public interface IRepository
    {
     IEnumerable<EmployeesIvozab> GetAllEmployeesDb();
        IEnumerable<EmployeesDomain> GetAllEmployeesDomain();
       EmployeesDomain GetAllEmployeesDomainById(int employeeId);
        Task<bool> AddEmployeeAsync(EmployeesDomain employee);
    }
}

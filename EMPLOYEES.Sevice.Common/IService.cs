using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EMPLOYEES.DAL.DataModel;
using EMPLOYEES.Model;

namespace EMPLOYEES.Sevice.Common
{
   public interface IService
    {
        IEnumerable<EmployeesIvozab> GetAllEmployeesDb();
        IEnumerable<EmployeesDomain> GetAllEmployeesDomain();
        EmployeesDomain GetAllEmployeesDomainById(int employeeId);
        Task<bool> AddEmployeeAsync(EmployeesDomain employee);
    }
}

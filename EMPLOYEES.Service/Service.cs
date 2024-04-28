using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMPLOYEES.DAL.DataModel;
using EMPLOYEES.Model;
using EMPLOYEES.Repository;
using EMPLOYEES.Repository.Common;
using EMPLOYEES.Sevice.Common;

namespace EMPLOYEES.Service
{
    public class Service : IService
    {
        readonly IRepository _repository;
        public Service(IRepository repository)
        {
            _repository = repository;
          
        }

        public Task<bool> AddEmployeeAsync(EmployeesDomain employee)
        {
            try
            {
                await _repository.AddEmployeeAsync(employee);
                return true; 
            }
            catch (Exception ex)
            {
                return false; 
            }
        }

        public IEnumerable<EmployeesIvozab> GetAllEmployeesDb()
        {
            IEnumerable<EmployeesIvozab> employeesDb = _repository.GetAllEmployeesDb();
            return employeesDb;
        }

        public IEnumerable<EmployeesDomain> GetAllEmployeesDomain()
        {
             IEnumerable<EmployeesDomain> employeesDomains = _repository.GetAllEmployeesDomain();
            return employeesDomains;
        }

        public EmployeesDomain GetAllEmployeesDomainById(int employeeId)
        {
            var employeeid = _repository.GetEmployeeDomainByEmployeeId(employeeId);
            return employeeid;
           
        }
    }
}

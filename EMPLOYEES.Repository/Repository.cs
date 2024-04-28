using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMPLOYEES.DAL.DataModel;
using EMPLOYEES.Model;
using EMPLOYEES.Repository.Common;

namespace EMPLOYEES.Repository
{
    public class Repository : IRepository
    {
        private readonly EMPLOYEES_DbContext _appDbContext;
        private IRepositoryMappingService _mappingService;

        public Repository(EMPLOYEES_DbContext appDbContext, IRepositoryMappingService mapper)
        {
            _appDbContext = appDbContext;
            _mappingService = mapper;
        }
         public async Task<bool> AddEmployeeAsync(EmployeesDomain employee)
        {
            try
            {
                var employeeEntity = new EmployeesIvozab
                {
                    BirthDate = employee.BirthDate,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName
                };

                
                _appDbContext.EmployeesIvozab.Add(employeeEntity);

                
                await _appDbContext.SaveChangesAsync();

                
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        

        public IEnumerable<EmployeesIvozab> GetAllEmployeesDb()
        {
            IEnumerable<EmployeesIvozab> employeesDb = _appDbContext.EmployeesIvozab.ToList();
            return employeesDb;
           
        }

        public IEnumerable<EmployeesDomain> GetAllEmployeesDomain()
        {

            var employeesDb = _appDbContext.EmployeesIvozab.ToList();
            var employeesDomain = employeesDb.Select(e => new EmployeesDomain(e));
            return employeesDomain;
        }

        public EmployeesDomain GetAllEmployeesDomainById(int employeeId)
        {var employeeDb = _appDbContext.EmployeesIvozab.FirstOrDefault(e => e.EmpNo == employeeId);

            if (employeeDb != null)
            {
                return new EmployeesDomain(employeeDb);
            }
            else
            {
                return null; 
            }
           
        }
    }
}

using EMPLOYEES.DAL.DataModel;
using EMPLOYEES.Service;
using EMPLOYEES.Sevice.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMPLOYEES.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        protected IService _service { get; private set; }
        public EmployeesController(IService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("employees_db")]
        public IEnumerable<EmployeesIvozab > GetAllUsersDb()
        {
            IEnumerable<EmployeesIvozab> employeesDb = _service.GetAllEmployeesDb();
            return employeesDb;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EMPLOYEES.Repository
{
   public interface IRepositoryMappingService
    {
        TDestination Map<TDestination>(object source);
    }
}

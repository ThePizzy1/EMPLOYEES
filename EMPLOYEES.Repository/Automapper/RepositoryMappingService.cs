using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using EMPLOYEES.DAL.DataModel;
using EMPLOYEES.Model;
using EMPLOYEES.Repository.Common;
namespace EMPLOYEES.Repository
{
   public class RepositoryMappingService: IRepositoryMappingService
    {
        public Mapper mapper;
        public RepositoryMappingService()
        {
            var config = new MapperConfiguration(
                cfg => {
                    cfg.CreateMap <EmployeesIvozab, EmployeesDomain>();
                    cfg.CreateMap<EmployeesDomain, EmployeesIvozab>();

                }
                );
            mapper = new Mapper(config);
        }

        public TDestination Map<TDestination>(object source)
        {
            return mapper.Map<TDestination>(source);
        }
    }
}

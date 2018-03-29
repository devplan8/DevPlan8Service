using BusinessEntity;
using DataAccess.HumanResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataEntity.Model;

namespace BusinessLogic.HumanResources
{
    public class EmployeeBLO
    {
        public List<EmployeeBE> Get()
        {
            EmployeeDAC dac = new EmployeeDAC();
            //List<EmployeeBE> listbe = new List<EmployeeBE>();
            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<List<Employee>, List<EmployeeBE>>();
            //});

            //config.AssertConfigurationIsValid();
            //Mapper.Initialize(config);
            Mapper.Initialize(cfg => cfg.CreateMap<Employee, EmployeeBE>());

            Mapper.Configuration.AssertConfigurationIsValid();
            List<EmployeeBE> listbe = Mapper.Map<List<Employee>, List<EmployeeBE>>(dac.Get());
            return listbe;

        }

        public bool Insert(EmployeeBE emp)
        {
            Mapper.Initialize(cf => cf.CreateMap<EmployeeBE, Employee>());
            EmployeeDAC dac = new EmployeeDAC();
            dac.Insert(Mapper.Map<EmployeeBE, Employee>(emp));
            return true;
        }
    }
}

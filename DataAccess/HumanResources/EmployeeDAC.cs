using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntity.Model;
using DataAccess.UnitOfWork;


namespace DataAccess.HumanResources
{
    public class EmployeeDAC
    {
        private HumanResourcesEntities entity = new HumanResourcesEntities();

        public List<Employee> Get()
        {
            entity = new HumanResourcesEntities();
            List<Employee> listemployee = null;
            UnitOfWorkHelper uow = new UnitOfWorkHelper(entity);
            listemployee = uow.Repository<Employee>().Get().ToList();
            return listemployee;
        }
        public void Insert(Employee employee)
        {
            UnitOfWorkHelper uow = new UnitOfWorkHelper(entity);
            uow.Repository<Employee>().Insert(employee);
        }

    }
}

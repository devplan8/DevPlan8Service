using BusinessEntity;
using BusinessLogic.HumanResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DevPlan8Service.Controllers
{
    public class EmployeeController : BaseAPIController
    {
        public HttpResponseMessage Get()
        {
            List<EmployeeBE> listbe = new List<EmployeeBE>();
            EmployeeBLO blo = new EmployeeBLO();
            listbe=blo.Get();
            return ConvertToJson(listbe);
        }
       [HttpPost]
        public HttpResponseMessage Post([FromBody]EmployeeBE emp)
        {
            EmployeeBLO blo = new EmployeeBLO();
            if (blo.Insert(emp))
            {
                var response = Request.CreateResponse(HttpStatusCode.Created);
                return response;
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
    }
}

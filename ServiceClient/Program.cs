﻿using BusinessEntity;
using BusinessLogic.HumanResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            List<EmployeeBE> listbe = new List<EmployeeBE>();
            EmployeeBLO blo = new EmployeeBLO();
            listbe = blo.Get();
            //return ConvertToJson(listbe);
        }
    }
}

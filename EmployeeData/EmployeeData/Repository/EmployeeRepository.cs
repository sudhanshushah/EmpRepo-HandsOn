using EmployeeData.Models;
using EmployeeData.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeData.Repository
{
    public class EmployeeRepository : Repository<Employee>
    {
        public EmployeeRepository(EmpContext context) : base(context)
        {

        }
    }
}
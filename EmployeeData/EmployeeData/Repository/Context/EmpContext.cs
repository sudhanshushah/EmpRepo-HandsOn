using EmployeeData.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeData.Repository.Context
{
    public class EmpContext: DbContext
    {
        public EmpContext() : base("constr") { }

        public DbSet<Employee> Employees { get; set; }
    }
}
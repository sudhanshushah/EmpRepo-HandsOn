using EmployeeData.Repository.Context;
using EmployeeData.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeData.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private EmployeeRepository erepository;
        private EmpContext ec;
        public UnitOfWork(EmpContext ec)
        {
            this.ec = ec;
            erepository = new EmployeeRepository(ec);
        }

        public EmployeeRepository Employees
        {
            get
            {
                return erepository;
            }
        }

        public int Complete()
        {
            return ec.SaveChanges();
        }
    }
}
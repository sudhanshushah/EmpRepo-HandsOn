﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeData.Repository.Contract
{
    public interface IUnitOfWork
    {
        EmployeeRepository Employees { get; }

        int Complete();
    }
}
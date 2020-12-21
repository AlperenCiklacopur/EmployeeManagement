using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DataContext;
using EmployeeManagement.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Data.Implementation
{
    public class EmployeeLeaveTypeRepository : Repository<EmployeeLeaveType>, IEmployeeLeaveTypeRepository
    {
        private readonly EmployeeManagementContext _ctx;
        public EmployeeLeaveTypeRepository(EmployeeManagementContext ctx) :base(ctx)
        {
            _ctx = ctx;

        }
    }
}

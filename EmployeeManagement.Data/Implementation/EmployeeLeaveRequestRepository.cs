using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DataContext;
using EmployeeManagement.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Data.Implementation
{
    public class EmployeeLeaveRequestRepository: Repository<EmployeeLeaveRequest>, IEmployeeLeaveRequestRepository
    {
        private readonly EmployeeManagementContext _ctx;
        public EmployeeLeaveRequestRepository(EmployeeManagementContext ctx): base(ctx)
        {
            _ctx = ctx;

        }

    }
}

using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DataContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Data.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeManagementContext _ctx;

        public UnitOfWork(EmployeeManagementContext ctx)
        {
            _ctx = ctx;
            employeeLeaveAllocationRepository = new EmployeeLeaveAllocationRepository(_ctx);
            employeeLeaveRequestRepository = new EmployeeLeaveRequestRepository(_ctx);
            employeeLeaveTypeRepository = new EmployeeLeaveTypeRepository(_ctx);
        }
        public IEmployeeLeaveAllocationRepository employeeLeaveAllocationRepository { get; private set; }
        public IEmployeeLeaveRequestRepository employeeLeaveRequestRepository { get; private set; }
        public IEmployeeLeaveTypeRepository employeeLeaveTypeRepository { get; private set; }
        public void Dispose()
        {
            _ctx.Dispose();
        }

        public void Save()
        {
            _ctx.SaveChanges();
        }
    }
}

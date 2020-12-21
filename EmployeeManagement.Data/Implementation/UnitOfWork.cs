using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DataContext;
using EmployeeManagement.Data.Implementaion;

namespace EmployeeManagement.Data.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeManagementContext _ctx;

        public UnitOfWork(EmployeeManagementContext ctx)
        {
            _ctx = ctx;
            EmployeeLeaveAllocationRepository = new EmployeeLeaveAllocationRepository(_ctx);
            EmployeeLeaveRequestRepository = new EmployeeLeaveRequestRepository(_ctx);
            EmployeeLeaveTypeRepository = new EmployeeLeaveTypeRepository(_ctx);
        }
        public IEmployeeLeaveAllocationRepository EmployeeLeaveAllocationRepository { get; private set; }
        public IEmployeeLeaveRequestRepository EmployeeLeaveRequestRepository { get; private set; }
        public IEmployeeLeaveTypeRepository EmployeeLeaveTypeRepository { get; private set; }
        public void Save()
        {
            _ctx.SaveChanges();
        }
        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}

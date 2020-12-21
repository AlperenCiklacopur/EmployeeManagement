using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Data.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeLeaveAllocationRepository EmployeeLeaveAllocationRepository { get; }
        IEmployeeLeaveRequestRepository EmployeeLeaveRequestRepository { get; }
        IEmployeeLeaveTypeRepository EmployeeLeaveTypeRepository { get; }
        void Save();
    }
}

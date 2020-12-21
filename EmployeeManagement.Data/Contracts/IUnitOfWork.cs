using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Data.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}

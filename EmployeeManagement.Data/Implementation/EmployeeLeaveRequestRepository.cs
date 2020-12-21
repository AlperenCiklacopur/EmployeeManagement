using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DataContext;
using EmployeeManagement.Data.DbModels;
using EmployeeManagement.Data.Implementation;

namespace EmployeeManagement.Data.Implementaion
{
    public class EmployeeLeaveRequestRepository : Repository<EmployeeLeaveRequest>, IEmployeeLeaveRequestRepository
    {
        public readonly EmployeeManagementContext _ctx;

        public EmployeeLeaveRequestRepository(EmployeeManagementContext ctx)
            : base(ctx)
        {
        }
    }
}

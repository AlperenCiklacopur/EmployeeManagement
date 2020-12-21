using EmployeeManagement.Data.DbModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Data.DataContext
{
    public class EmployeeManagementContext : IdentityDbContext
    {
        public EmployeeManagementContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Employee>  Employee { get; set; }
        public DbSet<EmployeeLeaveAllocation> EmployeeLeaveAllocations { get; set; }
        public DbSet<EmployeeLeaveRequest> EmployeeLeaveRequests { get; set; }
        public DbSet<EmployeeLeaveType> EmployeeLeaveTypes { get; set; }
    }
}

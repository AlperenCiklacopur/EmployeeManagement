using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Common.VModels
{
    public class EmployeeLeaveAllocationVM : BaseVM
    {

        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public int Period { get; set; }
        public string EmployeeId { get; set; }
        public EmployeeVM EmployeeVM { get; set; }
        public int EmployeeLeaveTypeId { get; set; }
        public EmployeeLeaveTypeVM EmployeeLeaveTypeVM { get; set; }
    }
    

}

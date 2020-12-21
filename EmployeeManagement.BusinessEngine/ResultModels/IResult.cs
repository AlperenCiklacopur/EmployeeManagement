using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.BusinessEngine.ResultModels
{
    public interface IResult
    {
        bool IsSucces { get; set; }
        string Message { get; set; }
    }
}

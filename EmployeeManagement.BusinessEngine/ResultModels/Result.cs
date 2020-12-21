using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.BusinessEngine.ResultModels
{
    public class Result<T> : IResult
    {
        public bool IsSucces { get ; set; }
        public string Message { get ; set; }

        public T Data { get; set; }
        public int TotalCount { get; set; }
        public Result(bool isSucces,string message) : this(isSucces, message, default(T))
        {

        }

        public Result(bool isSucces, string message, T data) : this(isSucces, message, data,0)
        {

        }
        public Result(bool isSucces, string message,T data, int totalCount) 
        {
            IsSucces = isSucces;
            Message = message;
            Data = data;
            TotalCount = totalCount;
            
        }

    }
}

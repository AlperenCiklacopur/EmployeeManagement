using AutoMapper;
using EmployeeManagement.BusinessEngine.Contracts;
using EmployeeManagement.BusinessEngine.ResultModels;
using EmployeeManagement.Common.ConstantsModel;
using EmployeeManagement.Common.VModels;
using EmployeeManagement.Data.Contracts;
using EmployeeManagement.Data.DbModels;
using EmployeeManagement.Data.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EmployeeManagement.BusinessEngine.Implementation
{
    public class EmployeeLeaveTypeBusinessEngine : IEmployeeLeaveTypeBusinessEngine
    {
        #region Variables

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        #endregion

        #region Constructor
        public EmployeeLeaveTypeBusinessEngine(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        
        #endregion

        #region CustomMethods
        public Result<List<EmployeeLeaveTypeVM>> GetAllEmployeLeaveTypes()
        {
            var data = _unitOfWork.EmployeeLeaveTypeRepository.GetAll().ToList();
            #region 1.Yöntem
            // if (data != null)
            //{
            //  List<EmployeeLeaveType> returnData = new List<EmployeeLeaveType>(); 
            //foreach (var item in data)
            // {
            //   returnData.Add(new EmployeeLeaveType()
            // {
            //   Id = item.Id,
            // DateCreated = item.DateCreated,
            //DefaultDays= item.DefaultDays,
            //Name=item.Name
            //}) ;
            //}
            //return new Result<List<EmployeeLeaveType>>(true, ResultConstants.RecordFound, returnData);

            //}
            //else { return new Result<List<EmployeeLeaveType>>(false, ResultConstants.RecordNotFound); } 
            #endregion

            #region 2.Yöntem
            var leaveTypes = _mapper.Map<List<EmployeeLeaveType>, List<EmployeeLeaveTypeVM>>(data);
            return new Result<List<EmployeeLeaveTypeVM>>(true, ResultConstants.RecordFound, leaveTypes);
            #endregion
        }
        public Result<EmployeeLeaveRequestVM> CreateEmployeeLeaveType(EmployeeLeaveTypeVM model)
        {
            if (model != null)
            {
                try
                {
                    var leaveType = _mapper.Map<EmployeeLeaveTypeVM, EmployeeLeaveType>(model);
                    leaveType.DateCreated = DateTime.Now;
                    _unitOfWork.EmployeeLeaveTypeRepository.Add(leaveType);
                    _unitOfWork.Save();
                    return new Result<EmployeeLeaveRequestVM>(true, ResultConstants.RecordCreated);
                }
                catch (Exception ex)
                {

                    return new Result<EmployeeLeaveRequestVM>(false, ResultConstants.RecordNotCreated + "  " + ex.Message.ToString());
                }
            }
            else
            {
                return new Result<EmployeeLeaveRequestVM>(false, "Parametre olarak geçirile data boş olamaz");
            }
        }

        





        #endregion
    }
}
